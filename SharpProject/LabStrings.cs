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
    public partial class LabStrings : Form
    {
        public LabStrings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private bool IsZifr(Char s)
        {
            if ((s >= '0') && (s <= '9'))
                return true;
            return false;
        }

        private void poiskPstr(String str, Int32 str_len, ref Int32 i, out Int32 len)
        {
            len = 0;
            for ( ; (i < str_len) && (IsZifr(str[i]) == false); i++) ;
            if (i == str_len)
                i = -1;
            else
                for( ; ((i + len) < str_len) && (IsZifr(str[i + len]) == true); len++);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            textBox3.Text = "";
            String source = textBox1.Text;
            String pstr = textBox2.Text;
            String[] str = source.Split();
            Int32 pstr_len = pstr.Length, kol = 0, kol1 = 0, ii = 0, len = 0;

            foreach(String s in str)
            {
                kol1++;
                if (s.Trim() != "")
                    kol++;
            }
            listBox2.Items.Add(kol);

            for(int i = 0; i < kol1; i++)
            {
                for (ii = 0; ii != -1; )
                {
                    poiskPstr(str[i], str[i].Length, ref ii, out len);
                    if ((len < pstr_len) && (ii != -1))
                    {
                        str[i] = str[i].Remove(ii, len);
                        str[i] = str[i].Insert(ii, pstr);
                        len = pstr_len;
                    }
                    ii += len;
                }

            }
            for (int i = 0; i < str.Length; i++)
            {
                textBox3.Text += str[i] + ' ';
            }
            listBox3.Items.Add(str[0]);
            listBox4.Items.Add(str[str.Length - 1]);
        }
    }
}
