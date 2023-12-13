using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class InputProfile : Form
    {
        public InputProfile()
        {
            InitializeComponent();
        }


        private void TurnOffTxtSecond()
        {
            txbTime.Enabled = false;
        }

        private void TurnOnTxtSecond()
        {
            txbTime.Enabled = true;
        }

        private void InputProfile_Load(object sender, EventArgs e)
        {
            rdbUnlimit.Checked = true;
            rdbNo2dau.Checked = true;
        }

        private void rdbUnlimit_CheckedChanged(object sender, EventArgs e)
        {
            TurnOffTxtSecond();
        }

        private void rdbLimit_CheckedChanged(object sender, EventArgs e)
        {
            TurnOnTxtSecond();
        }

        private bool checkTextBoxTime(string text)
        {
            if (!int.TryParse(text, out int number) || number <= 0)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbPlayerX.Text == string.Empty) txbPlayerX.Text = "Player_1";
            if (txbPlayerO.Text == string.Empty) txbPlayerO.Text = "Player_2";
            if (!rdbLimit.Checked && !rdbUnlimit.Checked)
                MessageBox.Show("Bạn chưa chọn chế độ !!!", "Error");
            else if (txbTime.Enabled == true && txbTime.Text == string.Empty)
                MessageBox.Show("Bạn chưa nhập thời gian !!!", "Error");
            else if (rdbLimit.Checked && !checkTextBoxTime(txbTime.Text))
                MessageBox.Show("Nhập không đúng định dạng !!!", "Error");
            else
            {
                if (rdbLimit.Checked)
                {
                    int sendTime = int.Parse(txbTime.Text);
                    Form1 f = new Form1(txbPlayerX.Text, txbPlayerO.Text, sendTime, rdbYes2dau.Checked);

                    f.Show();
                }
                else
                {
                    Form1 f = new Form1(txbPlayerX.Text, txbPlayerO.Text, 0, rdbYes2dau.Checked);
                    f.Show();
                }
                this.Hide();
            }
        }
    }
}
