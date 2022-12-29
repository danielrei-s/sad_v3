using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button_mapa_Click(object sender, EventArgs e)
        {
            mapa_form_UC1.Show();
            mapa_form_UC1.BringToFront();
        }

        
    }
}
