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
    public partial class Mapa_form : Form
    {
        public Mapa_form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");

        private void search_button_Click(object sender, EventArgs e)
        {
            String id = txtboxid.Text;
            
            StringBuilder queryadress= new StringBuilder();
            queryadress.Append("http://google.com/maps?q=");

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            

            try
            {
                String coordx = "SELECT coord_x FROM Data.ODS WHERE id = '" + txtboxid.Text + "'" ;
                String coordy = "SELECT coord_y FROM Data.ODS WHERE id = '" + txtboxid.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(coordx, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {

                    Console.WriteLine(dtable.Rows[0].ToString());
                    //dtable.Rows.
                    //user_name = txt_username.Text;
                    //user_pw = txt_userpw.Text;
                    //queryadress.Append()
                    //main_form form1 = new main_form();
                    //form1.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados de Login incorrectos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxid.Clear();

                    // focus user
                    txtboxid.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Erro Inesperado");
            }
            finally
            {
                conn.Close();
            }


        }

        private void txtboxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
