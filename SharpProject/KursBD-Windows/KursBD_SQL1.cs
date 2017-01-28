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
    public partial class KursBD_SQL1 : Form
    {
        private OleDbConnection connect;
        private KursBD_tables tables;

        public KursBD_SQL1() //SQL
        {
            InitializeComponent();
            connect = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;Data Source=|DataDirectory|\KURSBASA.mdb;Persist Security Info=True");
        }

        public KursBD_SQL1(ref KursBD_tables tables_source) //Программирование
        {
            tables = tables_source;
            InitializeComponent();
        }

        private void KursBD_SQL1_Load(object sender, EventArgs e)
        {
           
        }

        public void SQL()
        {
            OleDbCommand ol = new OleDbCommand("SELECT Таблица1.НазваниеЦеха, Max(Таблица2.ЦенаЕдиницыОборудования) AS [Max-ЦенаЕдиницыОборудования] FROM Таблица2 INNER JOIN Таблица1 ON Таблица2.ТипОборудования = Таблица1.ТипОборудования GROUP BY Таблица1.НазваниеЦеха;", connect);
            connect.Open();
            ol.CommandType = CommandType.Text;
            //Инициализирует новый экземпляр класса OleDbDataAdapter с помощью указанной команды OleDbCommand в качестве свойства SelectCommand.
            OleDbDataAdapter data = new OleDbDataAdapter(ol);
            DataTable table = new DataTable();
            //Добавляет или обновляет строки в указанном диапазоне в объект DataSet для получения соответствия строкам в источнике данных с использованием имени DataTable. (Унаследовано от DbDataAdapter.)
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void PROG()
        {
            DataTable dTable = new DataTable();
            Int32 kol1 = tables.dataGridView1.Rows.Count - 1;
            Int32 kol2 = tables.dataGridView2.Rows.Count - 1;
            dataGridView1.DataSource = dTable;
            dTable.Columns.Add("НазваниеЦеха");
            dTable.Columns.Add("Max-Цена");
            for(int i = 0; i < kol1; i++) //Проход по таблице1
            {
                bool control = false;
                for(int j = 0; j < dTable.Rows.Count - 1; j++ ) //Проверка существования цеха в списке
                {
                    if(tables.dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.Rows[j].Cells[0].Value.ToString())
                    {
                        control = true;
                        for(int k = 0; k < kol2; k++) //Проход по таблице2
                        {
                            if ((tables.dataGridView1.Rows[i].Cells[3].Value.ToString() == tables.dataGridView2.Rows[k].Cells[0].Value.ToString())
                                && (int.Parse(tables.dataGridView2.Rows[k].Cells[1].Value.ToString()) > int.Parse(dataGridView1.Rows[j].Cells[1].Value.ToString())))
                                dTable.Rows[j].SetField(dTable.Columns[1], tables.dataGridView2.Rows[k].Cells[1].Value.ToString());
                        }
                        
                    }
                }
                if(!control) //Добавление несуществующего в списке цеха
                {
                    dTable.Rows.Add();
                    dTable.Rows[dTable.Rows.Count - 1].SetField(dTable.Columns[0], tables.dataGridView1.Rows[i].Cells[0].Value.ToString());
                    dTable.Rows[dTable.Rows.Count - 1].SetField(dTable.Columns[1], 0);
                    for (int m = 0; m < kol2; m++)
                        if (tables.dataGridView1.Rows[i].Cells[3].Value.ToString() == tables.dataGridView2.Rows[m].Cells[0].Value.ToString())
                            dTable.Rows[dTable.Rows.Count - 1].SetField(dTable.Columns[1], tables.dataGridView2.Rows[m].Cells[1].Value.ToString());
                }
            }
        }
    }
}
