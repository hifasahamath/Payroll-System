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
    internal class ClassEmployeeInsuarance
    {

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");


        public DataGridView EmployeeInsuranceTable { get; set; }

        public string EmployeeInsuranceID { get; set; }
        public string EmployeeID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string InsuranceID { get; set; }





        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT EmployeeInsuranceID, EmployeeID, StartDate, EndDate, InsuranceID FROM EmployeeInsurance";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            EmployeeInsuranceTable.DataSource = dt;
            con.Close();
        }



        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO EmployeeInsurance (EmployeeID, StartDate, EndDate, InsuranceID) values('" + EmployeeID + "','" + StartDate + "','" + EndDate + "','" + InsuranceID + "')";
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

                string query = "Update EmployeeInsurance SET EmployeeID= '" + EmployeeID + "', StartDate='" + StartDate + "', EndDate='" + EndDate + "', InsuranceID='" + InsuranceID + "' WHERE EmployeeInsuranceID = '" + EmployeeInsuranceID + "'";
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

                string query = "DELETE FROM EmployeeInsurance where EmployeeInsuranceID = '" + EmployeeInsuranceID + "'";
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
