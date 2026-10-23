namespace Bai5_HeThongCanhBao
{
    partial class frmIoTMonitor
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
            grpControl = new GroupBox();
            btnStart = new Button();
            btnStop = new Button();
            grpTemperature = new GroupBox();
            lblTemperature = new Label();
            dgvLogs = new DataGridView();
            ssMain = new StatusStrip();
            lblConnection = new ToolStripStatusLabel();
            lblCycleCount = new ToolStripStatusLabel();
            grpControl.SuspendLayout();
            grpTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            ssMain.SuspendLayout();
            SuspendLayout();
            // 
            // grpControl
            // 
            grpControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpControl.Controls.Add(btnStart);
            grpControl.Controls.Add(btnStop);
            grpControl.Location = new Point(12, 12);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(736, 70);
            grpControl.TabIndex = 0;
            grpControl.TabStop = false;
            grpControl.Text = "Điều khiển";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(20, 24);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(180, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Bắt đầu Giám sát";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(220, 24);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(180, 34);
            btnStop.TabIndex = 1;
            btnStop.Text = "Dừng Giám sát";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // grpTemperature
            // 
            grpTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTemperature.Controls.Add(lblTemperature);
            grpTemperature.Location = new Point(12, 90);
            grpTemperature.Name = "grpTemperature";
            grpTemperature.Size = new Size(736, 120);
            grpTemperature.TabIndex = 1;
            grpTemperature.TabStop = false;
            grpTemperature.Text = "Nhiệt độ cảm biến";
            // 
            // lblTemperature
            // 
            lblTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTemperature.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTemperature.ForeColor = Color.SeaGreen;
            lblTemperature.Location = new Point(20, 30);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(696, 75);
            lblTemperature.TabIndex = 0;
            lblTemperature.Text = "--.- °C";
            lblTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AllowUserToResizeRows = false;
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = SystemColors.Window;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(12, 218);
            dgvLogs.MultiSelect = false;
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(736, 270);
            dgvLogs.TabIndex = 2;
            // 
            // ssMain
            // 
            ssMain.ImageScalingSize = new Size(20, 20);
            ssMain.Items.AddRange(new ToolStripItem[] { lblConnection, lblCycleCount });
            ssMain.Location = new Point(0, 490);
            ssMain.Name = "ssMain";
            ssMain.Size = new Size(760, 30);
            ssMain.TabIndex = 3;
            // 
            // lblConnection
            // 
            lblConnection.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(218, 24);
            lblConnection.Text = "Trạng thái kết nối: Chưa kết nối";
            // 
            // lblCycleCount
            // 
            lblCycleCount.Name = "lblCycleCount";
            lblCycleCount.Size = new Size(175, 24);
            lblCycleCount.Text = "Số chu kỳ nhận tín hiệu: 0";
            // 
            // frmIoTMonitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 520);
            Controls.Add(ssMain);
            Controls.Add(dgvLogs);
            Controls.Add(grpTemperature);
            Controls.Add(grpControl);
            MinimumSize = new Size(776, 559);
            Name = "frmIoTMonitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giám sát hệ thống cảnh báo IoT real-time";
            Load += frmIoTMonitor_Load;
            grpControl.ResumeLayout(false);
            grpTemperature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ssMain.ResumeLayout(false);
            ssMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;

        private System.Windows.Forms.GroupBox grpTemperature;
        private System.Windows.Forms.Label lblTemperature;

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblConnection;
        private System.Windows.Forms.ToolStripStatusLabel lblCycleCount;
    }
}
