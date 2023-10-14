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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Show();
            this.Close();
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            AddNewRoom arn = new AddNewRoom();
            arn.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent nst = new NewStudent();
            nst.Show();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            UpdateDelete uds = new UpdateDelete();  
            uds.Show();
        }

        private void BtnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees snf = new StudentFees();
            snf.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)
        {
            AllStudentLiving asl = new AllStudentLiving();
            asl.Show();
        }

        private void btnLeavedStudent_Click(object sender, EventArgs e)
        {
            LeavedStudent lsn = new LeavedStudent();
            lsn.Show();
        }
    }
}
