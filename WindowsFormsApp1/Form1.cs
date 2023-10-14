using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Xác thực tên đăng nhập và mật khẩu cố định
            if (txtUsername.Text == "admin" && txtPassword.Text == "666666")
            {
                MessageBox.Show("Đăng nhập thành công!");
                Dashboard dbs = new Dashboard();
                dbs.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
