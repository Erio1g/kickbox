using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trajning
{
    public partial class nav : Form
    {
        public nav()
        {
            InitializeComponent();
        }

        private void pagesatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagesat p= new pagesat();
            p.Show();
        }

        private void listatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); 
            f.Show();
        }

        private void nav_Load(object sender, EventArgs e)
        {

        }
    }
}
