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
    public partial class FrmEmployeeSalary : Form
    {
        private string connectionString = "Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True";
        public FrmEmployeeSalary()
        {
            InitializeComponent();
            LoadEmployeeIDs();

        }

        ClassEmployeeSalary classEmployeeSalary = new ClassEmployeeSalary();


        ///
        private void LoadEmployeeIDs()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeID FROM Employee", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxEmployeeID.Items.Add(reader["EmployeeID"].ToString());
                }
            }
        }


        private void FrmEmployeeSalary_Load(object sender, EventArgs e)
        {
            ClassCombobox.loadFK("SELECT * FROM Employee", comboBoxEmployeeID, "EmployeeID", "EmployeeID");

        }











        
        private void btnSave_Click(object sender, EventArgs e)
        {


            if (txtEmployeeSalaryID.Text == "" || comboBoxEmployeeID.Text == "" || txtMonthlySalary.Text == "" || txtAllowance.Text == "" || txtTotalAttendance.Text == "" || txtTotalLeaves.Text == "" || txtTotalAbsents.Text == "" || txtTotalHolidays.Text == "" || txtTotalOvertimeHours.Text == "" || txtSalaryCycleStartDate.Text == "" || txtSalaryCycleEndDate.Text == "" || txtSalaryCycleRange.Text == "" || txtNoPayValue.Text == "" || txtBasePayValue.Text == "" || txtGrossPayValue.Text == "" || txtTax.Text == "" || txtTotalOvertimePayment.Text == "" || txtOvertimeRatePerHour.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classEmployeeSalary.SalaryID = txtEmployeeSalaryID.Text;
                classEmployeeSalary.EmployeeID = comboBoxEmployeeID.Text;
                classEmployeeSalary.MonthlySalary = txtMonthlySalary.Text;
                classEmployeeSalary.Allowance = txtAllowance.Text;
                classEmployeeSalary.TotalAttendance = txtTotalAttendance.Text;
                classEmployeeSalary.TotalLeave = txtTotalLeaves.Text;
                classEmployeeSalary.TotalAbsents = txtTotalAbsents.Text;
                classEmployeeSalary.TotalHolidays = txtTotalHolidays.Text;
                //frmEmployeeSalary.TotalWorkedHours = comboBoxEmployee.Text;
                classEmployeeSalary.TotalOvertimeHours = txtTotalOvertimeHours.Text;
                classEmployeeSalary.SalaryCycleStartDate = txtSalaryCycleStartDate.Text;
                classEmployeeSalary.SalaryCycleEndDate = txtSalaryCycleEndDate.Text;
                classEmployeeSalary.SalaryCycleRange = txtSalaryCycleRange.Text;
                classEmployeeSalary.NoPayValue = txtNoPayValue.Text;
                classEmployeeSalary.BasePayValue = txtBasePayValue.Text;
                classEmployeeSalary.GrossPayValue = txtGrossPayValue.Text;
                classEmployeeSalary.Tax = txtTax.Text;
                classEmployeeSalary.TotalOvertimePayment = txtTotalOvertimePayment.Text;
                classEmployeeSalary.OvertimeRatePerHour = txtOvertimeRatePerHour.Text;
                classEmployeeSalary.InsertDetails();
            }




        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            txtEmployeeSalaryID.ReadOnly = false;
            txtEmployeeSalaryID.Text = "";
            comboBoxEmployeeID.Text = "";
            txtMonthlySalary.Text = "";
            txtAllowance.Text = "";
            txtTotalAttendance.Text = "";
            txtTotalLeaves.Text = "";
            txtTotalAbsents.Text = "";
            txtTotalHolidays.Text = "";
            txtTotalOvertimeHours.Text = "";
            txtSalaryCycleStartDate.Text = "";
            txtSalaryCycleEndDate.Text = "";
            txtSalaryCycleRange.Text = "";
            txtNoPayValue.Text = "";
            txtBasePayValue.Text = "";
            txtGrossPayValue.Text = "";
            txtTax.Text = "";
            txtTotalOvertimePayment.Text = "";
            txtOvertimeRatePerHour.Text = "";
           
        }


        /*
        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (txtEmployeeSalaryID.Text == "" || comboBoxEmployeeID.Text == "" || txtMonthlySalary.Text == "" || txtAllowance.Text == "" || txtTotalAttendance.Text == "" || txtTotalLeaves.Text == "" || txtTotalAbsents.Text == "" || txtTotalHolidays.Text == "" || txtTotalOvertimeHours.Text == "" || txtSalaryCycleStartDate.Text == "" || txtSalaryCycleEndDate.Text == "" || txtSalaryCycleRange.Text == "" || txtNoPayValue.Text == "" || txtBasePayValue.Text == "" || txtGrossPayValue.Text == "" || txtTax.Text == "" || txtTotalOvertimePayment.Text == "" || txtOvertimeRatePerHour.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classEmployeeSalary.SalaryID = txtEmployeeSalaryID.Text;
                    classEmployeeSalary.EmployeeID = comboBoxEmployeeID.Text;
                    classEmployeeSalary.MonthlySalary = txtMonthlySalary.Text;
                    classEmployeeSalary.Allowance = txtAllowance.Text;
                    classEmployeeSalary.TotalAttendance = txtTotalAttendance.Text;
                    classEmployeeSalary.TotalLeave = txtTotalLeaves.Text;
                    classEmployeeSalary.TotalAbsents = txtTotalAbsents.Text;
                    classEmployeeSalary.TotalHolidays = txtTotalHolidays.Text;
                    //frmEmployeeSalary.TotalWorkedHours = comboBoxEmployee.Text;
                    classEmployeeSalary.TotalOvertimeHours = txtTotalOvertimeHours.Text;
                    classEmployeeSalary.SalaryCycleStartDate = txtSalaryCycleStartDate.Text;
                    classEmployeeSalary.SalaryCycleEndDate = txtSalaryCycleEndDate.Text;
                    classEmployeeSalary.SalaryCycleRange = txtSalaryCycleRange.Text;
                    classEmployeeSalary.NoPayValue = txtNoPayValue.Text;
                    classEmployeeSalary.BasePayValue = txtBasePayValue.Text;
                    classEmployeeSalary.GrossPayValue = txtGrossPayValue.Text;
                    classEmployeeSalary.Tax = txtTax.Text;
                    classEmployeeSalary.TotalOvertimePayment = txtTotalOvertimePayment.Text;
                    classEmployeeSalary.OvertimeRatePerHour = txtOvertimeRatePerHour.Text;
                    classEmployeeSalary.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
     

        }
        */



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
        }
        




        ///
        private void comboBoxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadEmployeeDetails(comboBoxEmployeeID.SelectedItem.ToString());

            // Use SelectedValue instead of SelectedItem
            if (comboBoxEmployeeID.SelectedValue != null && int.TryParse(comboBoxEmployeeID.SelectedValue.ToString(), out int employeeID))
            {
                LoadEmployeeDetails(employeeID.ToString());  // Ensure the correct data type is passed
            }

        }


        ///
        private void LoadEmployeeDetails(string employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load Monthly Salary, Allowance
                SqlCommand cmd = new SqlCommand("SELECT MonthlySalary, Allowance FROM Employee WHERE EmployeeID = @EmployeeID", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMonthlySalary.Text = reader["MonthlySalary"].ToString();
                    txtAllowance.Text = reader["Allowance"].ToString();
                }
                reader.Close();

                // Load Overtime Rate Per Hour (Check if EmployeeType is correctly referenced)
                cmd = new SqlCommand("SELECT OvertimeRatePerHour FROM EmployeeType WHERE EmployeeTypeID = (SELECT EmployeeTypeID FROM Employee WHERE EmployeeID = @EmployeeID)", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                txtOvertimeRatePerHour.Text = cmd.ExecuteScalar()?.ToString() ?? "0";

                // Load Tax, Salary Cycle Info
                cmd = new SqlCommand("SELECT Tax, SalaryCycleStartDate, SalaryCycleEndDate, CycleDateRange FROM Setting", connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTax.Text = reader["Tax"].ToString();
                    txtSalaryCycleStartDate.Text = Convert.ToDateTime(reader["SalaryCycleStartDate"]).ToShortDateString();
                    txtSalaryCycleEndDate.Text = Convert.ToDateTime(reader["SalaryCycleEndDate"]).ToShortDateString();
                    txtSalaryCycleRange.Text = reader["CycleDateRange"].ToString();
                }
                reader.Close();

                // Load Attendance Details
                cmd = new SqlCommand("SELECT COUNT(*) FROM Attendance WHERE EmployeeID = @EmployeeID AND Date >= @StartDate AND Date <= @EndDate", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtSalaryCycleStartDate.Text));
                cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(txtSalaryCycleEndDate.Text));
                txtTotalAttendance.Text = cmd.ExecuteScalar().ToString();

                // Load Leaves
                cmd = new SqlCommand("SELECT COUNT(*) FROM Leave WHERE EmployeeID = @EmployeeID AND StartDate >= @StartDate AND EndDate <= @EndDate", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtSalaryCycleStartDate.Text));
                cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(txtSalaryCycleEndDate.Text));
                txtTotalLeaves.Text = cmd.ExecuteScalar().ToString();

                // Load Holidays
                cmd = new SqlCommand("SELECT COUNT(*) FROM Holiday WHERE HolidayDate >= @StartDate" , connection);
                cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtSalaryCycleStartDate.Text));
                txtTotalHolidays.Text = cmd.ExecuteScalar().ToString();

                // Load Overtime Hours
                cmd = new SqlCommand("SELECT SUM(OvertimeHours) FROM Attendance WHERE EmployeeID = @EmployeeID AND Date >= @StartDate AND Date <= @EndDate", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtSalaryCycleStartDate.Text));
                cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(txtSalaryCycleEndDate.Text));
                txtTotalOvertimeHours.Text = cmd.ExecuteScalar()?.ToString() ?? "0";

                // Calculate Absents
                cmd = new SqlCommand("SELECT AnnualLeave FROM EmployeeType WHERE EmployeeTypeID = (SELECT EmployeeTypeID FROM Employee WHERE EmployeeID = @EmployeeID)", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                int assignedAnnualLeave = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                int totalLeaves = int.Parse(txtTotalLeaves.Text);
                txtTotalAbsents.Text = (totalLeaves > assignedAnnualLeave ? totalLeaves - assignedAnnualLeave : 0).ToString();
            }
        }



        //CALCULATE SALARY
        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            decimal monthlySalary = decimal.Parse(txtMonthlySalary.Text);
            decimal allowance = decimal.Parse(txtAllowance.Text);
            decimal overtimeRate = decimal.Parse(txtOvertimeRatePerHour.Text);
            decimal taxRate = decimal.Parse(txtTax.Text) / 100;
            int totalAttendance = int.Parse(txtTotalAttendance.Text);
            int totalLeaves = int.Parse(txtTotalLeaves.Text);
            int totalAbsents = int.Parse(txtTotalAbsents.Text);
            int overtimeHours = int.Parse(txtTotalOvertimeHours.Text);

            decimal basePay = monthlySalary + allowance;
            decimal overtimePayment = overtimeHours * overtimeRate;
            decimal noPayValue = (monthlySalary / totalAttendance) * totalAbsents;
            decimal grossPay = (basePay + overtimePayment) - noPayValue;
            grossPay -= grossPay * taxRate;

            txtTotalOvertimePayment.Text = overtimePayment.ToString(""); 
            txtBasePayValue.Text = basePay.ToString("");
            txtNoPayValue.Text = noPayValue.ToString("");
            txtGrossPayValue.Text = grossPay.ToString("");
        }

        private void dataGridViewEmployeeSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
