using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soloyan_laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            textBox1.Text = (e.X, e.Y).ToString();
            double b = Convert.ToDouble(textBox2.Text);
            double d = Convert.ToDouble(textBox3.Text);
            double F;
            if (e.X > 0 && e.Y > 0 && d > 0 && b > 0)
            {
                F = Math.Round(Math.Sqrt(Math.Abs(d * 2)) * e.X + Math.Sqrt(Math.Abs(Math.Pow(b, 3)) - Math.Abs(Math.Pow(e.X, 2) + Math.Cos(e.Y))), 2);
                label4.Text = F.ToString();
            }
        }
    }
}
