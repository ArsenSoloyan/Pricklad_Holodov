using System;
using System.Windows.Forms;

namespace Soloyan_PZ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox4.Text);
            double d = Convert.ToDouble(textBox6.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double y = Convert.ToDouble(textBox7.Text);
            double F = Math.Sqrt(Math.Abs(d * 2)) * x + Math.Sqrt(Math.Abs(Math.Pow(b, 3)) - Math.Abs(Math.Pow(x, 2) + Math.Cos(y)));
            MessageBox.Show("Ответ " + F);
        }
    }
}
