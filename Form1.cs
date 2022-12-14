using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace activity4CAlAshape
{
    public partial class Form1 : Form
    {
        float num1, answer;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 1;
               
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + 0;
        }

        /*private void butX_Click(object sender, EventArgs e)
        {
            txtenter.Text = txtenter.Text + ;
        }*/

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            
                int c = txtenter.TextLength;
                int flag = 0;
                string text = txtenter.Text;
                for (int i = 0; i < c; i++)
                {
                    if (text[i].ToString() == ".")
                    {
                        flag = 1; break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                if (flag == 0)
                {
                    txtenter.Text = txtenter.Text + ".";
                }
            }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (txtenter.Text != "")
            {
                num1 = float.Parse(txtenter.Text);
                txtenter.Clear();
                txtenter.Focus();
                count = 1;
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtenter.Text);
            txtenter.Clear();
            txtenter.Focus();
            count = 3;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtenter.Text);
            txtenter.Clear();
            txtenter.Focus();
            count = 4;
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtenter.Text);
            txtenter.Clear();
            txtenter.Focus();
            count = 5;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtenter.Text);
            txtenter.Clear();
            txtenter.Focus();
            count = 2;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtenter.Clear();
            count = 0;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtenter.Cut();
            count= 0;
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    answer = num1 - float.Parse(txtenter.Text);
                    txtenter.Text = answer.ToString();
                    break;
                case 2:
                    answer = num1 + float.Parse(txtenter.Text);
                    txtenter.Text = answer.ToString();
                    break;
                case 3:
                    answer= num1 * float.Parse(txtenter.Text);
                    txtenter.Text = answer.ToString();
                    break;
                case 4:
                    answer = num1 / float.Parse(txtenter.Text);
                    txtenter.Text = answer.ToString();
                    break;
                case 5:
                    answer = num1 / float.Parse(txtenter.Text);
                    txtenter.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
