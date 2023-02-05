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
    public partial class Nut_form : Form
    {
        public Nut_form()
        {
            InitializeComponent();
        }
                
        private string selectedItem = "";

            
        private void dropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            selectedItem = e.ClickedItem.Text;
            MessageBox.Show(selectedItem + " clicked.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item 1");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item 2");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item 3");

          //  dropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { item1, item2, item3 });
        }

            private void Nut_form_Load(object sender, EventArgs e)
        {

        }
    }
}
