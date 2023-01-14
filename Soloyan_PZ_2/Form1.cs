using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_PZ_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int L = str.Length;
            int k = 0;
            for (int i = 0; i < L; i++)
                if (str[i] == ' ') k++;
            Data.Value = k.ToString();
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
