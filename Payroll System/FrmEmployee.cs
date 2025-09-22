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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        ClassEmployee classEmployee = new ClassEmployee();


        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            ClassCombobox.loadFK("SELECT * FROM EmployeeType", comboBoxEmployeeType, "EmployeeType", "EmployeeType");


            ControlBox = false;

            classEmployee.EmployeeTable = dataGridViewEmployee;
            classEmployee.DisplayDetails();
        }

        private void dataGridViewEmployeeType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewEmployee.Rows[index];

            txtEmployeeID.Text = selectedrow.Cells[0].Value.ToString();
            txtFullName.Text = selectedrow.Cells[1].Value.ToString();
            txtNIC.Text = selectedrow.Cells[2].Value.ToString();
            dateTimePickerEmployee.Text = selectedrow.Cells[3].Value.ToString();
            txtMonthlySalary.Text = selectedrow.Cells[4].Value.ToString();
            txtAllowance.Text = selectedrow.Cells[5].Value.ToString();
            comboBoxEmployeeType.Text = selectedrow.Cells[6].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtNIC.Text == "" || dateTimePickerEmployee.Text == "" || txtMonthlySalary.Text == "" || txtAllowance.Text == "" || comboBoxEmployeeType.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classEmployee.EmployeeID = txtEmployeeID.Text;
                classEmployee.FullName = txtFullName.Text;
                classEmployee.NIC = txtNIC.Text;
                classEmployee.JoinDate = dateTimePickerEmployee.Value.ToString("yyyy-MM-dd");
                classEmployee.MonthlySalary = txtMonthlySalary.Text;
                classEmployee.Allowance = txtAllowance.Text;
                classEmployee.EmployeeType = comboBoxEmployeeType.Text;
                classEmployee.InsertDetails();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeID.ReadOnly = false;
            txtEmployeeID.Text = "";
            txtFullName.Text = "";
            txtNIC.Text = "";
            dateTimePickerEmployee.Text = "";
            txtMonthlySalary.Text = "";
            txtAllowance.Text = "";
            comboBoxEmployeeType.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtNIC.Text == "" || dateTimePickerEmployee.Text == "" || txtMonthlySalary.Text == "" || txtAllowance.Text == "" || comboBoxEmployeeType.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classEmployee.EmployeeID = txtEmployeeID.Text;
                    classEmployee.FullName = txtFullName.Text;
                    classEmployee.NIC = txtNIC.Text;
                    classEmployee.JoinDate = dateTimePickerEmployee.Value.ToString("yyyy-MM-dd");
                    classEmployee.MonthlySalary = txtMonthlySalary.Text;
                    classEmployee.Allowance = txtAllowance.Text;
                    classEmployee.EmployeeType = comboBoxEmployeeType.Text;
                    classEmployee.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtNIC.Text == "" || dateTimePickerEmployee.Text == "" || txtMonthlySalary.Text == "" || txtAllowance.Text == "" || comboBoxEmployeeType.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classEmployee.EmployeeID = txtEmployeeID.Text;
                    classEmployee.FullName = txtFullName.Text;
                    classEmployee.NIC = txtNIC.Text;
                    classEmployee.JoinDate = dateTimePickerEmployee.Value.ToString("yyyy-MM-dd");
                    classEmployee.MonthlySalary = txtMonthlySalary.Text;
                    classEmployee.Allowance = txtAllowance.Text;
                    classEmployee.EmployeeType = comboBoxEmployeeType.Text;
                    classEmployee.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }

        private void comboBoxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
