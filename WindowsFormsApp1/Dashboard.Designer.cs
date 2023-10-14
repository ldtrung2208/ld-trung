namespace WindowsFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnManageRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDelete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnStudentFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllStudentLiving = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnExist = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(532, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHƯƠNG TRÌNH QUẢN LÝ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(450, 140);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1180, 830);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.BorderRadius = 15;
            this.btnManageRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageRoom.ForeColor = System.Drawing.Color.White;
            this.btnManageRoom.Location = new System.Drawing.Point(48, 131);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.Size = new System.Drawing.Size(314, 70);
            this.btnManageRoom.TabIndex = 3;
            this.btnManageRoom.Text = "Quản Lý Phòng";
            this.btnManageRoom.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.BorderRadius = 15;
            this.btnNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnNewStudent.Location = new System.Drawing.Point(48, 216);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(314, 70);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "Thêm Sinh Viên";
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnUpdateDelete
            // 
            this.btnUpdateDelete.BorderRadius = 15;
            this.btnUpdateDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDelete.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDelete.Location = new System.Drawing.Point(48, 301);
            this.btnUpdateDelete.Name = "btnUpdateDelete";
            this.btnUpdateDelete.Size = new System.Drawing.Size(314, 70);
            this.btnUpdateDelete.TabIndex = 5;
            this.btnUpdateDelete.Text = "Cập Nhật - Xoá Sinh Viên";
            this.btnUpdateDelete.Click += new System.EventHandler(this.btnUpdateDelete_Click);
            // 
            // BtnStudentFees
            // 
            this.BtnStudentFees.BorderRadius = 15;
            this.BtnStudentFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnStudentFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStudentFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnStudentFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStudentFees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnStudentFees.ForeColor = System.Drawing.Color.White;
            this.BtnStudentFees.Location = new System.Drawing.Point(48, 387);
            this.BtnStudentFees.Name = "BtnStudentFees";
            this.BtnStudentFees.Size = new System.Drawing.Size(314, 70);
            this.BtnStudentFees.TabIndex = 6;
            this.BtnStudentFees.Text = "Thanh Toán Phí Phòng";
            this.BtnStudentFees.Click += new System.EventHandler(this.BtnStudentFees_Click);
            // 
            // btnAllStudentLiving
            // 
            this.btnAllStudentLiving.BorderRadius = 15;
            this.btnAllStudentLiving.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllStudentLiving.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllStudentLiving.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllStudentLiving.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAllStudentLiving.ForeColor = System.Drawing.Color.White;
            this.btnAllStudentLiving.Location = new System.Drawing.Point(48, 473);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(314, 70);
            this.btnAllStudentLiving.TabIndex = 7;
            this.btnAllStudentLiving.Text = "Trạng Thái Phòng Sinh Viên";
            this.btnAllStudentLiving.Click += new System.EventHandler(this.btnAllStudentLiving_Click);
            // 
            // btnLeavedStudent
            // 
            this.btnLeavedStudent.BorderRadius = 15;
            this.btnLeavedStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavedStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavedStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLeavedStudent.ForeColor = System.Drawing.Color.White;
            this.btnLeavedStudent.Location = new System.Drawing.Point(48, 558);
            this.btnLeavedStudent.Name = "btnLeavedStudent";
            this.btnLeavedStudent.Size = new System.Drawing.Size(314, 70);
            this.btnLeavedStudent.TabIndex = 8;
            this.btnLeavedStudent.Text = "Sinh Viên Trả Phòng";
            this.btnLeavedStudent.Click += new System.EventHandler(this.btnLeavedStudent_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1157, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(206, 69);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExist
            // 
            this.btnExist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExist.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.White;
            this.btnExist.Image = ((System.Drawing.Image)(resources.GetObject("btnExist.Image")));
            this.btnExist.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExist.Location = new System.Drawing.Point(1477, 12);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(95, 65);
            this.btnExist.TabIndex = 10;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1656, 992);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLeavedStudent);
            this.Controls.Add(this.btnAllStudentLiving);
            this.Controls.Add(this.BtnStudentFees);
            this.Controls.Add(this.btnUpdateDelete);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnManageRoom);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "         ";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnManageRoom;
        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDelete;
        private Guna.UI2.WinForms.Guna2Button BtnStudentFees;
        private Guna.UI2.WinForms.Guna2Button btnAllStudentLiving;
        private Guna.UI2.WinForms.Guna2Button btnLeavedStudent;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnExist;
    }
}