using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;     
using System.Linq;

namespace Bai2_QuanLyNhanSu
{
    public partial class frmEmployeeManager : Form
    {
        private BindingList<EmployeeModel> _employeeList = new BindingList<EmployeeModel>();
        private string _currentAvatarPath = "";
        public frmEmployeeManager()
        {
            InitializeComponent();
            tmrClock_Tick(null, EventArgs.Empty);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentAvatarPath = openFileDialog1.FileName;
                picAvatar.ImageLocation = _currentAvatarPath;
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
        
            mnuAdd_Click(sender, e);
        }

        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = _employeeList;
            UpdateStatusStrip();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            var newEmp = new EmployeeModel
            {
                EmployeeId = txtEmployeeId.Text,
                FullName = txtFullName.Text,
                Salary = numSalary.Value,
                AvatarPath = _currentAvatarPath
            };
            _employeeList.Add(newEmp);
            UpdateStatusStrip();
        }

        private void mnuSaveCsv_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("EmployeeId,FullName,Salary,AvatarPath");
                    foreach (var emp in _employeeList)
                    {
                        sw.WriteLine($"{emp.EmployeeId},{emp.FullName},{emp.Salary},{emp.AvatarPath}");
                    }
                }
                MessageBox.Show("Lưu thành công!");
            }
        }

        private void mnuOpenCsv_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _employeeList.Clear();
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    if (data.Length >= 4)
                    {
                        _employeeList.Add(new EmployeeModel
                        {
                            EmployeeId = data[0],
                            FullName = data[1],
                            Salary = decimal.Parse(data[2]),
                            AvatarPath = data[3]
                        });
                    }
                }
                UpdateStatusStrip();
            }
        }
        private void UpdateStatusStrip()
        {
            lblTotalEmp.Text = $"Tổng NV: {_employeeList.Count}";
            lblTotalSalary.Text = $"Tổng Lương: {_employeeList.Sum(e => e.Salary):N0}";
        }
    }
}
