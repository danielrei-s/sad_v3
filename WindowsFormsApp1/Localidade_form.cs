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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Localidade_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LENOVO-CARBON\\SQLEXPRESS;Initial Catalog=SAD;Integrated Security=True");

        public Localidade_form()
        {
            InitializeComponent();
            button1.PerformClick();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
                    {
            //SqlConnection conn = new SqlConnection("Data Source=LENOVO-CARBON\\SQLEXPRESS;Initial Catalog=SAD;Integrated Security=True");
            string municipio = listBox1.SelectedItem.ToString();
            listBox2.Items.Clear();
        
            conn.Open();
            String query1 = "select ID, projeto from projetos where municipio = '"+ municipio+ "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlDataReader reader1;
            //List<string> projetos = new List<string>();
            try
            {
                reader1= cmd.ExecuteReader();

                while (reader1.Read())
                {
                    listBox2.Items.Add(reader1["ID"] + " - " + reader1["projeto"]);

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {


            conn.Open();
            String query1 = "select distinct municipio from projetos";
            SqlCommand teste = new SqlCommand(query1, conn);
            SqlDataReader reader = teste.ExecuteReader();
            List<string> municipios = new List<string>();
            while (reader.Read())
            {
                municipios.Add(reader["municipio"].ToString());
            }
            reader.Close();
            conn.Close();

            listBox1.DataSource = municipios;
        }


        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            string linha = listBox2.SelectedItem.ToString();
            string id = linha.Substring(0, linha.IndexOf("-"));
            Mapa_form mf = new Mapa_form(id);
            mf.Location = new Point(635, 273);
            mf.Activate();
            mf.Show();
        }
        private void Localidade_forms_Load(object sender, System.EventArgs e)
        {
            conn.Open();
            String query1 = "select distinct municipio from projetos";
            SqlCommand teste = new SqlCommand(query1, conn);
            SqlDataReader reader = teste.ExecuteReader();
            List<string> municipios = new List<string>();
            while (reader.Read())
            {
                municipios.Add(reader["municipio"].ToString());
            }
            reader.Close();
            conn.Close();

            listBox1.DataSource = municipios;
        }
    }
}
