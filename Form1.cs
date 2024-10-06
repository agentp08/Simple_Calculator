//using System.Drawing.Text;
//using System.Security.Cryptography.Xml;
using System;

namespace SimpCal_again
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private double a = 0, b = 0;

        private void inp()
        {
            //input a
            try
            {
                a = double.Parse(txt_a.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bruh I hope ya know what a number is. Please type again.", "Error Message", MessageBoxButtons.OK);
                txt_a.Focus();
            }

            //input b
            try
            {
                b = double.Parse(txt_b.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bruh I hope ya know what a number is. Please type again.", "Error Message", MessageBoxButtons.OK);
                txt_b.Focus();
            }

        }

        private void cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            inp();

            double c = a + b;
            txt_c.Text = c.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            inp();

            double c = a - b;
            txt_c.Text = c.ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            inp();

            double c = a * b;
            txt_c.Text = c.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            inp();

            double c = a / b;
            txt_c.Text = c.ToString();
        }

        private void pow_Click(object sender, EventArgs e)
        {
            inp();
            double c = a * a;
            double d = b * b;

            txt_c.Text = c.ToString() + " and " + d.ToString() + ", respectively.";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            inp();

            double c = -1;
            double d = -1;
            if(a >= 0) c = Math.Sqrt(a);
            if (b >= 0) d = Math.Sqrt(b);

            if(c == -1)
            {
                txt_c.Text = "Doesn't exist" + " and " + d.ToString() + ", respectively.";
            }
            else if(d == -1)
            {
                txt_c.Text = c.ToString() + " and " + "doesn't exist" + ", respectively.";
            }
            else
            {
                txt_c.Text = c.ToString() + " and " + d.ToString() + ", respectively.";
            }
        }

        //check legit inp
        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9), one decimal point (.), and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                e.Handled = true;  // This prevents invalid characters from being typed
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;  // This prevents typing a second decimal point
            }

            // Allow negative sign, but only as the first character
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9), one decimal point (.), and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                e.Handled = true;  // This prevents invalid characters from being typed
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;  // This prevents typing a second decimal point
            }

            // Allow negative sign, but only as the first character
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        
    }
}
