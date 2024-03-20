using System.Runtime.CompilerServices;

namespace _22520853_Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Lab01_Ex1_Click(object sender, EventArgs e)
        {
            Ex1 bai01 = new Ex1();
            bai01.ShowDialog();
        }

        private void btn_Lab01_Ex2_Click(object sender, EventArgs e)
        {
            Ex2 bai02 = new Ex2();
            bai02.ShowDialog();
        }

        private void btn_Lab01_Ex03_Click(object sender, EventArgs e)
        {
            Ex3 bai03 = new Ex3();
            bai03.ShowDialog();
        }

        private void btn_Lab01_Ex3_1_Click(object sender, EventArgs e)
        {
            EX3_1 bai03_1 = new EX3_1();
            bai03_1.ShowDialog();
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lab01_Ex5_Click(object sender, EventArgs e)
        {
            Ex5 bai05 = new Ex5();
            bai05.ShowDialog();
        }

        private void btn_Lab01_Ex6_Click(object sender, EventArgs e)
        {
            Ex6 bai06 = new Ex6();
            bai06.ShowDialog();
        }

        private void btn_Lab01_Ex8_Click(object sender, EventArgs e)
        {
            Ex8 bai08 = new Ex8();
            bai08.ShowDialog();
        }

        private void btn_Lab01_Ex7_Click(object sender, EventArgs e)
        {
            Ex7 bai07 = new Ex7();
            bai07.ShowDialog();
        }
    }
}
