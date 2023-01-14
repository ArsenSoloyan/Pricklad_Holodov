﻿using System;
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
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox6.Text);
            double c = Convert.ToDouble(textBox5.Text);
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
            }
            if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("Дискриминант равен нулю. Корень равен " + x + ".");
            }
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                MessageBox.Show("Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
            }
        }
    }
}
