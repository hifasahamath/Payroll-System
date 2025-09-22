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
    public partial class FrmLeaveAssign : Form
    {
        public FrmLeaveAssign()
        {
            InitializeComponent();
        }

        ClassLeaveAssign classLeaveAssign = new ClassLeaveAssign();

        private void FrmLeaveAssign_Load(object sender, EventArgs e)
        {
            ClassCombobox.loadFK("SELECT * FROM Employee", comboBoxEmployeeID, "EmployeeID", "EmployeeID");


            classLeaveAssign.LeaveAssignTable = dataGridViewLeaveAssign;
            classLeaveAssign.DisplayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || txtAnnualLeave.Text == "" || txtCasualLeave.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classLeaveAssign.EmployeeID = comboBoxEmployeeID.Text;
                classLeaveAssign.NoOfAnnualLeave = txtAnnualLeave.Text;
                classLeaveAssign.NoOfCasualLeave = txtCasualLeave.Text;
                classLeaveAssign.InsertDetails();
            }
        }

        private void dataGridViewLeaveAssign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLeaveAssignID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewLeaveAssign.Rows[index];

            txtLeaveAssignID.Text = selectedrow.Cells[0].Value.ToString();
            comboBoxEmployeeID.Text = selectedrow.Cells[1].Value.ToString();
            txtAnnualLeave.Text = selectedrow.Cells[2].Value.ToString();
            txtCasualLeave.Text = selectedrow.Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeaveAssignID.ReadOnly = false;
            txtLeaveAssignID.Text = "";
            comboBoxEmployeeID.Text = "";
            txtAnnualLeave.Text = "";
            txtCasualLeave.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || txtAnnualLeave.Text == "" || txtCasualLeave.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classLeaveAssign.EmployeeID = comboBoxEmployeeID.Text;
                    classLeaveAssign.NoOfAnnualLeave = txtAnnualLeave.Text;
                    classLeaveAssign.NoOfCasualLeave = txtCasualLeave.Text;
                    classLeaveAssign.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || txtAnnualLeave.Text == "" || txtCasualLeave.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classLeaveAssign.EmployeeID = comboBoxEmployeeID.Text;
                    classLeaveAssign.NoOfAnnualLeave = txtAnnualLeave.Text;
                    classLeaveAssign.NoOfCasualLeave = txtCasualLeave.Text;
                    classLeaveAssign.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }
    }
}
