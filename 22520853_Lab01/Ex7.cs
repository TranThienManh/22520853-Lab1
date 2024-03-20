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
    // Coi lại code bài này  !!!

    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void Ex7_Load(object sender, EventArgs e)
        {
            btn_Cal.Click += Btn_Cal_Click;
            btn_Reset.Click += Btn_Reset_Click;
            btn_Exit.Click += Btn_Exit_Click;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            input.Clear();
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }

        private void Btn_Cal_Click(object sender, EventArgs e)
        {
            string inputText = input.Text.Trim();

            // Chia các chuỗi bằng dấu ","
            string[] data = inputText.Split(',');

            // Kiểm tra dữ liệu đầu vào
            if (data.Length < 12)
            {
                //MessageBox.Show("Invalid data format. Please enter data in the correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
                MessageBox.Show("Dữ liệu đầu vào không hợp lệ !");
                return;
            }

            // Lấy tên sv và danh sách điểm
            string name = data[0];
            double[] scores = data.Skip(1).Select(double.Parse).ToArray();

            // Hiển thị tên
            hoten.Text = name;

            // Hiển thị bảng điểm
            for (int i = 0; i < scores.Length; i++)
            {
                Controls.Find($"textBox{i + 2}", true)[0].Text = scores[i].ToString();
            }

            // tính điểm trung bình
            double average = scores.Average();
            diemtrungbinh.Text = average.ToString();

            // tính điểm max và điểm min
            double maxScore = scores.Max();
            double minScore = scores.Min();
            diem_max.Text = maxScore.ToString();
            diem_min.Text = minScore.ToString();

            // số môn pass và fall
            int passedCount = scores.Count(score => score >= 5);
            int failedCount = scores.Length - passedCount;
            somon_dau.Text = passedCount.ToString();
            somon_rot.Text = failedCount.ToString();

            // Xếp loại
            if (average >= 8 && scores.All(score => score >= 6.5))
            {
                xeploai.Text = "Giỏi";
            }
            else if (average >= 6.5 && scores.All(score => score >= 5))
            {
                xeploai.Text = "Khá";
            }
            else if (average >= 5 && scores.All(score => score >= 3.5))
            {
                xeploai.Text = "Trung bình";
            }
            else if (average >= 3.5 && scores.All(score => score >= 2))
            {
                xeploai.Text = "Yếu";
            }
            else
            {
                xeploai.Text = "Kém";
            }
        }
    }
}
