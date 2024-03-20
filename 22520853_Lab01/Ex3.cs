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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private bool CheckTextBox(TextBox textbox)
        {
            foreach (var t in textbox.Text.Trim())
            {
                if (!char.IsNumber(t))
                {
                    MessageBox.Show("Vui lòng nhập số từ 0->9 !");
                    textbox.Text = "";
                    return false;
                }
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox(textBox1);
        }

        private void btn_Ex3_Read_Click(object sender, EventArgs e)
        {
            /*
            int num;
            num = int.Parse(textBox1.Text.Trim());
            if (num == 0)
            {
                show_kq.Text = "Không";
            }
            else if (num == 1)
            {
                show_kq.Text = "Một";
            }
            else if (num == 2)
            {
                show_kq.Text = "Hai";
            }
            else if (num == 3)
            {
                show_kq.Text = "Ba";
            }
            else if (num == 4)
            {
                show_kq.Text = "Bốn";
            }
            else if (num == 5)
            {
                show_kq.Text = "Năm";
            }
            else if (num == 6)
            {
                show_kq.Text = "Sáu";
            }
            else if (num == 7)
            {
                show_kq.Text = "Bảy";
            }
            else if (num == 8)
            {
                show_kq.Text = "Tám";
            }
            else if (num == 9)
            {
                show_kq.Text = "Chín";
            }
            */

            // Cách 2
            switch (textBox1.Text.Trim())
            {
                case "1":
                    {
                        show_kq.Text = "Một";
                        break;
                    }
                case "2":
                    {
                        show_kq.Text = "Hai";
                        break;
                    }
                case "3":
                    {
                        show_kq.Text = "Ba";
                        break;
                    }
                case "4":
                    {
                        show_kq.Text = "Bốn";
                        break;
                    }
                case "5":
                    {
                        show_kq.Text = "Năm";
                        break;
                    }
                case "6":
                    {
                        show_kq.Text = "Sáu";
                        break;

                    }
                case "7":
                    {
                        show_kq.Text = "Bảy";
                        break;
                    }
                case "8":
                    {
                        show_kq.Text = "Tám";
                        break;
                    }
                case "9":
                    {
                        show_kq.Text = "Chín";
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Nhập số nguyên từ 0-9");
                        textBox1.Text = "";
                        break;

                    }

            }
        }

        private void btn_Ex03_Del_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btn_Ex3_Exit_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*
             1 GC.Collect();: Dòng này gọi phương thức Collect() của lớp GC 
             * (Garbage Collector). Garbage Collector là một phần của .NET Framework 
             * dùng để thu gom các đối tượng không còn sử dụng (garbage) để giải phóng
             * bộ nhớ. Tuy nhiên, việc gọi GC.Collect() thường không được khuyến khích 
             * vì nó có thể ảnh hưởng đến hiệu suất của ứng dụng. Việc sử dụng Garbage Collector 
             * là tự động và thông thường không cần phải can thiệp trực tiếp.
             
             2 GC.WaitForPendingFinalizers();: Dòng này chờ đợi cho đến khi tất cả các đối tượng cuối cùng
             * (finalizers) đang chờ được thực thi bởi Garbage Collector đã được thực thi xong.
             * Điều này đảm bảo rằng các đối tượng cuối cùng đã được dọn dẹp trước khi ứng dụng kết thúc. 
              
             3 this.Close();: Dòng này đóng cửa sổ hiện tại. this ở đây đề cập đến đối tượng Form
             * hiện tại, và Close() được gọi để đóng Form đó, làm kết thúc ứng dụng.
        */
    }
}


/*
 * private void btn_Ex3_Read_Click(object sender, EventArgs e)
        {
            Int64 test;
            if (Int64.TryParse(textBox1.Text, out test))
            {
                Int64 num = Int64.Parse(textBox1.Text.Trim());
                if (num < -999999999999 || num > 999999999999)
                {
                    MessageBox.Show("Gia tri khong hop le !");
                    return;
                }

                if (num == 0)
                {
                    show_kq.Text = "không";
                }
                if (num == 5)
                {
                    show_kq.Text = "năm";
                }
                if (num == -5)
                {
                    show_kq.Text = "âm năm";
                }

                string[] donVi = { " ", "một", "hai", "ba", "bốn", "lăm", "sáu", "bảy", "tám", "chín" };
                string[] hangChuc = { " ", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
                string[] hangTram = { " ", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
                string[] hangNghin = { "", "một nghìn", "hai nghìn", "ba nghìn", "bốn nghìn", "năm nghìn", "sáu nghìn", "bảy nghìn", "tám nghìn", "chín nghìn" };
                string[] hangTrieu = { "", "một triệu", "hai triệu", "ba triệu", "bốn triệu", "năm triệu", "sáu triệu", "bảy triệu", "tám triệu", "chín triệu" };
                string[] hangTy = { "", "một tỷ", "hai tỷ", "ba tỷ", "bốn tỷ", "năm tỷ", "sáu tỷ", "bảy tỷ", "tám tỷ", "chín tỷ" };

                string result = num < 0 ? "âm" : "";
                num = Math.Abs(num);

                Int64 ty = num / 1000000000;
                Int64 trieu = (num % 1000000000) / 1000000;
                Int64 nghin = (num % 1000000) / 1000;
                Int64 tram = (num % 1000) / 100;
                Int64 chuc = (num % 100) / 10;
                Int64 donvi = num % 10;

                if (ty > 0)
                {
                    result += hangTy[ty] + " ";
                    if (tram == 0 && chuc != 0)
                    {
                        result += "không trăm ";
                    }
                }

                if (trieu > 0)
                {
                    result += hangTrieu[trieu] + " ";
                    if (tram == 0 && chuc != 0)
                    {
                        result += "không trăm ";
                    }
                }

                if (nghin > 0)
                {
                    result += hangNghin[nghin] + " ";
                    if (tram == 0 && chuc != 0)
                    {
                        result += "không trăm ";
                    }
                }

                if (tram > 0)
                {
                    result += hangTram[tram] + " ";
                }

                if (chuc > 0)
                {
                    if (chuc == 1)
                    {
                        result += "mười ";
                    }
                    else
                    {
                        result += hangChuc[chuc] + " ";
                    }
                }

                if (donvi > 0)
                {
                    if (chuc == 0) result += "lẻ ";
                    if (chuc > 1 && donvi == 1)
                    {
                        result += "mốt ";
                    }
                    else if (chuc < 2 && donvi == 1)
                    {
                        result += "một ";
                    }
                    else if (chuc != 0 || donvi != 1)
                    {
                        if (donvi == 5) result += "năm ";
                        else result += donVi[donvi] + " ";
                    }
                }

                show_kq.Text = result;
            }

            else
            {
                MessageBox.Show("Vui long nhap gia tri hop le !");
            }
        }

        private void btn_Ex03_Del_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            show_kq.Clear();
        }

        private void btn_Ex3_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
*/