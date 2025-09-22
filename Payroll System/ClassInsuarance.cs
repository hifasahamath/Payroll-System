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
    internal class ClassInsuarance
    {

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");

        public DataGridView InsuranceTable { get; set; }

        public string InsuranceID { get; set; }
        public string InsuranceType { get; set; }



        public void DisplayDetails()
        {

            con.Open();
            string query = "SELECT InsuranceID, InsuranceType FROM Insurance";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            InsuranceTable.DataSource = dt;
            con.Close();
        }




        public void InsertDetails()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Insurance (InsuranceType) values('" + InsuranceType + "')";
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

                string query = "Update Insurance SET InsuranceID= '" + InsuranceID + "', InsuranceType='" + InsuranceType + "' WHERE InsuranceID = '" + InsuranceID + "'";
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

                string query = "DELETE FROM Insurance where InsuranceID = '" + InsuranceID + "'";
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
