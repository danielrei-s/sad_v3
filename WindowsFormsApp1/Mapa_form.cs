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
       string idProjeto;
        public Mapa_form(string id)
        {
            
            InitializeComponent();
            this.idProjeto = id;
            search_button.PerformClick();
            
        }
        

        private void search_button_Click(object sender, EventArgs e)
        {
           
            StringBuilder queryadress= new StringBuilder();
            queryadress.Append("http://google.com/maps?q=");
           
            SqlDataReader reader2;

            SqlConnection conn1 = new SqlConnection("Data Source=LENOVO-CARBON\\SQLEXPRESS;Initial Catalog=SAD;Integrated Security=True");
            
            conn1.Open();
            String qr = "SELECT coord_x, coord_y, projeto FROM projetos WHERE id = '" + idProjeto + "'";
            
            SqlCommand coords = new SqlCommand(qr, conn1);
            string stringcoordx1=""; 
            string stringcoordy1="";



            try
            {
                reader2 = coords.ExecuteReader();
                
                while (reader2.Read())
                {
                    //MessageBox.Show(reader2.GetFieldType(0).ToString() );
                    stringcoordx1 = reader2.GetString(0);
                    stringcoordy1 = reader2.GetString(1);
                }

                
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }



            
            queryadress.Append(stringcoordx1 + "," + stringcoordy1);
            

            googlemaps.Navigate(queryadress.ToString());
               
           
        }

        private void googlemaps_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtboxid_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
}

