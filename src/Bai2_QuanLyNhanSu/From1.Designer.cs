namespace Bai2_QuanLyNhanSu
{
    partial class frmEmployeeManager
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
            components = new System.ComponentModel.Container();
            msMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuOpenCsv = new ToolStripMenuItem();
            mnuSaveCsv = new ToolStripMenuItem();
            tssFile = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuActions = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            mnuSearch = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbAdd = new ToolStripButton();
            ssMain = new StatusStrip();
            lblTotalEmp = new ToolStripStatusLabel();
            lblTotalSalary = new ToolStripStatusLabel();
            lblSpacer = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            grpDetail = new GroupBox();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            lblEmployeeId = new Label();
            txtEmployeeId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPosition = new Label();
            txtPosition = new TextBox();
            lblDepartment = new Label();
            txtDepartment = new TextBox();
            lblSalary = new Label();
            dgvEmployees = new DataGridView();
            tmrClock = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            numSalary = new NumericUpDown();
            msMain.SuspendLayout();
            tsMain.SuspendLayout();
            ssMain.SuspendLayout();
            grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuActions });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(900, 28);
            msMain.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenCsv, mnuSaveCsv, tssFile, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuOpenCsv
            // 
            mnuOpenCsv.Name = "mnuOpenCsv";
            mnuOpenCsv.Size = new Size(171, 26);
            mnuOpenCsv.Text = "Mở file CSV";
            mnuOpenCsv.Click += mnuOpenCsv_Click;
            // 
            // mnuSaveCsv
            // 
            mnuSaveCsv.Name = "mnuSaveCsv";
            mnuSaveCsv.Size = new Size(171, 26);
            mnuSaveCsv.Text = "Lưu file CSV";
            mnuSaveCsv.Click += mnuSaveCsv_Click;
            // 
            // tssFile
            // 
            tssFile.Name = "tssFile";
            tssFile.Size = new Size(168, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(171, 26);
            mnuExit.Text = "Thoát";
            // 
            // mnuActions
            // 
            mnuActions.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuDelete, mnuSearch });
            mnuActions.Name = "mnuActions";
            mnuActions.Size = new Size(63, 24);
            mnuActions.Text = "Tác vụ";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(153, 26);
            mnuAdd.Text = "Thêm";
            mnuAdd.Click += mnuAdd_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(153, 26);
            mnuDelete.Text = "Xóa";
            // 
            // mnuSearch
            // 
            mnuSearch.Name = "mnuSearch";
            mnuSearch.Size = new Size(153, 26);
            mnuSearch.Text = "Tìm kiếm";
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(24, 24);
            tsMain.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tsbAdd });
            tsMain.Location = new Point(0, 28);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(900, 27);
            tsMain.TabIndex = 1;
            // 
            // tsbOpen
            // 
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(60, 24);
            tsbOpen.Text = "Mở file";
            tsbOpen.ToolTipText = "Mở file CSV";
            // 
            // tsbSave
            // 
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(62, 24);
            tsbSave.Text = "Lưu file";
            tsbSave.ToolTipText = "Lưu file CSV";
            // 
            // tsbAdd
            // 
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(80, 24);
            tsbAdd.Text = "Thêm mới";
            tsbAdd.ToolTipText = "Thêm nhân viên mới";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // ssMain
            // 
            ssMain.ImageScalingSize = new Size(20, 20);
            ssMain.Items.AddRange(new ToolStripItem[] { lblTotalEmp, lblTotalSalary, lblSpacer, lblClock });
            ssMain.Location = new Point(0, 590);
            ssMain.Name = "ssMain";
            ssMain.Size = new Size(900, 30);
            ssMain.TabIndex = 3;
            // 
            // lblTotalEmp
            // 
            lblTotalEmp.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblTotalEmp.Name = "lblTotalEmp";
            lblTotalEmp.Size = new Size(148, 24);
            lblTotalEmp.Text = "Tổng số nhân viên: 0";
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(133, 24);
            lblTotalSalary.Text = "Tổng quỹ lương: 0";
            // 
            // lblSpacer
            // 
            lblSpacer.Name = "lblSpacer";
            lblSpacer.Size = new Size(420, 24);
            lblSpacer.Spring = true;
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(184, 24);
            lblClock.Text = "Thời gian: --/--/---- --:--:--";
            // 
            // grpDetail
            // 
            grpDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDetail.Controls.Add(numSalary);
            grpDetail.Controls.Add(picAvatar);
            grpDetail.Controls.Add(btnChooseImage);
            grpDetail.Controls.Add(lblEmployeeId);
            grpDetail.Controls.Add(txtEmployeeId);
            grpDetail.Controls.Add(lblFullName);
            grpDetail.Controls.Add(txtFullName);
            grpDetail.Controls.Add(lblPosition);
            grpDetail.Controls.Add(txtPosition);
            grpDetail.Controls.Add(lblDepartment);
            grpDetail.Controls.Add(txtDepartment);
            grpDetail.Controls.Add(lblSalary);
            grpDetail.Location = new Point(12, 67);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new Size(876, 260);
            grpDetail.TabIndex = 2;
            grpDetail.TabStop = false;
            grpDetail.Text = "Thông tin nhân viên";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = SystemColors.ControlLight;
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(20, 28);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(150, 190);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(20, 222);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(150, 32);
            btnChooseImage.TabIndex = 1;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(200, 43);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(100, 20);
            lblEmployeeId.TabIndex = 2;
            lblEmployeeId.Text = "Mã nhân viên:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(300, 40);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(230, 27);
            txtEmployeeId.TabIndex = 2;
            txtEmployeeId.TextChanged += txtEmployeeId_TextChanged;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(200, 103);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Họ và tên:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(300, 100);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(230, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(200, 163);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(64, 20);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Chức vụ:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(300, 160);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(230, 27);
            txtPosition.TabIndex = 4;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(560, 43);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(83, 20);
            lblDepartment.TabIndex = 5;
            lblDepartment.Text = "Phòng ban:";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(660, 40);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(190, 27);
            txtDepartment.TabIndex = 5;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(560, 103);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(103, 20);
            lblSalary.TabIndex = 6;
            lblSalary.Text = "Lương cơ bản:";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = SystemColors.Window;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 335);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(876, 251);
            dgvEmployees.TabIndex = 7;
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // numSalary
            // 
            numSalary.Location = new Point(660, 100);
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(190, 27);
            numSalary.TabIndex = 7;
            // 
            // frmEmployeeManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 620);
            Controls.Add(dgvEmployees);
            Controls.Add(grpDetail);
            Controls.Add(ssMain);
            Controls.Add(tsMain);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            MinimumSize = new Size(916, 659);
            Name = "frmEmployeeManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hồ sơ nhân sự & thông tin lương";
            Load += frmEmployeeManager_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ssMain.ResumeLayout(false);
            ssMain.PerformLayout();
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenCsv;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveCsv;
        private System.Windows.Forms.ToolStripSeparator tssFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuActions;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbAdd;

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalEmp;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalSalary;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
        private System.Windows.Forms.ToolStripStatusLabel lblClock;

        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblSalary;

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvatarPath;

        private System.Windows.Forms.Timer tmrClock;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private NumericUpDown numSalary;
    }
}
