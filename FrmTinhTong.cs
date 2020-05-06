using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_part1_BTVN
{
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

        

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Ban chua nhap a");
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Ban chua nhap b");
                txtB.Focus();
                return;
            }

            int a = Convert.ToInt16(txtA.Text);
            int b = Convert.ToInt16(txtB.Text);
            int tong = 0;

            for (int i=a; i<=b; i++)
            {
                tong = ((a + b) * (b - a + 1) / 2);
            }
            lbTong.Text = tong.ToString();


        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtA.ReadOnly = false;
            txtB.Text = "";
            txtB.ReadOnly = false;
            lbTong.Text = "";
            btnTong.Enabled = true;
            txtA.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
            System.Windows.Forms.DialogResult.Yes)
            Application.Exit();
        }
    }
}
