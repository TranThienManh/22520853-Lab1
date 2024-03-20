using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab01
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }



        private void btn_Reset_Click(object sender, EventArgs e)
        {
            input_a.Clear();
            input_b.Clear();
            output_a.Clear();
            output_b.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            // Parse input values
            int a = int.Parse(input_a.Text.Trim());
            int b = int.Parse(input_b.Text.Trim());

            // Clear previous outputs
            output_a.Clear();
            output_b.Clear();

            // Check if selected state is "Bảng cửu chương"
            if (cbo_state.SelectedItem.ToString() == "Bảng cửu chương ")
            {
                // In ra bảng cửu chương của a
                for (int i = 1; i <= 10; i++)
                {
                    string str = a + " x " + i + " = " + (a * i) + "\r\n";
                    output_a.Text += str;
                }

                // In ra bảng cửu chương của b
                for (int i = 1; i <= 10; i++)
                {
                    string str = b + " x " + i + " = " + (b * i) + "\r\n";
                    output_b.Text += str;
                }
            }

            if (cbo_state.SelectedItem.ToString() == "Tính toán giá trị")
            {
                //1. tính giai thừa 
                int c = a - b;
                if (c < 0)
                { 
                    output_gt.Text = "-" + giaithua(Math.Abs(c)).ToString();
                }
                else
                    output_gt.Text = giaithua(c).ToString();

                //2. tính tổng A^1+A^2+...A^B
                int luythua = 1, sum = 0;
                for (int i=1; i<=b; i++)
                {
                    luythua *= a;
                    sum += luythua;
                }
                output_sum.Text = sum.ToString();

            }    
        }

        private int giaithua(int a)
        {
            if (a == 0 || a == 1) return a = 1;
            return a * giaithua(a - 1);
        }

    }
}

