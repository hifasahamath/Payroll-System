using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGrifindoToysPayroll
{
    public partial class FrmLeave : Form
    {
        public FrmLeave()
        {
            InitializeComponent();
        }

        ClassLeave classLeave = new ClassLeave();

        private void FrmLeave_Load(object sender, EventArgs e)
        {
            ClassCombobox.loadFK("SELECT * FROM Employee", comboBoxEmployeeID, "EmployeeID", "EmployeeID");


            classLeave.LeaveTable = dataGridViewLeave;
            classLeave.DisplayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || txtReason.Text == "" || dateTimePickerLeaveStartDate.Text == "" || dateTimePickerLeaveEndDate.Text == "" || txtTotalDays.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classLeave.EmployeeID = comboBoxEmployeeID.Text;
                classLeave.Reason = txtReason.Text;
                classLeave.StartDate = dateTimePickerLeaveStartDate.Value.ToString("yyyy-MM-dd");
                classLeave.EndDate = dateTimePickerLeaveEndDate.Value.ToString("yyyy-MM-dd");
                classLeave.TotalLeave = txtTotalDays.Text;
                classLeave.InsertDetails();
            }
        }

        private void dataGridViewLeave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLeaveID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewLeave.Rows[index];

            txtLeaveID.Text = selectedrow.Cells[0].Value.ToString();
            comboBoxEmployeeID.Text = selectedrow.Cells[1].Value.ToString();
            txtReason.Text = selectedrow.Cells[2].Value.ToString();
            dateTimePickerLeaveStartDate.Text = selectedrow.Cells[3].Value.ToString();
            dateTimePickerLeaveEndDate.Text = selectedrow.Cells[4].Value.ToString();
            txtTotalDays.Text = selectedrow.Cells[5].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeaveID.ReadOnly = false;
            txtLeaveID.Text = "";
            comboBoxEmployeeID.Text = "";
            txtReason.Text = "";
            dateTimePickerLeaveStartDate.Text = "";
            dateTimePickerLeaveEndDate.Text = "";
            txtTotalDays.Text = "";
            txtAvailableLeaves.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || txtReason.Text == "" || dateTimePickerLeaveStartDate.Text == "" || dateTimePickerLeaveEndDate.Text == "" || txtTotalDays.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classLeave.EmployeeID = comboBoxEmployeeID.Text;
                    classLeave.Reason = txtReason.Text;
                    classLeave.StartDate = dateTimePickerLeaveStartDate.Value.ToString("yyyy-MM-dd");
                    classLeave.EndDate = dateTimePickerLeaveEndDate.Value.ToString("yyyy-MM-dd");
                    classLeave.TotalLeave = txtTotalDays.Text;
                    classLeave.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || txtReason.Text == "" || dateTimePickerLeaveStartDate.Text == "" || dateTimePickerLeaveEndDate.Text == "" || txtTotalDays.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classLeave.EmployeeID = comboBoxEmployeeID.Text;
                    classLeave.Reason = txtReason.Text;
                    classLeave.StartDate = dateTimePickerLeaveStartDate.Value.ToString("yyyy-MM-dd");
                    classLeave.EndDate = dateTimePickerLeaveEndDate.Value.ToString("yyyy-MM-dd");
                    classLeave.TotalLeave = txtTotalDays.Text;
                    classLeave.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }






        //CalculateTotalLeaveDays
        private void CalculateTotalLeaveDays()
        {
            DateTime startDate = dateTimePickerLeaveStartDate.Value;
            DateTime endDate = dateTimePickerLeaveEndDate.Value;

            if (endDate >= startDate)
            {
                TimeSpan cycleRange = endDate - startDate;
                txtTotalDays.Text = cycleRange.Days.ToString();
            }
            else
            {
                txtTotalDays.Text = "Invalid Date Range";
            }
        }

        private void dateTimePickerLeaveStartDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalLeaveDays();
        }

        private void dateTimePickerLeaveEndDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalLeaveDays();

        }






        ///////////
        ///
        private void comboBoxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.SelectedValue != null && comboBoxEmployeeID.SelectedValue is int)
            {
                int selectedEmployeeID = (int)comboBoxEmployeeID.SelectedValue;
                int availableLeaves = GetAvailableLeaves(selectedEmployeeID);
                txtAvailableLeaves.Text = availableLeaves.ToString();
            }
            else
            {
                // Handle the case where SelectedValue is not an integer or is null
                txtAvailableLeaves.Text = "0"; // or some default value
            }
        }

        private int GetAvailableLeaves(int employeeID)
        {
            int availableLeaves = 0;
            using (SqlConnection conn = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True"))
            {
                string query = @"
            SELECT et.AnnualLeave
            FROM Employee e
            JOIN EmployeeType et ON e.EmployeeType = et.EmployeeType
            WHERE e.EmployeeID = @EmployeeID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    availableLeaves = Convert.ToInt32(result);
                }
            }
            return availableLeaves;
        }



    }
}
