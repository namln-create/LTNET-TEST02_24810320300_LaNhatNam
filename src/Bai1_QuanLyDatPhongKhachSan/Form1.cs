using System.ComponentModel;

namespace Bai1_QuanLyDatPhongKhachSan
{
    public partial class frmBookingManager : Form
    {
        private BindingList<BookingModel> _bookingList;
        private BindingSource _bindingSource;
        private int _autoIdCounter = 1;
        public frmBookingManager()
        {
            InitializeComponent();
        }

        private void frmBookingManager_Load(object sender, EventArgs e)
        {
            _bookingList = new BindingList<BookingModel>();
            _bindingSource = new BindingSource { DataSource = _bookingList };


            InitializeGrid();


            dgvBookings.DataSource = _bindingSource;


            if (cboRoomType.Items.Count > 0)
                cboRoomType.SelectedIndex = 0;

            GenerateNewBookingId();
        }
        private void InitializeGrid()
        {
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.Columns.Clear();

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã Đặt", DataPropertyName = "BookingId" });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên Khách", DataPropertyName = "CustomerName", Width = 150 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CCCD/CMND", DataPropertyName = "IdentityCard", Width = 120 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại Phòng", DataPropertyName = "RoomType" });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày Nhận", DataPropertyName = "CheckInDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số Đêm", DataPropertyName = "NumberOfDays" });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá/Đêm", DataPropertyName = "PricePerNight", DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        }

        private void GenerateNewBookingId()
        {
            txtBookingId.Text = $"BK{_autoIdCounter:D3}";
        }
        private bool ValidateInput()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống.");
                isValid = false;
            }

            string idCard = txtIdentityCard.Text.Trim();
            if ((idCard.Length != 9 && idCard.Length != 12) || !idCard.All(char.IsDigit))
            {
                errorProvider1.SetError(txtIdentityCard, "CCCD/CMND phải là chuỗi gồm 9 hoặc 12 chữ số.");
                isValid = false;
            }

            if (!decimal.TryParse(txtPricePerNight.Text, out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtPricePerNight, "Giá phòng phải là một số lớn hơn 0.");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var newBooking = new BookingModel
            {
                BookingId = txtBookingId.Text,
                CustomerName = txtCustomerName.Text.Trim(),
                IdentityCard = txtIdentityCard.Text.Trim(),
                RoomType = cboRoomType.SelectedItem.ToString(),
                CheckInDate = dtpCheckIn.Value,
                NumberOfDays = (int)numDays.Value,
                PricePerNight = decimal.Parse(txtPricePerNight.Text)
            };

            _bookingList.Add(newBooking);
            _autoIdCounter++;
            btnClear_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null) return;
            if (!ValidateInput()) return;

            var currentBooking = (BookingModel)_bindingSource.Current;
            currentBooking.CustomerName = txtCustomerName.Text.Trim();
            currentBooking.IdentityCard = txtIdentityCard.Text.Trim();
            currentBooking.RoomType = cboRoomType.SelectedItem.ToString();
            currentBooking.CheckInDate = dtpCheckIn.Value;
            currentBooking.NumberOfDays = (int)numDays.Value;
            currentBooking.PricePerNight = decimal.Parse(txtPricePerNight.Text);

            _bindingSource.ResetCurrentItem();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null) return;

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đặt phòng này?",
                                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                _bindingSource.RemoveCurrent();
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GenerateNewBookingId();
            txtCustomerName.Clear();
            txtIdentityCard.Clear();
            cboRoomType.SelectedIndex = 0;
            dtpCheckIn.Value = DateTime.Now;
            numDays.Value = 1;
            txtPricePerNight.Clear();
            errorProvider1.Clear();
            dgvBookings.ClearSelection();
        }

        private void dgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow != null && dgvBookings.CurrentRow.DataBoundItem != null)
            {
                var selectedBooking = (BookingModel)dgvBookings.CurrentRow.DataBoundItem;
                txtBookingId.Text = selectedBooking.BookingId;
                txtCustomerName.Text = selectedBooking.CustomerName;
                txtIdentityCard.Text = selectedBooking.IdentityCard;
                cboRoomType.SelectedItem = selectedBooking.RoomType;
                dtpCheckIn.Value = selectedBooking.CheckInDate;
                numDays.Value = selectedBooking.NumberOfDays;
                txtPricePerNight.Text = selectedBooking.PricePerNight.ToString("G0");
                errorProvider1.Clear();
            }
        }
    }
}