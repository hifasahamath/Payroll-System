using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyGrifindoToysPayroll
{
    internal class ClassEmployee
    {

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");


        public DataGridView EmployeeTable { get; set; }

        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string NIC { get; set; }
        public string JoinDate { get; set; }
        public string MonthlySalary { get; set; }
        public string Allowance { get; set; }
        public string EmployeeType { get; set; }



        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT EmployeeID, FullName, NIC, JoinDate, MonthlySalary, Allowance, EmployeeType FROM Employee";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            EmployeeTable.DataSource = dt;
            con.Close();
        }

        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Employee (FullName, NIC, JoinDate, MonthlySalary, Allowance, EmployeeType) values('" + FullName + "','" + NIC + "','" + JoinDate + "','" + MonthlySalary + "', '" + Allowance + "', '" + EmployeeType + "')";
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

                string query = "Update Employee SET FullName= '" + FullName + "', NIC='" + NIC + "', JoinDate='" + JoinDate + "', MonthlySalary='" + MonthlySalary + "', Allowance='" + Allowance + "', EmployeeType='" + EmployeeType + "' WHERE EmployeeID = '" + EmployeeID + "'";
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

                string query = "DELETE FROM Employee where EmployeeID = '" + EmployeeID + "'";
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
