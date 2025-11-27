using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identifing_prime_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(textBox1.Text, out n))
            {
               label1.Text=("لطفاً یک عدد صحیح وارد کنید!");
                return;
            }
            if (n == 1)
            {
                label1.Text = "عدد 1 نه اول است و نه مرکب.";
                return;
            }
            if (IsPrime(n))
            {
                label1.Text = " عدد  " + n + " یک عدد اول است";
                listBox1.Items.Add(n);
            }
            else
                label1.Text = " عدد " + n + " یک عدد مرکب است";
        }
        private bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
