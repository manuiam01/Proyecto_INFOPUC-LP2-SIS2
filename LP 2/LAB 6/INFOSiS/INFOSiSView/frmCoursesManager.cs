using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiSView
{
    public partial class frmCoursesManager : Form
    {
        public frmCoursesManager()
        {
            InitializeComponent();
            dgvCourses.Rows.Add("SQL","101","Curso sobre BD");
            dgvCourses.Rows.Add("Excel Básico", "102", "Curso sobre excel básico");
        }

        public void enable_Report(bool flag)
        {
            btnReport.Enabled = flag;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmCourseReport courseReport = new frmCourseReport();
                courseReport.ShowDialog();
            }
        }
    }
}
