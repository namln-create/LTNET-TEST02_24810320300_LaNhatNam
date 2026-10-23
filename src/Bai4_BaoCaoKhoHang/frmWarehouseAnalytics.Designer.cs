
namespace Bai4_QuanLyKhoHang
{
    partial class frmWarehouseAnalytics
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
            grpCriteria = new GroupBox();
            lblWarehouse = new Label();
            cboWarehouse = new ComboBox();
            lblDateRange = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnAnalyze = new Button();
            btnCancel = new Button();
            grpStatus = new GroupBox();
            pgbStatus = new ProgressBar();
            lblPercent = new Label();
            dgvReportData = new DataGridView();
            grpCriteria.SuspendLayout();
            grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
            SuspendLayout();
            // 
            // grpCriteria
            // 
            grpCriteria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpCriteria.Controls.Add(lblWarehouse);
            grpCriteria.Controls.Add(cboWarehouse);
            grpCriteria.Controls.Add(lblDateRange);
            grpCriteria.Controls.Add(dtpFrom);
            grpCriteria.Controls.Add(lblTo);
            grpCriteria.Controls.Add(dtpTo);
            grpCriteria.Controls.Add(btnAnalyze);
            grpCriteria.Controls.Add(btnCancel);
            grpCriteria.Location = new Point(12, 12);
            grpCriteria.Name = "grpCriteria";
            grpCriteria.Size = new Size(876, 115);
            grpCriteria.TabIndex = 0;
            grpCriteria.TabStop = false;
            grpCriteria.Text = "Tiêu chí thống kê";
            // 
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Location = new Point(20, 33);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(75, 20);
            lblWarehouse.TabIndex = 0;
            lblWarehouse.Text = "Kho hàng:";
            // 
            // cboWarehouse
            // 
            cboWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWarehouse.FormattingEnabled = true;
            cboWarehouse.Items.AddRange(new object[] { "Kho Hà Nội", "Kho Đà Nẵng", "Kho TP. Hồ Chí Minh" });
            cboWarehouse.Location = new Point(130, 30);
            cboWarehouse.Name = "cboWarehouse";
            cboWarehouse.Size = new Size(200, 28);
            cboWarehouse.TabIndex = 0;
            // 
            // lblDateRange
            // 
            lblDateRange.AutoSize = true;
            lblDateRange.Location = new Point(370, 33);
            lblDateRange.Name = "lblDateRange";
            lblDateRange.Size = new Size(126, 20);
            lblDateRange.TabIndex = 1;
            lblDateRange.Text = "Khoảng thời gian:";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(500, 30);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(140, 27);
            dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(652, 33);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(34, 20);
            lblTo.TabIndex = 2;
            lblTo.Text = "đến";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(690, 30);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(140, 27);
            dtpTo.TabIndex = 2;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(130, 68);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(160, 34);
            btnAnalyze.TabIndex = 3;
            btnAnalyze.Text = "Thống Kê Kho";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(310, 68);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy Tác Vụ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpStatus
            // 
            grpStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpStatus.Controls.Add(pgbStatus);
            grpStatus.Controls.Add(lblPercent);
            grpStatus.Location = new Point(12, 135);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(876, 65);
            grpStatus.TabIndex = 1;
            grpStatus.TabStop = false;
            grpStatus.Text = "Trạng thái";
            // 
            // pgbStatus
            // 
            pgbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgbStatus.Location = new Point(20, 28);
            pgbStatus.Name = "pgbStatus";
            pgbStatus.Size = new Size(740, 25);
            pgbStatus.TabIndex = 0;
            // 
            // lblPercent
            // 
            lblPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(780, 31);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(29, 20);
            lblPercent.TabIndex = 1;
            lblPercent.Text = "0%";
            // 
            // dgvReportData
            // 
            dgvReportData.AllowUserToAddRows = false;
            dgvReportData.AllowUserToDeleteRows = false;
            dgvReportData.AllowUserToResizeRows = false;
            dgvReportData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.BackgroundColor = SystemColors.Window;
            dgvReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportData.Location = new Point(12, 210);
            dgvReportData.MultiSelect = false;
            dgvReportData.Name = "dgvReportData";
            dgvReportData.ReadOnly = true;
            dgvReportData.RowHeadersVisible = false;
            dgvReportData.RowHeadersWidth = 51;
            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.Size = new Size(876, 338);
            dgvReportData.TabIndex = 2;
            // 
            // frmWarehouseAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(dgvReportData);
            Controls.Add(grpStatus);
            Controls.Add(grpCriteria);
            MinimumSize = new Size(916, 599);
            Name = "frmWarehouseAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển tổng hợp báo cáo kho hàng";
            grpCriteria.ResumeLayout(false);
            grpCriteria.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.ProgressBar pgbStatus;
        private System.Windows.Forms.Label lblPercent;

        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalValue;
    }
}
