namespace Bai3_QuanLyTruongHoc
{
    partial class frmSchoolMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            msMain = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuChangePassword = new ToolStripMenuItem();
            tssSystem = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuManage = new ToolStripMenuItem();
            mnuStudents = new ToolStripMenuItem();
            mnuTeachers = new ToolStripMenuItem();
            mnuClasses = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuArrange = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuCloseAll = new ToolStripMenuItem();
            ssMain = new StatusStrip();
            lblManager = new ToolStripStatusLabel();
            lblSpacer = new ToolStripStatusLabel();
            tspbProgress = new ToolStripProgressBar();
            msMain.SuspendLayout();
            ssMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuManage, mnuWindow });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1000, 28);
            msMain.TabIndex = 0;
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuChangePassword, tssSystem, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(85, 24);
            mnuSystem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(181, 26);
            mnuLogout.Text = "Đăng xuất";
            // 
            // mnuChangePassword
            // 
            mnuChangePassword.Name = "mnuChangePassword";
            mnuChangePassword.Size = new Size(181, 26);
            mnuChangePassword.Text = "Đổi mật khẩu";
            // 
            // tssSystem
            // 
            tssSystem.Name = "tssSystem";
            tssSystem.Size = new Size(178, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(181, 26);
            mnuExit.Text = "Thoát";
            // 
            // mnuManage
            // 
            mnuManage.DropDownItems.AddRange(new ToolStripItem[] { mnuStudents, mnuTeachers, mnuClasses });
            mnuManage.Name = "mnuManage";
            mnuManage.Size = new Size(73, 24);
            mnuManage.Text = "Quản lý";
            // 
            // mnuStudents
            // 
            mnuStudents.Name = "mnuStudents";
            mnuStudents.Size = new Size(234, 26);
            mnuStudents.Text = "Danh sách Sinh viên";
            mnuStudents.Click += mnuStudents_Click_1;
            // 
            // mnuTeachers
            // 
            mnuTeachers.Name = "mnuTeachers";
            mnuTeachers.Size = new Size(234, 26);
            mnuTeachers.Text = "Danh sách Giảng viên";
            // 
            // mnuClasses
            // 
            mnuClasses.Name = "mnuClasses";
            mnuClasses.Size = new Size(234, 26);
            mnuClasses.Text = "Danh mục Lớp học";
            mnuClasses.Click += mnuClasses_Click_1;
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuArrange, mnuCloseAll });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(68, 24);
            mnuWindow.Text = "Cửa sổ";
            // 
            // mnuArrange
            // 
            mnuArrange.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical });
            mnuArrange.Name = "mnuArrange";
            mnuArrange.Size = new Size(170, 26);
            mnuArrange.Text = "Sắp xếp";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(249, 26);
            mnuCascade.Text = "Xếp tầng (Cascade)";
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(249, 26);
            mnuTileHorizontal.Text = "Ngang (Tile Horizontal)";
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(249, 26);
            mnuTileVertical.Text = "Dọc (Tile Vertical)";
            // 
            // mnuCloseAll
            // 
            mnuCloseAll.Name = "mnuCloseAll";
            mnuCloseAll.Size = new Size(170, 26);
            mnuCloseAll.Text = "Đóng tất cả";
            // 
            // ssMain
            // 
            ssMain.ImageScalingSize = new Size(20, 20);
            ssMain.Items.AddRange(new ToolStripItem[] { lblManager, lblSpacer, tspbProgress });
            ssMain.Location = new Point(0, 624);
            ssMain.Name = "ssMain";
            ssMain.Size = new Size(1000, 26);
            ssMain.TabIndex = 1;
            // 
            // lblManager
            // 
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(159, 20);
            lblManager.Text = "Cán bộ quản lý: Admin";
            // 
            // lblSpacer
            // 
            lblSpacer.Name = "lblSpacer";
            lblSpacer.Size = new Size(644, 20);
            lblSpacer.Spring = true;
            // 
            // tspbProgress
            // 
            tspbProgress.Name = "tspbProgress";
            tspbProgress.Size = new Size(180, 18);
            // 
            // frmSchoolMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(ssMain);
            Controls.Add(msMain);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            Name = "frmSchoolMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý trường học & đào tạo";
            Load += frmSchoolMain_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ssMain.ResumeLayout(false);
            ssMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripSeparator tssSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuTeachers;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuArrange;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAll;

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblManager;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
    }
}
