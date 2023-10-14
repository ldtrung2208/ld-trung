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
    public partial class AddNewRoom : Form
    {
        fouction fn = new fouction();
        string query;

        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(467, 131);
            labelRoomExist.Visible = false;

            query = "SELECT * FROM rooms";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms WHERE roomNo=" + txtRoomNo1.Text + "";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                string status;
                if (checkBox1.Checked)
                {
                    status = "Yes";
                } else
                {
                    status = "No";
                }
                labelRoomExist.Visible = false;
                query = "INSERT INTO rooms (roomNo, roomStatus) VALUES (" + txtRoomNo1.Text + ",'" + status + "')";
                fn.setData(query, "Đã thêm phòng.");
                AddNewRoom_Load(this, null);
            } else
            {
                labelRoomExist.Text = "Phòng đã có";
                labelRoomExist.Visible = true;
            }    
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms WHERE roomNo=" + txtRoomNo2.Text + "";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count ==0)
            {
                labelRoom.Text = "Phòng này không tồn tại!";
                labelRoom.Visible = true;
                checkBox2.Checked = false;
            } else
            {
                labelRoom.Text = "Phòng này đã tìm thấy";
                labelRoom.Visible = true;

                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    checkBox2.Checked = true;
                } else
                {
                    checkBox2.Visible = false;
                }
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status;
            if (checkBox2.Checked)
            {
                status = "Yes";
            } else
            {
                status = "No";
            }
            query = "UPDATE rooms SET roomStatus='" + status + "' WHERE roomNo =" + txtRoomNo2.Text + "";
            fn.setData(query, "Cập nhật chi tiết thành công!");
            AddNewRoom_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (labelRoom.Text == "Phòng này đã tìm thấy")
            {
                query = "DELETE FROM rooms WHERE roomNo =" + txtRoomNo2.Text + "";
                fn.setData(query, "Đã xoá chi tiết phòng!");
                AddNewRoom_Load(this, null);
            } else
            {
                MessageBox.Show("Thử xoá lại! Không thấy phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
    