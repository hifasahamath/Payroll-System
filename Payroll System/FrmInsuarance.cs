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
    public partial class FrmInsuarance : Form
    {
        public FrmInsuarance()
        {
            InitializeComponent();
        }

        ClassInsuarance classInsurance = new ClassInsuarance();

        private void FrmInsuarance_Load(object sender, EventArgs e)
        {
            ControlBox = false;

            classInsurance.InsuranceTable = dataGridViewInsuarance;
            classInsurance.DisplayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInsuaranceType.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classInsurance.InsuranceType = txtInsuaranceType.Text;
                classInsurance.InsertDetails();
            }
        }

        private void dataGridViewInsuarance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtInsuaranceID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewInsuarance.Rows[index];

            txtInsuaranceID.Text = selectedrow.Cells[0].Value.ToString();
            txtInsuaranceType.Text = selectedrow.Cells[1].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInsuaranceID.ReadOnly = false;
            txtInsuaranceID.Text = "";
            txtInsuaranceType.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtInsuaranceType.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classInsurance.InsuranceType = txtInsuaranceType.Text;
                    classInsurance.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtInsuaranceType.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classInsurance.InsuranceType = txtInsuaranceType.Text;
                    classInsurance.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }
    }
    
}
