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
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        //Hàm kiểm tra nhập số nguyên
        private bool IsInterger(string input)
        {
            //Kí tự đầu tiên cho phép nhập dấu "-" để nhấp số âm
            if (input.StartsWith("-"))
            {
                input = input.Substring(1);
                //Substring(1) Tạo chuỗi con từ vị trí 1 đến hết bỏ vị trí 0 có dấu "-" 
            }
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
                /*
                 * Dùng foreach để duyệt lần lượt các phần tử trong array
                 * Dùng hàm IsDigit để kiểm tra lần lượt các kí tự trong mảng có phải là số nguyên hay không
                 * Nếu đúng hết thoát khỏi vòng lặp trả về true ngược lại false
                 */
            }
            return true;
        }

        private bool CheckTextBox(TextBox textbox)
        {
            
            if (!double.TryParse(textbox.Text.Trim(), out _ ))
            {
                MessageBox.Show("Pleased enter a valid number !");
                textbox.Text = "";
                return false;
            }
            return true;
        }

        /*
         * if (!double.TryParse(textBox.Text.Trim(), out _ )): Dòng này sử dụng double.TryParse 
         * để kiểm tra xem nội dung của TextBox có thể được chuyển đổi thành một số double không
         * .textBox.Text.Trim() được sử dụng để loại bỏ khoảng trắng ở đầu và cuối chuỗi trong TextBox.
         * Nếu chuyển đổi thành công, giá trị được trả về từ TryParse sẽ là true, ngược lại sẽ là false. 
         * Trong trường hợp này, dấu _ được sử dụng để bỏ qua giá trị trả về không cần thiết.
         */

        // Note bài 2 khác bài 1 cho phép nhập xong hết mới hiển thị thông báo điều kiện sau
        private void btn_Ex02_cal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("Chưa nhập dữ liệu !");
                /* Trả về ô TextBox rỗng để người dùng nhập dữ liệu
                   Dùng hàm focus để trả con trỏ về ô textbox rỗng */
                if (textBox1.Text == "")
                {
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    textBox2.Focus();
                    return;
                }
                if (textBox3.Text == "")
                {
                    textBox3.Focus();
                    return;
                }
            }    
            else if (CheckTextBox(textBox1) && CheckTextBox(textBox2) && CheckTextBox(textBox3))
            {
                double num1, num2, num3;
                num1 = double.Parse(textBox1.Text.Trim());
                num2 = double.Parse(textBox2.Text.Trim());
                num3 = double.Parse(textBox3.Text.Trim());
                double max = ((num1 > num2) && (num1 > num3)) ? num1 : (num2 > num3) ? num2 : num3;
                MaxBox.Text = max.ToString();
                double min = ((num1 < num2) && (num1 < num3)) ? num1 : (num2 < num3) ? num2 : num3;
                MinBox.Text = min.ToString();
            }    
        }

        private void btn_Ex02_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MaxBox.Text = "";
            MinBox.Text = "";
            
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btn_Ex02_Exit_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
        }
    }
}
