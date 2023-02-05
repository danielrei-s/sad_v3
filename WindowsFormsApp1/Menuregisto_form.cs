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
    public partial class Menuregisto_form : Form
    {
        public Menuregisto_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            String user_name, user_pw, user_email, user_repassword;

            user_name = textBox_name.Text;
            user_email = textBox_email.Text;
            user_pw = textBox_password.Text;
            user_repassword = textBox_repassword.Text;

            if (user_pw == user_repassword)
            {
                conn.Open();
                try
                {
                    String query = "INSERT INTO Utilizadores(user_id, user_email, user_login, last_log, user_pw) " +
                                "VALUES (NULL, @email, @name, NULL, @pw)";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@email", user_email);
                    command.Parameters.AddWithValue("@name", user_name);
                    command.Parameters.AddWithValue("@pw", user_pw);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration Sucessfull");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected error occurred");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }

        }

    }
}
