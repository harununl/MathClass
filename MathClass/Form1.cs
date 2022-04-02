using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double firsNumber = 0, secondNumber = 0;
        bool control = false;
        void set1Parameter(string text)
        {
            if(text.Trim()!="")
            {
                control = true;
                firsNumber = Convert.ToDouble(text);
            }
        }
        void set2Parameter(string text, string text2)
        {
            if(text.Trim()!="" && text2.Trim()!="")  
            {
                control = true;
                firsNumber = Convert.ToDouble(text);
                secondNumber = Convert.ToDouble(text2);

            }
            else
                control = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firsNumber = 0;
            secondNumber = 0;
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Min(Convert.ToDecimal(firsNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
    
        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled  = true;

            }
            if((e.KeyChar == '-') && (sender as TextBox).Text.IndexOf('-')>-1)
            {
                e.Handled=true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondNumber_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '-') && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }


        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Max(Convert.ToDecimal(firsNumber), Convert.ToDecimal(secondNumber)).ToString();
            }

        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
           
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Abs(Convert.ToDecimal(firsNumber)).ToString();
               
            }


        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Sign(Convert.ToDecimal(firsNumber)).ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                double temp = (firsNumber * (Math.PI) / 180); 
                txtResult.Text = Math.Sin(temp).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                double temp = (firsNumber * (Math.PI) / 180);
                txtResult.Text = Math.Cos(temp).ToString();
            }

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                double temp = (firsNumber * (Math.PI) / 180);
                txtResult.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Pow(Convert.ToDouble(txtFirstNumber.Text),Convert.ToDouble(txtSecondNumber.Text)).ToString();  
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Sqrt(firsNumber).ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text,txtSecondNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Log(Convert.ToDouble(txtFirstNumber.Text), Convert.ToDouble(txtSecondNumber.Text)).ToString();
            }

        }

        private void btnLog1_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Log10(firsNumber).ToString();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtResult.Text = Math.Exp(firsNumber).ToString();
            }

        }

        private void btnCopyFirst_Click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            txtFirstNumber.Text = txtResult.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
