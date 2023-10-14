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
    public partial class UpdateDelete : Form
    {
        fouction fn = new fouction();
        string query;

        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            this.Location = new Point(467, 131);
        }

        private void clearALL()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            txtIdProof.Clear();
            txtRoomNo.Clear();
            comboxLiving.SelectedIndex = -1;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM newStudent WHERE mobile =" + txtMobile.Text + "";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtCollege.Text = ds.Tables[0].Rows[0][7].ToString();
                txtIdProof.Text = ds.Tables[0].Rows[0][8].ToString();
                txtRoomNo.Text = ds.Tables[0].Rows[0][9].ToString();
                comboxLiving.Text = ds.Tables[0].Rows[0][10].ToString();
            } else
            {
                clearALL();
                MessageBox.Show("Số điện thoại này không tồn tại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string name = txtName.Text;
            string fname = txtFather.Text;
            string mname = txtMother.Text;
            string email = txtEmail.Text;
            string paddress = txtPermanent.Text;
            string college = txtCollege.Text;
            string idProof = txtIdProof.Text;
            Int64 roomNo = Int64.Parse(txtRoomNo.Text);
            string livingStatus = comboxLiving.Text;


            query = " UPDATE newStudent SET name= '" + name + "', fname= '" + fname + "', mname= '" + mname + "', email= '" + email + "', paddress= '" + paddress + "', college= '" + college + "', roomNo= '" + roomNo + "', living= '" + livingStatus + "' WHERE mobile = " + mobile + " UPDATE rooms SET Booked = '" + livingStatus + "' WHERE roomNo = " + roomNo + "";
            fn.setData(query, "Cập nhật dữ liệu thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM newStudent WHERE mobile = " + txtMobile.Text + "";
                fn.setData(query, "Đã xoá hồ sơ sinh viên");
                clearALL();
            }

        }
    }
}
