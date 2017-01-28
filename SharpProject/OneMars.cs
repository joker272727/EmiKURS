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
    //25. Дан массив целых чисел. Если в данной последовательности 
    //ни одно четное число не расположено после нечетного числа, то получить новый массив, 
    //включив в него все от-рицательные члены последовательности, иначе - все положительные. 
    //Порядок следова-ния чисел в первом случае не меняется, во втором  случае заменяется  
    //обратным поряд-ком.
    public partial class OneMars : Form
    {
        Int32[] Array, Array1;
        int size = 0;
        public OneMars()
        {
            InitializeComponent();
            Array = new Int32[100];
            Array1 = new Int32[100];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array[size] = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(Array[size]);
            size++;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int size1 = 0, usl = 0;
            if (size == 0)
            {
                MessageBox.Show("МАССИВ ПУСТ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    if (((Array[i] % 2) == 1) && (Array[i + 1] == 0))
                        usl = 1;
                if (usl == 0)
                    for (int i = 0; i < size; i++)
                    {
                        if (Array[i] < 0)
                        {
                            Array1[size1] = Array[i];
                            size1++;
                        }
                    }
                else
                    for (int i = size - 1; i >= 0; i--)
                    {
                        if (Array[i] > 0)
                        {
                            Array1[size1] = Array[i];
                            size1++;
                        }
                    }
                for (int i = 0; i < size1; i++)
                    listBox2.Items.Add(Array1[i]);
            }
        }
    }
}
