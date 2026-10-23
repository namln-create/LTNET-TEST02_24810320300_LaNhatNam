using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Bai5_HeThongCanhBao
{
    public partial class frmIoTMonitor : Form
    {
        private CancellationTokenSource _iotCts;
        public frmIoTMonitor()
        {
            InitializeComponent();

            if (dgvLogs.Columns.Count == 0)
            {
                dgvLogs.Columns.Add("colIndex", "STT");
                dgvLogs.Columns.Add("colTime", "Thời gian");
                dgvLogs.Columns.Add("colTemperature", "Nhiệt độ (°C)");
                dgvLogs.Columns.Add("colStatus", "Trạng thái");
            }
        }

        private void frmIoTMonitor_Load(object sender, EventArgs e)
        {

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            _iotCts = new CancellationTokenSource();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblConnection.Text = "Trạng thái kết nối: Đang thu thập dữ liệu...";

            try
            {
                await Task.Run(() => MonitorSystem(_iotCts.Token));
            }
            catch (OperationCanceledException)
            {
                lblConnection.Text = "Trạng thái kết nối: Đã ngắt kết nối";
                lblTemperature.Text = "--.- °C";
                lblTemperature.ForeColor = Color.SeaGreen;
            }
            finally
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_iotCts != null)
            {
                _iotCts.Cancel(); 
            }
        }

        private void MonitorSystem(CancellationToken token)
        {
            Random rnd = new Random();
            int cycleCount = 0;

            while (true)             {
                token.ThrowIfCancellationRequested();

                double temp = rnd.NextDouble() * (42.0 - 35.0) + 35.0;
                cycleCount++;

                UpdateUISafe(temp, cycleCount);

                Thread.Sleep(2000);
            }
        }

        private void UpdateUISafe(double temp, int count)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateUISafe(temp, count)));
            }
            else
            {
                lblTemperature.Text = $"{temp:F1} °C";

                string status = "Bình thường";
                if (temp > 38.5)
                {
                    lblTemperature.ForeColor = Color.Red;
                    status = "CẢNH BÁO CAO";
                }
                else
                {
                    lblTemperature.ForeColor = Color.SeaGreen;
                }

                lblCycleCount.Text = $"Số chu kỳ nhận tín hiệu: {count}";

                dgvLogs.Rows.Insert(0, count, DateTime.Now.ToString("HH:mm:ss"), temp, status);
            }
        }
    }
   
}
