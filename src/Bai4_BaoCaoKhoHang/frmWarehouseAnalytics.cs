using System.Windows.Forms;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bai4_QuanLyKhoHang
{
    public partial class frmWarehouseAnalytics : Form
    {
        private CancellationTokenSource _cts;
        public frmWarehouseAnalytics()
        {
            InitializeComponent();
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();

            pgbStatus.Value = 0;
            lblPercent.Text = "0%";
            btnAnalyze.Enabled = false;

            try
            {
                await Task.Run(() => ProcessDataAsync(_cts.Token));

                MessageBox.Show("Thống kê dữ liệu hoàn tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Tiến trình đã bị người dùng hủy.", "Đã hủy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pgbStatus.Value = 0;
                lblPercent.Text = "Đã hủy";
            }
            finally
            {
                btnAnalyze.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_cts != null)
            {
                _cts.Cancel();
            }
        }
        private void ProcessDataAsync(CancellationToken token)
        {
            for (int i = 1; i <= 100; i++)
            {
                token.ThrowIfCancellationRequested();

                Thread.Sleep(50); 

                this.Invoke(new Action(() =>
                {
                    pgbStatus.Value = i;
                    lblPercent.Text = $"{i}%";
                }));
            }
        }
    }
}