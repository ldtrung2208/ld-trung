using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewStudent : Form
    {
        fouction fn = new fouction();
        string query;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(467, 131);
            query = "SELECT roomNO  FROM  rooms WHERE roomStatus = 'Yes' AND Booked = 'No'";

            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
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
            comboRoomNo.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" &&  txtName.Text != "" &&  txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermanent.Text != "" && txtCollege.Text != "" && txtIdProof.Text != "" && comboRoomNo.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string name = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string email = txtEmail.Text;
                string paddress = txtPermanent.Text;
                string college = txtCollege.Text;
                string idProof = txtIdProof.Text;
                Int64 roomNo = Int64.Parse(comboRoomNo.Text);


                query = "INSERT INTO newStudent(mobile, name, fname, mname, email, paddress, college, idproof, roomNo) VALUES (" + mobile + ", '" + name + "', '" + fname + "', '" + mname + "', '" + email + "', '" + paddress + "', '" + college + "', '" + idProof + "', " + roomNo + ") UPDATE rooms SET Booked = 'Yes' WHERE roomNo = " + roomNo + "";
                fn.setData(query, "Sinh viên đăng kí thành công.");
                
                clearALL();
            } else
            {
                MessageBox.Show("Vui lòng đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }
    }
}
