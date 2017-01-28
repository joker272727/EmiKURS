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
    public partial class KursBD : Form
    {
        public KursBD()
        {
            InitializeComponent();
        }

        KursBD_tables tables = new KursBD_tables();

        private void просмотретьТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursBD_tables form = new KursBD_tables();
            form.MdiParent = this;
            form.Show();
        }

        private void KursBD_Load(object sender, EventArgs e)
        {
            
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursBD_task form = new KursBD_task();
            form.MdiParent = this;
            form.Show();
        }

        private void запрос1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursBD_SQL1 form = new KursBD_SQL1();
            form.SQL();
            form.MdiParent = this;
            form.Show();
        }

        private void запрос2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursBD_SQL2 form = new KursBD_SQL2(ref tables, false);
            form.MdiParent = this;
            form.Show();
        }

        private void запрос3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KursBD_SQL3 form = new KursBD_SQL3();
            form.SQL();
            form.MdiParent = this;
            form.Show();
        }

        private void запрос1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KursBD_SQL1 form = new KursBD_SQL1(ref tables);
            form.PROG();
            form.MdiParent = this;
            form.Show();
        }

        private void запрос2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KursBD_SQL2 form = new KursBD_SQL2(ref tables, true);
            form.MdiParent = this;
            form.Show();
        }

        private void запрос3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KursBD_SQL3 form = new KursBD_SQL3(ref tables);
            form.PROG();
            form.MdiParent = this;
            form.Show();
        }
    }
}
