using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab01
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void btn_Ex5_find_Click(object sender, EventArgs e)
        {
            // Giả sử người dùng nhập theo định dạng "dd/MM/yyyy"
            string[] dateParts = input.Text.Split('/');
            if (dateParts.Length != 3)
            {
                MessageBox.Show("Vui lòng nhập ngày tháng năm sinh theo định dạng dd/MM/yyyy.", "Lỗi định dạng");
                return;
            }

            int ngay, thang, nam;
            if (!int.TryParse(dateParts[0], out ngay) ||
                !int.TryParse(dateParts[1], out thang) ||
                !int.TryParse(dateParts[2], out nam))
            {
                MessageBox.Show("Ngày tháng năm sinh không hợp lệ. Vui lòng nhập lại.", "Lỗi nhập liệu");
                return;
            }

            // Xác định cung hoàng đạo
            string cungHoangDao = XacDinhCungHoangDao(ngay, thang);

            // Hiển thị thông tin
            output.Text = cungHoangDao;
        }

        private string XacDinhCungHoangDao(int ngay, int thang)
        {
            string cungHoangDao = "";

            switch (thang)
            {
                case 1:
                    cungHoangDao = ngay <= 20 ? "Ma Kết" : "Bảo Bình";
                    break;
                case 2:
                    cungHoangDao = ngay <= 19 ? "Bảo Bình" : "Song Ngư";
                    break;
                case 3:
                    cungHoangDao = ngay <= 20 ? "Song Ngư" : "Bạch Dương";
                    break;
                case 4:
                    cungHoangDao = ngay <= 20 ? "Bạch Dương" : "Kim Ngưu";
                    break;
                case 5:
                    cungHoangDao = ngay <= 21 ? "Kim Ngưu" : "Song Tử";
                    break;
                case 6:
                    cungHoangDao = ngay <= 21 ? "Song Tử" : "Cự Giải";
                    break;
                case 7:
                    cungHoangDao = ngay <= 22 ? "Cự Giải" : "Sư Tử";
                    break;
                case 8:
                    cungHoangDao = ngay <= 22 ? "Sư Tử" : "Xử Nữ";
                    break;
                case 9:
                    cungHoangDao = ngay <= 23 ? "Xử Nữ" : "Thiên Bình";
                    break;
                case 10:
                    cungHoangDao = ngay <= 23 ? "Thiên Bình" : "Thần Nông";
                    break;
                case 11:
                    cungHoangDao = ngay <= 22 ? "Thần Nông" : "Nhân Mã";
                    break;
                case 12:
                    cungHoangDao = ngay <= 21 ? "Nhân Mã" : "Ma Kết";
                    break;
            }

            return cungHoangDao;
        }

        private void btn_Ex5_Reset_Click(object sender, EventArgs e)
        {
            input.Clear();
            output.Clear();
        }

        private void btn_Ex5_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
