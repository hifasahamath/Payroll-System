using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyGrifindoToysPayroll
{
    internal class ClassEmployeeType
    {

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");


        public DataGridView EmployeeTypeTable { get; set; }

        public string EmployeeTypeID { get; set; }
        public string EmployeeType { get; set; }
        public string OvertimeRatePerHour { get; set; }
        public string AnnualLeave { get; set; }






        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT EmployeeTypeID, EmployeeType, OvertimeRatePerHour, AnnualLeave FROM EmployeeType";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            EmployeeTypeTable.DataSource = dt;
            con.Close();
        }

        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO EmployeeType (EmployeeType, OvertimeRatePerHour, AnnualLeave) values('" + EmployeeType + "','" + OvertimeRatePerHour + "','" + AnnualLeave + "')";
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

                string query = "Update EmployeeType SET OvertimeRatePerHour= '" + OvertimeRatePerHour + "', AnnualLeave='" + AnnualLeave + "' WHERE EmployeeTypeID = '" + EmployeeTypeID + "'";
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

                string query = "DELETE FROM EmployeeType where EmployeeTypeID = '" + EmployeeTypeID + "'";
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
