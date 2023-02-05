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

namespace WindowsFormsApp1
{
    public partial class Localidade_form : Form
    {
        public Localidade_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
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
