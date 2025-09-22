using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGrifindoToysPayroll
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.Show();
        }

        private void btnAttentdance_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmAttendance frmAttendance = new FrmAttendance();
            frmAttendance.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmSetting frmSetting = new FrmSetting();
            frmSetting.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmEmployeeSalary frmEmployeeSalary = new FrmEmployeeSalary();
            frmEmployeeSalary.Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmLeave frmLeave = new FrmLeave();
            frmLeave.Show();
        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmHoliday frmHoliday = new FrmHoliday();
            frmHoliday.Show();
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmInsuarance frmInsuarance = new FrmInsuarance();
            frmInsuarance.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmContactDetails frmContactDetails = new FrmContactDetails();
            frmContactDetails.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmEmployeeType frmEmployeeType = new FrmEmployeeType();
            frmEmployeeType.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmEmployeeInsurance frmEmployeeInsurance = new FrmEmployeeInsurance();
            frmEmployeeInsurance.Show();
        }

        private void btnLeaveAssign_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmLeaveAssign frmLeaveAssign = new FrmLeaveAssign();
            frmLeaveAssign.Show();
        }
    }
}
