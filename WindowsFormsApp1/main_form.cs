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
            panel_main.Controls.Clear();
            Mapa_form mapa = new Mapa_form();
            mapa.TopLevel = false;
            panel_main.Controls.Add(mapa);
            mapa.BringToFront();
            mapa.Show();
        }

        private void mapa_form_UC1_Load(object sender, EventArgs e)
        {

        }

        private void button_ODS_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            ODS_form ods = new ODS_form();
            ods.TopLevel = false;
            panel_main.Controls.Add(ods);
            ods.BringToFront();
            ods.Show();
        }

        private void button_nome_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            nome_form nome = new nome_form();
            nome.TopLevel = false;
            panel_main.Controls.Add(nome);
            nome.BringToFront();
            nome.Show();    
        }

        private void button_local_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Localidade_form local = new Localidade_form();
            local.TopLevel = false;
            panel_main.Controls.Add(local);
            local.BringToFront();   
            local.Show();
        }

        private void button_nuts_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Nut_form nut = new Nut_form();
            nut.TopLevel = false;
            panel_main.Controls.Add(nut);
            nut.BringToFront();
            nut.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            panel_main.Controls.Add(exit_button);
        }

        private void exit_button_Click(object sender, EventArgs e)
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

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
