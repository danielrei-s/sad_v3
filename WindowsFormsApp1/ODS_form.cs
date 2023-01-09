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
    public partial class ODS_form : Form
    {
        public ODS_form()
        {
            InitializeComponent();
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
    }
}
