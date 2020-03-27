using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace laborator.net
{
    public partial class Calculator : Form
    {
        double FirstNumber=0;
        string Operation="";
        bool negative = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            string c = e.KeyChar.ToString();
            if (Regex.IsMatch(c, @"\d"))
            {
                if (!textBox1.Focused)
                {
                    textBox1.Text += c;
                }
                //MessageBox.Show(c.ToString());
            }
            else if (c == "+")
            {
                badd_Click(sender,e);
                e.Handled = true;
            }
            else if (c == "-")
            {
                bsub_Click(sender, e);
                e.Handled = true;
            }
            else if (c == "*")
            {
                bmul_Click(sender, e);
                e.Handled = true;
            }
            else if (c == "/")
            {
                bdiv_Click(sender, e);
                e.Handled = true;
            }
            else if (c == "=")
            {
                eq_Click(sender, e);
                e.Handled = true;
            }
            else if (c == "c")
            {
                clear_Click(sender, e);
                e.Handled = true;
            }
            else if (c == ".")
            {
                deci_Click(sender, e);
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }


        private void n1_Click(object sender, EventArgs e)
        {
            insertTextVal("1");
        }
        private void n2_Click(object sender, EventArgs e)
        {
            insertTextVal("2");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            insertTextVal("3");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            insertTextVal("4");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            insertTextVal("5");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            insertTextVal("6");
        }

        private void n7_Click(object sender, EventArgs e)
        {
            insertTextVal("7");
        }
        private void n8_Click(object sender, EventArgs e)
        {
            insertTextVal("8");
        }
        private void n9_Click(object sender, EventArgs e)
        {
            insertTextVal("9");
        }

        private void n0_Click(object sender, EventArgs e)
        {
            insertTextVal("0");
        }

        private void deci_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == @"-")
            {
                textBox1.Text += @"0.";
                return;
            }
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            textBox1.Text += @".";
        }

        private void clear_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            FirstNumber = 0;
            negative = false;
            value_label.Text = "";
            Operation = "";
        }

        private void eq_Click(object sender, EventArgs e)
        {
                double SecondNumber;
                double Result;
                
                SecondNumber = Convert.ToDouble(textBox1.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    value_label.Text = textBox1.Text;
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    value_label.Text = textBox1.Text;
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    value_label.Text = textBox1.Text;
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        MessageBox.Show("You may not divide by 0;");

                    }
                else
                    {
                        Result = (double)(FirstNumber / SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        value_label.Text = textBox1.Text;
                        FirstNumber = Result;
                    }
                }
                
        }

        private void badd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            value_label.Text = textBox1.Text;
            textBox1.Text = "";
            Operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {
                return;
            }
            if (textBox1.Text == "" || textBox1.Text =="0" || textBox1.Text==".")
            {
                textBox1.Text = "-";
                negative = true;
                return;

            }

            FirstNumber = Convert.ToDouble(textBox1.Text);
            value_label.Text = textBox1.Text;
            textBox1.Text = "";
            negative = false;
            Operation = "-";
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            value_label.Text = textBox1.Text;
            textBox1.Text = "";
            Operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            value_label.Text = textBox1.Text;

            textBox1.Text = "";
            Operation = "/";
        }

        private void insertTextVal(string val)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = val;
            }
            else
            {
                textBox1.Text = textBox1.Text + val;
            }

        }

    }
}
