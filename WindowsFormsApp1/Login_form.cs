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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");

        private void button_exit_Click(object sender, EventArgs e)
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_userpw.Clear();

            txt_username.Focus();
        }

        private void registo_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menuregisto_form menuregisto = new Menuregisto_form();
            menuregisto.Show();
            this.Hide();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            try
            {
                conn.Open();

                String query = "SELECT * FROM Utilizadores WHERE user_login = @username AND user_pw = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_userpw.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    main_form form1 = new main_form();
                    form1.Show();
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

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
