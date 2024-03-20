using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace _22520853_Lab01
{
    public partial class EX3_1 : Form
    {
        public EX3_1()
        {
            InitializeComponent();
        }

        private void btn_Ex3_Read_Click(object sender, EventArgs e)
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

                string result = num < 0 ? "âm " : " ";
                num = Math.Abs(num);

                Int64 tramTy = num / 100000000000;
                Int64 chucTy = (num % 100000000000) / 10000000000;
                Int64 ty = (num % 10000000000) / 1000000000;
                Int64 tramTrieu = (num % 1000000000) / 100000000;
                Int64 chucTrieu = (num % 100000000) / 10000000;
                Int64 trieu = (num % 10000000) / 1000000;
                Int64 tramNghin = (num % 1000000) / 100000;
                Int64 chucNghin = (num % 100000) / 10000;
                Int64 nghin = (num % 10000) / 1000;
                Int64 tram = (num % 1000) / 100;
                Int64 chuc = (num % 100) / 10;
                Int64 donvi = num % 10;


                if (tramTy > 0)
                {
                    result += hangTram[tramTy] + "  "; 
                    if (chucTy == 0 && ty!=0)
                    {
                        result += "lẻ ";
                    }    
                }    

                if (chucTy > 0)
                {
                    if (chucTy == 1)
                    {
                        result += "mười ";
                    }
                    else result += hangChuc[chucTy] + " ";

                    if (tramTy==0)
                    {
                        result += "không trăm ";
                    }    
                }    

                if (ty > 0)
                {
                    result += donVi[ty] + " tỷ, ";
                    if (tramTrieu==0 && chucTrieu!=0)
                    {
                        result += "không trăm ";
                    }    
                }    

                if (tramTrieu > 0)
                {
                    if (tramTrieu == 0 && chucTrieu != 0)
                    {
                        result += "không trăm ";
                    }
                    else
                        result += hangTram[tramTrieu] + "  ";

                    if (chucTrieu == 0 && trieu!=0)
                    {
                        result += "lẻ ";
                    }    
                }    

                if (chucTrieu > 0)
                {
                    if (chucTrieu == 1)
                    {
                        result += "mười ";
                    }
                    else
                        result += hangChuc[chucTrieu] + " ";
                }    

                if (trieu > 0)
                {
                    result += donVi[trieu] + " triệu, ";
                    if (tramNghin==0 && chucNghin!=0)
                    {
                        result += "không trăm ";
                    }    
                }

                if (tramNghin > 0)
                {
                    result += hangTram[tramNghin] + " ";
                    if (chucNghin == 0 && nghin != 0)
                    {
                        result += "lẻ";
                    }
                }

                if (chucNghin > 0)
                {
                    if (chucNghin == 1)
                    {
                        result += "mười ";
                    }
                    else
                        result += hangChuc[chucNghin] + " ";

                    if (tramNghin == 0)
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
                        result += hangChuc[chuc] + " ";
                }    


                if (donvi > 0)
                {
                    if (chuc == 0) result += "lẻ "; 
                    if (chuc > 1 && donvi == 1)
                    {
                        result += " mốt ";
                    }
                    else if (chuc < 2 && donvi == 1)
                    {
                        result += "một ";
                    }
                    else if (chuc != 0 || donvi != 1)
                    {
                        if (donvi == 5) result += " năm ";
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
}
