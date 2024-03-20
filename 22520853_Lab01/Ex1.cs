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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }


        // Kiểm tra số nguyên - Phần quan trọng
        private bool IsInteger(string input)
        { 
            // Loại bỏ ký tự '-' nếu có
            if (input.StartsWith("-"))
            {
                input = input.Substring(1); // Loại bỏ ký tự '-' từ vị trí đầu tiên
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c)) // Kiểm tra xem ký tự có phải là số không
                    return false;
            }

            return true;
        }

        /*
         * 1.Xây dựng hàm CheckTextBox chuyền tham số hàm textBox là textbox
         * 2.Dùng Foreach để lặp qua từng phần tử chuổi nhập trong TextBox
         *   trong foreach có hai điểm đặc biệt 
         *      + Sử dụng kiểu dữ liệu var để tiên đoán kiểu dữ liệu không cần dúng chính sát kiểu dữ liêu cụ thể
         *      + Sử dụng hàm Trim() để xóa phần kí tự trắng hai đầu chuỗi
         * 3.Gọi lại hàm IsInterger ở trên để kiểm tra input của TextBox
         */

        private void CheckTexBox(TextBox textbox)
        {
            foreach (var t in textbox.Text.Trim())
            {
                if (!IsInteger(textbox.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên !");
                    textbox.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckTexBox(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckTexBox(textBox2);
        }

        private void btn_ex1_calc_Click_1(object sender, EventArgs e)
        {
            try
            {
                int num1, num2;
                num1 = int.Parse(textBox1.Text.Trim());
                num2 = int.Parse(textBox2.Text.Trim());
                textBox3.Text = (num1 + num2).ToString();
            }
            catch
            {
                MessageBox.Show(" Chưa có dữ liệu ");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
        }

        
    }
}
