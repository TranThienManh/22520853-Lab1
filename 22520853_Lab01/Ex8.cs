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
    public partial class Ex8 : Form
    {
        public Ex8()
        {
            InitializeComponent();
        }

        private void FoodList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int cnt = 0;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input.Text))
                return;
            FoodList.Items.Add(input.Text);
            cnt++;
            input.Clear();
            input.Focus();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (FoodList.Items.Count > 0)
                FoodList.Items.RemoveAt(FoodList.SelectedIndex);
            cnt--;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            for (int i = 0; i <= cnt; i++)
            {
                int num = rdm.Next(0, cnt);
            }
            int sc = FoodList.Items.Count;
            int scy = rdm.Next(sc);
            output.Text = FoodList.Items[scy].ToString();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            input.Clear();
            output.Clear();
            FoodList.Items.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
