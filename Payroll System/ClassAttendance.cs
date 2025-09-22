using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGrifindoToysPayroll
{
    internal class ClassAttendance
    {

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");

        public DataGridView AttendanceTable { get; set; }

        public string AttendanceID { get; set; }
        public string EmployeeID { get; set; }
        public string Date { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string TotalWorkedHours { get; set; }
        public string OvertimeHours { get; set; }



        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT AttendanceID, EmployeeID, Date, InTime, OutTime, TotalWorkedHours, OvertimeHours FROM Attendance";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            AttendanceTable.DataSource = dt;
            con.Close();
        }








        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Attendance (EmployeeID, Date, InTime, OutTime, TotalWorkedHours, OvertimeHours) values('" + EmployeeID + "','" + Date + "','" + InTime + "','" + OutTime + "', '" + TotalWorkedHours + "', '" + OvertimeHours + "')";
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

        public void UpdateDetails()
        {
            try
            {
                con.Open();

                string query = "Update Employee SET EmployeeID= '" + EmployeeID + "', Date='" + Date + "', InTime='" + InTime + "', OutTime='" + OutTime + "', TotalWorkedHours='" + TotalWorkedHours + "', OvertimeHours='" + OvertimeHours + "' WHERE AttendanceID = '" + AttendanceID + "'";
                SqlCommand CMB = new SqlCommand(query, con);
                int affectedRows = CMB.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Update Success", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Data Updated", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                string query = "DELETE FROM Attendance where AttendanceID = '" + AttendanceID + "'";
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
