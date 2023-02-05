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
using Cotur.DataMining.Association;

namespace WindowsFormsApp1
{
  
    public partial class ODS_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
        List<string> odsSelection = new List<string>(); 
        List <int> valoresTransacoes = new List<int>();
        List<bool[]> Rows = new List<bool[]> ();
        int valorODS = 1;
        float support=0.5f;
        String NUT = "";

        string query2 = "";
        
        Dictionary<string, int> odsValues = new Dictionary<string, int>();
        int odsMinValue = 5;
        public ODS_form()
        {
            InitializeComponent();
            for (int i = 0; i < 17; i++)
            {
                odsSelection.Add("ods" + (i + 1));
                //MessageBox.Show(odsSelection.ElementAt(i));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                odsSelection.Add("ods1");
            }
            else
            {
                odsSelection.Remove("ods1");
            }
        }

        private void seguinte_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            conn.Open();

            string qweryODS= odsSelection.ElementAt(0);
            bool[] row = new bool[odsSelection.Count];
            for (int i = 1; i < odsSelection.Count; i++)
            {
                qweryODS = qweryODS +","+ odsSelection.ElementAt(i) ; 
            }
           
             

            String query1 = "SELECT  "+ qweryODS + " FROM projetos";
           // MessageBox.Show(query1);
            SqlCommand teste = new SqlCommand(query1, conn);
            Rows.Clear();
            try
            {
                SqlDataReader reader = teste.ExecuteReader();
               
                while (reader.Read())
                {
                    for (int x = 0; x < odsSelection.Count; x++)
                    {
                        if (((int)reader.GetByte(x)) >= valorODS)
                        {
                            row[x] = true;
                        }
                        else
                        {
                             row[x] = false;
                        }
                        

                    }
                    Rows.Add(row);
                }
            } catch {

                MessageBox.Show("exceptio sql");
            }
            //MessageBox.Show(Rows.Count+"Rows");
            conn.Close();
              
            
           Apriori myApriori = new Apriori(new DataFields(odsSelection, Rows));
            float minimumSupport = 0.7f;
            try
            {
                myApriori.CalculateCNodes(support);
            }
            catch {

                MessageBox.Show("A selecção que efectuou não possui dados suficientes");
            }
            List<string> resultado = new List<string>();
          
            
            foreach (var Levels in myApriori.EachLevelOfNodes)
            {
                foreach (var node in Levels)
                {


                    //MessageBox.Show(node.ToDetailedString(myApriori.Data));
                   // richTextBox1.Text += node.ToDetailedString(myApriori.Data) + "\n";
                    resultado.Add(node.ToDetailedString(myApriori.Data));

                }
            }

            
            SqlCommand res;
            SqlDataReader reader1;
            String query2 = "";
            for (int a=resultado.Count-1; a >= 0; a--) {
                conn.Open();
                query2 = "SELECT  ID, projeto, Municipio, coord_x, coord_y FROM projetos where " + resultado.ElementAt(a).Replace(","," >= " +valorODS +" and ") + " >= " + valorODS;
                //MessageBox.Show(query2);
                res = new SqlCommand(query2, conn);

                try
                {
                     reader1 = res.ExecuteReader();

                    while (reader1.Read())
                    {
                        listBox1.Items.Add(reader1.GetByte(0) + " - " + reader1.GetString(1) + " - " + reader1.GetString(2) );
                       
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
                conn.Close();
               
            }



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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                odsSelection.Add("ods3");
                           }
            else
            {
                odsSelection.Remove("ods3");
               
                
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                odsSelection.Add("ods2");
            }
            else
            {
                odsSelection.Remove("ods2");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                odsSelection.Add("ods4");
            }
            else
            {
                odsSelection.Remove("ods4");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                odsSelection.Add("ods5");
            }
            else
            {
                odsSelection.Remove("ods5");
            }
        }


        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                odsSelection.Add("ods6");
            }
            else
            {
                odsSelection.Remove("ods6");
            }

        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                odsSelection.Add("ods7");
            }
            else
            {
                odsSelection.Remove("ods7");
            }

        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                odsSelection.Add("ods8");
            }
            else
            {
                odsSelection.Remove("ods8");
            }

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                odsSelection.Add("ods9");
            }
            else
            {
                odsSelection.Remove("ods9");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                odsSelection.Add("ods10");
            }
            else
            {
                odsSelection.Remove("ods10");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                odsSelection.Add("ods11");
            }
            else
            {
                odsSelection.Remove("ods11");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                odsSelection.Add("ods12");
            }
            else
            {
                odsSelection.Remove("ods12");
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                odsSelection.Add("ods13");
            }
            else
            {
                odsSelection.Remove("ods13");
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                odsSelection.Add("ods14");
            }
            else
            {
                odsSelection.Remove("ods14");
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                odsSelection.Add("ods15");
            }
            else
            {
                odsSelection.Remove("ods15");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                odsSelection.Add("ods16");
            }
            else
            {
                odsSelection.Remove("ods16");
            }

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                odsSelection.Add("ods17");
            }
            else
            {
                odsSelection.Remove("ods17");
            }
        }


        private void seletorNivelOds_Scroll(object sender, EventArgs e)
        {
            valorODS = seletorNivelOds.Value;
            label2.Text = "Default ODS value = " + valorODS;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsupp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                support = float.Parse(txtsupp.Text);
                support = support / 100;

            }
            catch {
                txtsupp.Text = "";
                MessageBox.Show("O valor introduzido não é válido \n Introduza um valor numérico");
                txtsupp.Focus();
            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }else
            {
                checkBox1.Checked = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
            }
            else
            {
                checkBox5.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.Checked = false;
            }
            else
            {
                checkBox6.Checked = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Checked = false;
            }
            else
            {
                checkBox7.Checked = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.Checked = false;
            }
            else
            {
                checkBox8.Checked = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox9.Checked = false;
            }
            else
            {
                checkBox9.Checked = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox10.Checked = false;
            }
            else
            {
                checkBox10.Checked = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox11.Checked = false;
            }
            else
            {
                checkBox11.Checked = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox12.Checked = false;
            }
            else
            {
                checkBox12.Checked = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox13.Checked = false;
            }
            else
            {
                checkBox13.Checked = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox14.Checked = false;
            }
            else
            {
                checkBox14.Checked = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox15.Checked = false;
            }
            else
            {
                checkBox15.Checked = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox16.Checked = false;
            }
            else
            {
                checkBox16.Checked = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                checkBox17.Checked = false;
            }
            else
            {
                checkBox17.Checked = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string linha = listBox1.SelectedItem.ToString();
            string id = linha.Substring(0, linha.IndexOf("-"));
            Mapa_form mf = new Mapa_form(id);
            mf.Location = new Point(635, 273);
            mf.Activate();
            mf.Show();            

        }

        private void ODS_form_Load(object sender, EventArgs e)
        {

        }


        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            conn.Open();
           
            string qweryODS = odsSelection.ElementAt(0);
            bool[] row = new bool[odsSelection.Count];
            String testeODS = "";

            for (int i = 0; i < odsSelection.Count-1; i++)
            {
                testeODS += odsSelection.ElementAt(i) + " >= " + valorODS + " AND "; 
            }
            testeODS += odsSelection.ElementAt(odsSelection.Count-1) + " >= " + valorODS;

            //MessageBox.Show(testeODS);

            query2 = "SELECT ID, projeto, Municipio FROM projetos where " + NUT + testeODS;
            MessageBox.Show(query2);
           

            SqlCommand teste = new SqlCommand(query2, conn);
            Rows.Clear();
            SqlCommand res;
            SqlDataReader reader1;
           
            //MessageBox.Show(query2);
            res = new SqlCommand(query2, conn);

            try
            {
                reader1 = res.ExecuteReader();

                while (reader1.Read())
                {
                    listBox1.Items.Add(reader1.GetString(0) + " - " + reader1.GetString(1) + " - " + reader1.GetString(2));

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();

            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Text = "Select";
        }
       

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void norteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            NUT = "Nuts_2 = 1 AND ";
            

        }

        private void algarveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            NUT = "Nuts_2 = 2 AND ";
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            NUT = "Nuts_2 = 3 AND ";


        }

        private void aMLisboaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            NUT = "Nuts_2 = 4 AND ";
        }

        private void alentejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            NUT = "Nuts_2 = 5 AND ";

        }

        private void rAAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            NUT = "Nuts_2 = 6 AND ";

        }

        private void rAMadeiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            NUT = "Nuts_2 = 7 AND ";

        }

        private void aLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            NUT = "";
        }
    }
}
