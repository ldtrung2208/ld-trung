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
    public partial class AllStudentLiving : Form
    {
        fouction fn = new fouction();
        string query;
        public AllStudentLiving()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllStudentLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(467, 131);
            query = "SELECT * FROM newStudent WHERE living = 'Yes'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
