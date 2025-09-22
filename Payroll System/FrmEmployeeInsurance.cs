using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGrifindoToysPayroll
{
    public partial class FrmEmployeeInsurance : Form
    {
        public FrmEmployeeInsurance()
        {
            InitializeComponent();
        }


        ClassEmployeeInsuarance classEmployeeInsuarance = new ClassEmployeeInsuarance();

        private void dataGridViewEmployeeType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEmployeeInsurance_Load(object sender, EventArgs e)
        {
            ClassCombobox.loadFK("SELECT * FROM Employee", comboBoxEmployeeID, "EmployeeID", "EmployeeID");
            ClassCombobox.loadFK("SELECT * FROM Insurance", comboBoxInsuaranceID, "InsuranceID", "InsuranceID");


            ControlBox = false;

            classEmployeeInsuarance.EmployeeInsuranceTable = dataGridViewEmployeeInsuarance;
            classEmployeeInsuarance.DisplayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || EmployeeInsuaranceStartDate.Text == "" || EmployeeInsuaranceEndDate.Text == "" || comboBoxInsuaranceID.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classEmployeeInsuarance.EmployeeInsuranceID = txtEmployeeInsuarance.Text;
                classEmployeeInsuarance.EmployeeID = comboBoxEmployeeID.Text;
                classEmployeeInsuarance.StartDate = EmployeeInsuaranceStartDate.Value.ToString("yyyy-MM-dd");
                classEmployeeInsuarance.EndDate = EmployeeInsuaranceEndDate.Value.ToString("yyyy-MM-dd");
                classEmployeeInsuarance.InsuranceID = comboBoxInsuaranceID.Text;
                classEmployeeInsuarance.InsertDetails();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeInsuarance.ReadOnly = false;
            txtEmployeeInsuarance.Text = "";
            comboBoxEmployeeID.Text = "";
            EmployeeInsuaranceStartDate.Text = "";
            EmployeeInsuaranceEndDate.Text = "";
            comboBoxInsuaranceID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || EmployeeInsuaranceStartDate.Text == "" || EmployeeInsuaranceEndDate.Text == "" || comboBoxInsuaranceID.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classEmployeeInsuarance.EmployeeInsuranceID = txtEmployeeInsuarance.Text;
                    classEmployeeInsuarance.EmployeeID = comboBoxEmployeeID.Text;
                    classEmployeeInsuarance.StartDate = EmployeeInsuaranceStartDate.Text;
                    classEmployeeInsuarance.EndDate = EmployeeInsuaranceEndDate.Text;
                    classEmployeeInsuarance.InsuranceID = comboBoxInsuaranceID.Text;
                    classEmployeeInsuarance.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployeeID.Text == "" || EmployeeInsuaranceStartDate.Text == "" || EmployeeInsuaranceEndDate.Text == "" || comboBoxInsuaranceID.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classEmployeeInsuarance.EmployeeInsuranceID = txtEmployeeInsuarance.Text;
                    classEmployeeInsuarance.EmployeeID = comboBoxEmployeeID.Text;
                    classEmployeeInsuarance.StartDate = EmployeeInsuaranceStartDate.Text;
                    classEmployeeInsuarance.EndDate = EmployeeInsuaranceEndDate.Text;
                    classEmployeeInsuarance.InsuranceID = comboBoxInsuaranceID.Text;
                    classEmployeeInsuarance.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }
    }
}
