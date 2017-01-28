using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void одномерныеМассивыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneMars form = new OneMars();
            form.MdiParent = this;
            form.Show();
        }

        private void строкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabStrings form = new LabStrings();
            form.MdiParent = this;
            form.Show();
        }

        private void базаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursBD form = new KursBD();
            form.Show();
        }
    }
}
