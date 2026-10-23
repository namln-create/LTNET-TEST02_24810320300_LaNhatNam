using System.Windows.Forms;
using System;

namespace Bai3_QuanLyTruongHoc
{
    public partial class frmSchoolMain : Form
    {
        public frmSchoolMain()
        {
            InitializeComponent();
        }

        private void frmSchoolMain_Load(object sender, EventArgs e)
        {

        }
        private bool CheckExistForm(string formName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == formName)
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        private void mnuClasses_Click_1(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmCourseList"))
            {
                frmCourseList frm = new frmCourseList();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuStudents_Click_1(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmStudentList"))
            {
                frmStudentList frm = new frmStudentList();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}