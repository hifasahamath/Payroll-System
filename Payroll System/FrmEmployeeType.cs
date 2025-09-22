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
    public partial class FrmEmployeeType : Form
    {
        public FrmEmployeeType()
        {
            InitializeComponent();
        }

        ClassEmployeeType classEmployeeType = new ClassEmployeeType();


        private void EmployeeType_Load(object sender, EventArgs e)
        {

            ControlBox = false;

            classEmployeeType.EmployeeTypeTable = dataGridViewEmployeeType;
            classEmployeeType.DisplayDetails();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtEmployeeType.Text == "" || txtOvertimeRatePerHour.Text == "" || txtAnnualLeave.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classEmployeeType.EmployeeTypeID = txtEmployeeTypeID.Text;
                classEmployeeType.EmployeeType = txtEmployeeType.Text;
                classEmployeeType.OvertimeRatePerHour = txtOvertimeRatePerHour.Text;
                classEmployeeType.AnnualLeave = txtAnnualLeave.Text;
                classEmployeeType.InsertDetails();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeTypeID.ReadOnly = false;
            txtEmployeeTypeID.Text = "";
            txtEmployeeType.Text = "";
            txtOvertimeRatePerHour.Text = "";
            txtAnnualLeave.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmployeeType.Text == "" || txtOvertimeRatePerHour.Text == "" || txtAnnualLeave.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classEmployeeType.EmployeeTypeID = txtEmployeeTypeID.Text;
                    classEmployeeType.EmployeeType = txtEmployeeType.Text;
                    classEmployeeType.OvertimeRatePerHour = txtOvertimeRatePerHour.Text;
                    classEmployeeType.AnnualLeave = txtAnnualLeave.Text;
                    classEmployeeType.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmployeeType.Text == "" || txtOvertimeRatePerHour.Text == "" || txtAnnualLeave.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classEmployeeType.EmployeeTypeID = txtEmployeeTypeID.Text;
                    classEmployeeType.EmployeeType = txtEmployeeType.Text;
                    classEmployeeType.OvertimeRatePerHour = txtOvertimeRatePerHour.Text;
                    classEmployeeType.AnnualLeave = txtAnnualLeave.Text;
                    classEmployeeType.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }
    }
}
