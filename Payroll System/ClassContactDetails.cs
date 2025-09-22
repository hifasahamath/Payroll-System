using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGrifindoToysPayroll
{
    internal class ClassContactDetails
    {

        //sqlconnection
        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");



        public DataGridView ContactDetailsTable { get; set; }

        public string ContactDetailsID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EmployeeID { get; set; }


        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT ContactDetailsID, EmployeeID, PhoneNumber, Email, Address, City, Country FROM ContactDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            ContactDetailsTable.DataSource = dt;
            con.Close();
        }

        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO ContactDetails (PhoneNumber, Email, Address, City, Country, EmployeeID) values('" + PhoneNumber + "','" + Email + "','" + StreetAddress + "','" + City + "', '" + Country + "', '" + EmployeeID + "')";
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

                string query = "Update ContactDetails SET PhoneNumber= '" + PhoneNumber + "', Email='" + Email + "', Address='" + StreetAddress + "', City='" + City + "', Country='" + Country + "', EmployeeID='" + EmployeeID + "' WHERE ContactDetailsID = '" + ContactDetailsID + "'";
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

                string query = "DELETE FROM ContactDetails where ContactDetailsID = '" + ContactDetailsID + "'";
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
