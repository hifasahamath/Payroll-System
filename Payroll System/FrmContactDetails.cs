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
    public partial class FrmContactDetails : Form
    {
        public FrmContactDetails()
        {
            InitializeComponent();
        }

        ClassContactDetails classContactDetails = new ClassContactDetails();
        private void FrmContactDetails_Load(object sender, EventArgs e)
        {
            ClassCombobox.loadFK("SELECT * FROM Employee", comboBoxEmployee, "EmployeeID", "EmployeeID");


            ControlBox = false;

            classContactDetails.ContactDetailsTable = dataGridViewContactDetails;
            classContactDetails.DisplayDetails();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtPhoneNumber.Text == "" || txtEmail.Text == "" || txtStreetAddress.Text == "" || txtCity.Text == "" || txtCountry.Text == "" || comboBoxEmployee.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classContactDetails.ContactDetailsID = txtContactDetailsID.Text;
                classContactDetails.PhoneNumber = txtPhoneNumber.Text;
                classContactDetails.Email = txtEmail.Text;
                classContactDetails.StreetAddress = txtStreetAddress.Text;
                classContactDetails.City = txtCity.Text;
                classContactDetails.Country = txtCountry.Text;
                classContactDetails.EmployeeID = comboBoxEmployee.Text;
                classContactDetails.InsertDetails();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtContactDetailsID.ReadOnly = false;
            txtContactDetailsID.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtStreetAddress.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            comboBoxEmployee.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtPhoneNumber.Text == "" || txtEmail.Text == "" || txtStreetAddress.Text == "" || txtCity.Text == "" || txtCountry.Text == "" || comboBoxEmployee.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classContactDetails.ContactDetailsID = txtContactDetailsID.Text;
                    classContactDetails.PhoneNumber = txtPhoneNumber.Text;
                    classContactDetails.Email = txtEmail.Text;
                    classContactDetails.StreetAddress = txtStreetAddress.Text;
                    classContactDetails.City = txtCity.Text;
                    classContactDetails.Country = txtCountry.Text;
                    classContactDetails.EmployeeID = comboBoxEmployee.Text;
                    classContactDetails.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtPhoneNumber.Text == "" || txtEmail.Text == "" || txtStreetAddress.Text == "" || txtCity.Text == "" || txtCountry.Text == "" || comboBoxEmployee.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classContactDetails.ContactDetailsID = txtContactDetailsID.Text;
                    classContactDetails.PhoneNumber = txtPhoneNumber.Text;
                    classContactDetails.Email = txtEmail.Text;
                    classContactDetails.StreetAddress = txtStreetAddress.Text;
                    classContactDetails.City = txtCity.Text;
                    classContactDetails.Country = txtCountry.Text;
                    classContactDetails.EmployeeID = comboBoxEmployee.Text;
                    classContactDetails.DeleteDetails();
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

        private void dataGridViewContactDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtContactDetailsID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewContactDetails.Rows[index];

            txtContactDetailsID.Text = selectedrow.Cells[0].Value.ToString();
            txtPhoneNumber.Text = selectedrow.Cells[1].Value.ToString();
            txtEmail.Text = selectedrow.Cells[2].Value.ToString();
            txtStreetAddress.Text = selectedrow.Cells[3].Value.ToString();
            txtCity.Text = selectedrow.Cells[4].Value.ToString();
            txtCountry.Text = selectedrow.Cells[5].Value.ToString();
            comboBoxEmployee.Text = selectedrow.Cells[5].Value.ToString();

        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
