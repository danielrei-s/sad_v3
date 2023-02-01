using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class ODS_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
        List<string> odsSelection = new List<string>(); 
        Dictionary<string, int> odsValues = new Dictionary<string, int>();
        public ODS_form()
        {
            InitializeComponent();
            for (int i = 0; i < 17; i++)
            {
                odsSelection.Add("ods" + (i + 1));
                //MessageBox.Show(odsSelection.ElementAt(i));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_ods_Click(object sender, EventArgs e)
        {

        }

        private void FILLDGV()
        {
            string odsinput = "1";
            odsinput = txtods.Text;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            conn.Open();
            string query = " Select Projeto, minicipio From Data_ODS WHERE ods" + odsinput + ">4";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            conn.Close();
        }

        private void APRIORI() //todo
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            conn.Open();

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            FILLDGV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                odsSelection.Remove("ods1");
            }
            else
            {
                MessageBox.Show("disable");
            }
        }

        private void seguinte_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            conn.Open();
            for (int i = 0; i < odsSelection.Count; i++)
            {
                String query1 = "SELECT COUNT (" +
                                odsSelection.ElementAt(i) +
                                ") FROM Data_ODS WHERE " +
                                odsSelection.ElementAt(i) + " >4";

                //   String query1 = "SELECT COUNT (*) FROM Data_ODS WHERE " +
                //                     odsSelection.ElementAt(i) + " >4";

                SqlCommand teste = new SqlCommand(query1, conn);
                int contagemOds = (int)teste.ExecuteScalar();

                if (!odsValues.ContainsKey(odsSelection.ElementAt(i)))
                {
                    odsValues.Add(odsSelection.ElementAt(i), contagemOds);
                }
                else
                {
                    // Key already exists, do something else or update the value
                    odsValues[odsSelection.ElementAt(i)] = contagemOds;
                }
            }

            List<string> combinations = new List<string>();
            foreach (var key1 in odsValues.Keys)
            {
                foreach (var key2 in odsValues.Keys)
                {
                    if (key1 != key2)
                    {
                        combinations.Add(key1 + " > 4 AND " + key2 + " > 4");
                    }
                }
                //MessageBox.Show(combinations.ElementAt(1));
            }

            Dictionary<string, int> combinationCounts = new Dictionary<string, int>();

            foreach (string combination in combinations)
            {
                String query = "SELECT COUNT(*) FROM Data_ODS WHERE " + combination;
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = (int)cmd.ExecuteScalar();
                combinationCounts.Add(combination, count);
            }

            bool keepIterating = true;
            while (keepIterating)
            {
                var orderedCombinationCounts = combinationCounts.OrderBy(x => x.Value).ToList();
                int numCombinationsToKeep = orderedCombinationCounts.Count / 2;

                Dictionary<string, int> filteredCombinationCounts = new Dictionary<string, int>();
                for (int i = 0; i < numCombinationsToKeep; i++)
                {
                    filteredCombinationCounts.Add(orderedCombinationCounts[i].Key, orderedCombinationCounts[i].Value);
                }

                combinationCounts = filteredCombinationCounts;

                if (combinationCounts.Count == 1)
                {
                    keepIterating = false;
                }
            }
            foreach (KeyValuePair<string, int> item in combinationCounts)
            {
                MessageBox.Show(item.Key + ": " + item.Value);
            }
            conn.Close();
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
