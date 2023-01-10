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
        

        private void search_button_Click(object sender, EventArgs e)
        {
            StringBuilder queryadress= new StringBuilder();
            queryadress.Append("http://google.com/maps?q=");

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L4ONO2J\\SQLEXPRESS;Initial Catalog=SAD_DB;Integrated Security=True");
            
            conn.Open();
            SqlCommand qcoordx = new SqlCommand("SELECT coord_x FROM Data_ODS WHERE id = '" + txtboxid.Text + "'", conn);
            float coordx1 = (float)((double)qcoordx.ExecuteScalar());
            // buscar coordenada X

            SqlCommand qcoordy = new SqlCommand("SELECT coord_y FROM Data_ODS WHERE id = '" + txtboxid.Text + "'", conn);
            float coordy1 = (float)((double)qcoordy.ExecuteScalar());
            // buscar coordenada Y

            string stringcoordx1 = coordx1.ToString();
            string stringcoordy1 = coordy1.ToString();

            StringBuilder strX = new StringBuilder(stringcoordx1);
            strX[2] = '.';

            StringBuilder strY = new StringBuilder(stringcoordy1);
            strY[2] = '.';

            queryadress.Append(strX + "," + strY);

            googlemaps.Navigate(queryadress.ToString());
                
           
        }








        }

       
}

