using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAD_TEST
{
    

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");






        private void button3_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_userpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            String user_name, user_pw;

            user_name = txt_username.Text;
            user_pw = txt_userpw.Text;

            try
            {
                String query = "SELECT * FROM Utilizadores WHERE user_login = '"+txt_username.Text+"' AND user_pw = '"+txt_userpw.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    user_name = txt_username.Text;
                    user_pw = txt_userpw.Text;

                    Menuform menuform = new Menuform();
                    menuform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados de Login incorrectos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_userpw.Clear();

                    // focus user
                    txt_username.Focus();

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

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_userpw.Clear();

            txt_username.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void link_registo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menuregisto menuregisto= new Menuregisto();
            menuregisto.Show();
            this.Hide();
        }
    }
}
