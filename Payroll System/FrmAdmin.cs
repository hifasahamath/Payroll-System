using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyGrifindoToysPayroll
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }


        ClassAdmin classadmin = new ClassAdmin();

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            ControlBox = false;
  
            classadmin.AdminTable = dataGridViewAdmin;
            classadmin.DisplayDetails();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtAdminFullName.Text == "" || txtAdminNIC.Text == "" || txtAdminEmail.Text == "" || txtAdminUsername.Text == "" || txtAdminPassword.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classadmin.AdminID = txtAdminID.Text;
                classadmin.FullName = txtAdminFullName.Text;
                classadmin.NIC = txtAdminNIC.Text;
                classadmin.Email = txtAdminEmail.Text;
                classadmin.Username = txtAdminUsername.Text;
                classadmin.Password = txtAdminPassword.Text;
                classadmin.InsertDetails();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtAdminID.ReadOnly = false;
            txtAdminID.Text = "";
            txtAdminFullName.Text = "";
            txtAdminNIC.Text = "";
            txtAdminEmail.Text = "";
            txtAdminUsername.Text = "";
            txtAdminPassword.Text = "";



        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtAdminFullName.Text == "" || txtAdminNIC.Text == "" || txtAdminEmail.Text == "" || txtAdminUsername.Text == "" || txtAdminPassword.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classadmin.AdminID = txtAdminID.Text;
                    classadmin.FullName = txtAdminFullName.Text;
                    classadmin.NIC = txtAdminNIC.Text;
                    classadmin.Email = txtAdminEmail.Text;
                    classadmin.Username = txtAdminUsername.Text;
                    classadmin.Password = txtAdminPassword.Text;
                    classadmin.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtAdminFullName.Text == "" || txtAdminNIC.Text == "" || txtAdminEmail.Text == "" || txtAdminUsername.Text == "" || txtAdminPassword.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classadmin.AdminID = txtAdminID.Text;
                    classadmin.FullName = txtAdminFullName.Text;
                    classadmin.NIC = txtAdminNIC.Text;
                    classadmin.Email = txtAdminEmail.Text;
                    classadmin.Username = txtAdminUsername.Text;
                    classadmin.Password = txtAdminPassword.Text;
                    classadmin.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
        }

        private void dataGridViewAdmin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtAdminID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewAdmin.Rows[index];

            txtAdminID.Text = selectedrow.Cells[0].Value.ToString();
            txtAdminFullName.Text = selectedrow.Cells[1].Value.ToString();
            txtAdminNIC.Text = selectedrow.Cells[2].Value.ToString();
            txtAdminEmail.Text = selectedrow.Cells[3].Value.ToString();
            txtAdminUsername.Text = selectedrow.Cells[4].Value.ToString();
            txtAdminPassword.Text = selectedrow.Cells[5].Value.ToString();

        }
    }
}
