using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SharpProject
{
    public partial class KursBD_tables : Form
    {
        public KursBD_tables()
        {
            InitializeComponent();
            this.таблица1TableAdapter.Fill(this.kURSBASADataSet.Таблица1);
            this.таблица2TableAdapter.Fill(this.kURSBASADataSet.Таблица2);
            this.Show();
            this.Visible = false;
        }

        private void KursBD_tables_Load(object sender, EventArgs e)
        {
            this.таблица2TableAdapter.Fill(this.kURSBASADataSet.Таблица2);
            this.таблица1TableAdapter.Fill(this.kURSBASADataSet.Таблица1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.таблица2TableAdapter.Update(this.kURSBASADataSet.Таблица2);
            this.таблица1TableAdapter.Update(this.kURSBASADataSet.Таблица1);
        }

    }
}
