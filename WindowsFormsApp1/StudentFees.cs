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
    public partial class StudentFees : Form
    {
        fouction fn = new fouction();
        string query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(467, 131);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM yyyy";
        }

        public void setDataGrid(Int64 mobile)
        {
            query = "SELECT * FROM fees WHERE mobileNo =" + mobile + "";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        
        private void clearALL()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtAmount.Clear();
            txtRoomNo.Clear();
            txtEmailId.Clear();
            guna2DataGridView1.DataSource = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                query = "SELECT name, email, roomNo FROM newStudent WHERE mobile=" + txtMobile.Text + "";
                DataSet ds = fn.GetData(query);
                
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(Int64.Parse(txtMobile.Text));
                } else
                {
                    MessageBox.Show("Hồ sơ này không tồn tại!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtAmount.Text != "")
            {
                query = "SELECT * FROM fees WHERE mobileNo = " + Int64.Parse(txtMobile.Text) + " and fmonth= '" + dateTimePicker.Text + "'";
                DataSet ds = fn.GetData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    string month = dateTimePicker.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);

                    query = "INSERT INTO fees VALUES (" + mobile + ", '" + month + "', " + amount + ")";
                    fn.setData(query, "Phí đã trả");
                    clearALL();
                } else
                {
                    MessageBox.Show("Không có lệ phí của" + dateTimePicker.Text + "Còn lại.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }
    }
}
