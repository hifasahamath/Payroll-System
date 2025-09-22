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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HIFAS\\SQLEXPRESS;Initial Catalog=GrifindoToysPayroll;Integrated Security=True;TrustServerCertificate=True");


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Admin WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    dt.Clear();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Login Success", "Login Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmDashboard frmDashboard = new FrmDashboard();
                        frmDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
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









            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ControlBox = false;

        }
    }
}
