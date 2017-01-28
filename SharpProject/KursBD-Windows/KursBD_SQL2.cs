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
    public partial class KursBD_SQL2 : Form
    {
        KursBD_tables tables;
        bool ctrl = false;

        public KursBD_SQL2(ref KursBD_tables tables_source, bool control)
        {
            InitializeComponent();
            tables = tables_source;
            ctrl = control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ctrl)//SQL
            {
                DataTable dTable = new DataTable();
                Int32 kol = tables.dataGridView1.RowCount - 1;
                dataGridView1.DataSource = dTable;
                dTable.Columns.Add("НазваниеЦеха");
                dTable.Columns.Add("ТипОборудования");
                for (int i = 0; i < kol; i++) //Проход по таблице1
                {
                    if (tables.dataGridView1.Rows[i].Cells[3].Value.ToString() == textBox1.Text)//Сравнение с информацией из textBox
                    {
                        dTable.Rows.Add();
                        dTable.Rows[dTable.Rows.Count - 1].SetField(dTable.Columns[0], tables.dataGridView1.Rows[i].Cells[0].Value.ToString());
                        dTable.Rows[dTable.Rows.Count - 1].SetField(dTable.Columns[1], textBox1.Text);
                    }
                }
            }
            else //Программирование
            {
                OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;Data Source=|DataDirectory|\KURSBASA.mdb;Persist Security Info=True");
                OleDbCommand ol = new OleDbCommand("SELECT Таблица1.НазваниеЦеха, Таблица1.ТипОборудования FROM Таблица1 WHERE Таблица1.ТипОборудования='"+textBox1.Text+"';", connect);
                connect.Open();
                ol.CommandType = CommandType.Text;
                OleDbDataAdapter data = new OleDbDataAdapter(ol);
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void KursBD_SQL2_Load(object sender, EventArgs e)
        {

        }

    }
}
