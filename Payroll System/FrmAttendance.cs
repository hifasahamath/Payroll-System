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
    public partial class FrmAttendance : Form
    {
        public FrmAttendance()
        {
            InitializeComponent();
        }

        ClassAttendance classAttendance = new ClassAttendance();



        //TIME CALCULATE
        private void dateTimePickerLeaveStartDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalWorkedHours();

        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            ClassCombobox.loadFK("SELECT * FROM Employee", comboBoxEmployeeID, "EmployeeID", "EmployeeID");


            ControlBox = false;

            classAttendance.AttendanceTable = dataGridViewAttendance;
            classAttendance.DisplayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (comboBoxEmployeeID.Text == "" || dateTimePickerDate.Text == "" || dateTimePickerInTime.Text == "" || dateTimePickerOutTime.Text == "" || txtWorkedHours.Text == "" )
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classAttendance.EmployeeID = comboBoxEmployeeID.Text;
                classAttendance.Date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
                classAttendance.InTime = dateTimePickerInTime.Text;
                classAttendance.OutTime = dateTimePickerOutTime.Text;
                classAttendance.TotalWorkedHours = txtWorkedHours.Text;
                classAttendance.OvertimeHours = txtOvertimeHours.Text;
                classAttendance.InsertDetails();
            }




        }

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAttendanceID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewAttendance.Rows[index];

            txtAttendanceID.Text = selectedrow.Cells[0].Value.ToString();
            comboBoxEmployeeID.Text = selectedrow.Cells[1].Value.ToString();
            dateTimePickerDate.Text = selectedrow.Cells[2].Value.ToString();
            dateTimePickerInTime.Text = selectedrow.Cells[3].Value.ToString();
            dateTimePickerOutTime.Text = selectedrow.Cells[4].Value.ToString();
            txtWorkedHours.Text = selectedrow.Cells[5].Value.ToString();
            txtOvertimeHours.Text = selectedrow.Cells[6].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAttendanceID.ReadOnly = false;
            txtAttendanceID.Text = "";
            comboBoxEmployeeID.Text = "";
            dateTimePickerDate.Text = "";
            dateTimePickerInTime.Text = "";
            dateTimePickerOutTime.Text = "";
            txtWorkedHours.Text = "";
            txtOvertimeHours.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || dateTimePickerDate.Text == "" || dateTimePickerInTime.Text == "" || dateTimePickerOutTime.Text == "" || txtWorkedHours.Text == "" || txtOvertimeHours.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classAttendance.EmployeeID = comboBoxEmployeeID.Text;
                    classAttendance.Date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
                    classAttendance.InTime = dateTimePickerInTime.Text;
                    classAttendance.OutTime = dateTimePickerOutTime.Text;
                    classAttendance.TotalWorkedHours = txtWorkedHours.Text;
                    classAttendance.OvertimeHours = txtOvertimeHours.Text;
                    classAttendance.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || dateTimePickerDate.Text == "" || dateTimePickerInTime.Text == "" || dateTimePickerOutTime.Text == "" || txtWorkedHours.Text == "" || txtOvertimeHours.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classAttendance.EmployeeID = comboBoxEmployeeID.Text;
                    classAttendance.Date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
                    classAttendance.InTime = dateTimePickerInTime.Text;
                    classAttendance.OutTime = dateTimePickerOutTime.Text;
                    classAttendance.TotalWorkedHours = txtWorkedHours.Text;
                    classAttendance.OvertimeHours = txtOvertimeHours.Text;
                    classAttendance.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }






        //TIME CALCULATE

        
        private void CalculateTotalWorkedHours()
        {
            DateTime inTime = dateTimePickerInTime.Value;
            DateTime outTime = dateTimePickerOutTime.Value;

            // Ensure OutTime is always after InTime
            if (outTime > inTime)
            {
                TimeSpan totalWorked = outTime - inTime;
                txtWorkedHours.Text = totalWorked.TotalHours.ToString("0.00");
            }
            else
            {
                txtWorkedHours.Text = "0.00";
            }
        }
        

        /*
        private void CalculateTotalWorkedHours()
        {
            DateTime inTime = dateTimePickerInTime.Value;
            DateTime outTime = dateTimePickerOutTime.Value;

            // Define the standard workday end time (5:00 PM)
            DateTime standardEnd = DateTime.Parse(dateTimePickerDate.Value.ToString("yyyy-MM-dd") + " 17:00:00");

            // Ensure OutTime is always after InTime
            if (outTime > inTime)
            {
                // Calculate total worked hours
                TimeSpan totalWorked = outTime - inTime;
                txtWorkedHours.Text = totalWorked.TotalHours.ToString("0.00");

                // Calculate overtime hours if out time is after 5 PM
                if (outTime > standardEnd)
                {
                    // Calculate the overtime hours
                    TimeSpan overtime = outTime - standardEnd;

                    // Only count overtime in hours
                    txtOvertimeHours.Text = overtime.TotalHours.ToString("0.00");
                }
                else
                {
                    // If no overtime, set overtime to 0
                    txtOvertimeHours.Text = "0.00";
                }
            }
            else
            {
                // If OutTime is not after InTime, show 0 hours
                txtWorkedHours.Text = "0.00";
                txtOvertimeHours.Text = "0.00";
            }
        }

        */






        private void txtWorkedHours_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalWorkedHours();

        }

        private void dateTimePickerInTime_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalWorkedHours();

        }

        private void comboBoxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOvertimeHours_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
