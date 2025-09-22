using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGrifindoToysPayroll
{
    internal class ClassEmployeeSalary
    {

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");

        public DataGridView EmployeeSalaryTable { get; set; }

        public string SalaryID { get; set; }
        public string EmployeeID { get; set; }
        public string MonthlySalary { get; set; }
        public string Allowance { get; set; }
        public string TotalAttendance { get; set; }
        public string TotalLeave { get; set; }
        public string TotalAbsents { get; set; }
        public string TotalHolidays { get; set; }
        public string TotalWorkedHours { get; set; }
        public string TotalOvertimeHours { get; set; }
        public string SalaryCycleStartDate { get; set; }
        public string SalaryCycleEndDate { get; set; }
        public string SalaryCycleRange { get; set; }
        public string NoPayValue { get; set; }
        public string BasePayValue { get; set; }
        public string GrossPayValue { get; set; }
        public string Tax { get; set; }
        public string TotalOvertimePayment { get; set; }
        public string OvertimeRatePerHour { get; set; }



        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT SalaryID, EmployeeID, MonthlySalary, Allowance, TotalAttendance, TotalLeave, TotalAbsents, TotalHolidays, TotalWorkedHours, TotalOvertimeHours, OvertimeRatePerHour, TotalOvertimePayment, Tax, SalaryCycleStartDate, SalaryCycleEndDate, SalaryCycleRange, NoPayValue, BasePayValue, GrossPayValue FROM Salary";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            EmployeeSalaryTable.DataSource = dt;
            con.Close();

        }






        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Salary (EmployeeID, MonthlySalary, Allowance, TotalAttendance, TotalLeave, TotalAbsents, TotalHolidays, TotalWorkedHours, TotalOvertimeHours, OvertimeRatePerHour, TotalOvertimePayment, Tax, SalaryCycleStartDate, SalaryCycleEndDate, SalaryCycleRange, NoPayValue, BasePayValue, GrossPayValue) values('" + EmployeeID + "','" + MonthlySalary + "','" + Allowance + "','" + TotalAttendance + "', '" + TotalLeave + "', '" + TotalAbsents + "', '" + TotalHolidays + "', '" + TotalWorkedHours + "', '" + TotalOvertimeHours + "', '" + OvertimeRatePerHour + "', '" + TotalOvertimePayment + "', '" + Tax + "', '" + SalaryCycleStartDate + "', '" + SalaryCycleEndDate + "', '" + SalaryCycleRange + "', '" + NoPayValue + "', '" + BasePayValue + "', '" + GrossPayValue + "')";
                SqlCommand CMB = new SqlCommand(query, con);
                int affectedrows = CMB.ExecuteNonQuery();
                if (affectedrows > 0)
                {
                    MessageBox.Show("Insert Successful", "Insert Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Insert Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            DisplayDetails();
        }

       

        public void DeleteDetails()
        {
            try
            {
                con.Open();

                string query = "DELETE FROM Salary where SalaryID = '" + SalaryID + "'";
                SqlCommand CMB = new SqlCommand(query, con);
                int affectedRows = CMB.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Delete Success", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Data Deleted", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            DisplayDetails();





        }









    }
}
