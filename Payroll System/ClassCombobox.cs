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
    internal class ClassCombobox
    {

        private static SqlConnection conn = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");

        /*
        public static void loadFK(string _sql, ComboBox _myFKBox, string _displayColumnName, string _valueColumnName)
        {
            SqlDataAdapter da = new SqlDataAdapter(_sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _myFKBox.DataSource = dt;
            _myFKBox.DisplayMember = _displayColumnName;
            _myFKBox.ValueMember = _valueColumnName;
        }
        */

        public static void loadFK(string _sql, ComboBox _myFKBox, string _displayColumnName, string _valueColumnName)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(_sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                _myFKBox.DataSource = dt;
                _myFKBox.DisplayMember = _displayColumnName;
                _myFKBox.ValueMember = _valueColumnName;

                // Set to null initially to avoid issues during data binding
                _myFKBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ComboBox: " + ex.Message);
            }
        }

    }
}
