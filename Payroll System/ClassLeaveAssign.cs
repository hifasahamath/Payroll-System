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
    internal class ClassLeaveAssign
    {

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");

        public DataGridView LeaveAssignTable { get; set; }

        public string LeaveAssignID { get; set; }
        public string EmployeeID { get; set; }
        public string NoOfAnnualLeave { get; set; }
        public string NoOfCasualLeave { get; set; }



        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT LeaveAssignID, NoOfAnnualLeave, NoOfCasualLeave FROM LeaveAssign";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            LeaveAssignTable.DataSource = dt;
            con.Close();
        }






        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO LeaveAssign (EmployeeID, NoOfAnnualLeave, NoOfCasualLeave) values('" + EmployeeID + "','" + NoOfAnnualLeave + "','" + NoOfCasualLeave + "')";
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

                string query = "Update LeaveAssign SET EmployeeID= '" + EmployeeID + "', NoOfAnnualLeave='" + NoOfAnnualLeave + "', NoOfCasualLeave='" + NoOfCasualLeave + "' WHERE LeaveAssignID = '" + LeaveAssignID + "'";
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

                string query = "DELETE FROM LeaveAssign where LeaveAssignID = '" + LeaveAssignID + "'";
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
