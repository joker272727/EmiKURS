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
    public partial class KursBD_SQL3 : Form
    {
        KursBD_tables tables;
        private OleDbConnection connect;

        public KursBD_SQL3()
        {
            InitializeComponent();
            connect = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;Data Source=|DataDirectory|\KURSBASA.mdb;Persist Security Info=True");
        }

        public KursBD_SQL3(ref KursBD_tables tables_source)
        {
            InitializeComponent();
            tables = tables_source;
        }

        private void KursBD_SQL3_Load(object sender, EventArgs e) {        }

        public void SQL()
        {
            OleDbCommand ol = new OleDbCommand("TRANSFORM Sum(Таблица1.ЧислоЕдиницОборудования) AS [Sum-ЧислоЕдиницОборудования] SELECT Таблица1.НомерЦеха FROM Таблица1 GROUP BY Таблица1.НомерЦеха PIVOT Таблица1.ТипОборудования;", connect);
            connect.Open();
            ol.CommandType = CommandType.Text;
            OleDbDataAdapter data = new OleDbDataAdapter(ol);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void PROG()
        {
            DataTable dTable = new DataTable();
            dataGridView1.DataSource = dTable;
            dTable.Columns.Add("НомерЦеха");
            for (int i = 0; i < tables.dataGridView2.RowCount - 1; i++) //Добавление типов оборудования в названия столбцов
                dTable.Columns.Add(tables.dataGridView2.Rows[i].Cells[0].Value.ToString());
            for(int i = 0; i < tables.dataGridView1.RowCount - 1; i++) //Проход по таблице1
            {
                bool control = true;
                for(int j = 0; j < dTable.Rows.Count - 1; j++) //Проверка существования записи в списке
                {
                    if(tables.dataGridView1.Rows[i].Cells[2].Value.ToString() == dataGridView1.Rows[j].Cells[0].Value.ToString())
                    {
                        control = false;
                        for (int n = 0; n < dataGridView1.Columns.Count; n++)
                            if (dataGridView1.Columns[n].Name == tables.dataGridView1.Rows[i].Cells[3].Value.ToString())
                                dTable.Rows[j].SetField(dTable.Columns[n], tables.dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                }
                if(control) //Добавление новой записи в список
                {
                    dTable.Rows.Add();
                    dTable.Rows[dTable.Rows.Count - 1].SetField(dTable.Columns[0], tables.dataGridView1.Rows[i].Cells[2].Value.ToString());
                    for (int n = 0; n < dataGridView1.Columns.Count; n++)
                        if (dataGridView1.Columns[n].Name == tables.dataGridView1.Rows[i].Cells[3].Value.ToString())
                            dTable.Rows[dTable.Rows.Count - 1].SetField(dTable.Columns[n], tables.dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            }
        }

    }
}
