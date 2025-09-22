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
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        ClassSetting classSetting = new ClassSetting();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            classSetting.SettingTable = dataGridViewSetting;
            classSetting.DisplayDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTax.Text == "" || dateTimePickerSalaryStartDate.Text == "" || dateTimePickerSalaryEndDate.Text == "" || txtSalaryCycleRange.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classSetting.Tax = txtTax.Text;
                classSetting.SalaryCycleStartDate = dateTimePickerSalaryStartDate.Value.ToString("yyyy-MM-dd");
                classSetting.SalaryCycleEndDate = dateTimePickerSalaryEndDate.Value.ToString("yyyy-MM-dd");
                classSetting.CycleDateRange = txtSalaryCycleRange.Text;
                classSetting.InsertDetails();
            }
        }

        private void dataGridViewSetting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSettingID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewSetting.Rows[index];

            txtSettingID.Text = selectedrow.Cells[0].Value.ToString();
            txtTax.Text = selectedrow.Cells[1].Value.ToString();
            dateTimePickerSalaryStartDate.Text = selectedrow.Cells[2].Value.ToString();
            dateTimePickerSalaryEndDate.Text = selectedrow.Cells[3].Value.ToString();
            txtSalaryCycleRange.Text = selectedrow.Cells[4].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSettingID.ReadOnly = false;
            txtSettingID.Text = "";
            txtTax.Text = "";
            dateTimePickerSalaryStartDate.Text = "";
            dateTimePickerSalaryEndDate.Text = "";
            txtSalaryCycleRange.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTax.Text == "" || dateTimePickerSalaryStartDate.Text == "" || dateTimePickerSalaryEndDate.Text == "" || txtSalaryCycleRange.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classSetting.Tax = txtTax.Text;
                    classSetting.SalaryCycleStartDate = dateTimePickerSalaryStartDate.Value.ToString("yyyy-MM-dd");
                    classSetting.SalaryCycleEndDate = dateTimePickerSalaryEndDate.Value.ToString("yyyy-MM-dd");
                    classSetting.CycleDateRange = txtSalaryCycleRange.Text;
                    classSetting.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTax.Text == "" || dateTimePickerSalaryStartDate.Text == "" || dateTimePickerSalaryEndDate.Text == "" || txtSalaryCycleRange.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classSetting.Tax = txtTax.Text;
                    classSetting.SalaryCycleStartDate = dateTimePickerSalaryStartDate.Value.ToString("yyyy-MM-dd");
                    classSetting.SalaryCycleEndDate = dateTimePickerSalaryEndDate.Value.ToString("yyyy-MM-dd");
                    classSetting.CycleDateRange = txtSalaryCycleRange.Text;
                    classSetting.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }

            }
        }





        //CalculateSalaryCycleRange
        private void CalculateSalaryCycleRange()
        {
            DateTime startDate = dateTimePickerSalaryStartDate.Value;
            DateTime endDate = dateTimePickerSalaryEndDate.Value;

            // Ensure End Date is after Start Date
            if (endDate >= startDate)
            {
                TimeSpan cycleRange = endDate - startDate;
                txtSalaryCycleRange.Text = cycleRange.Days.ToString(); // Display days difference
            }
            else
            {
                txtSalaryCycleRange.Text = "Invalid Date Range";
            }
        }

        private void dateTimePickerSalaryStartDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateSalaryCycleRange();
        }

        private void dateTimePickerSalaryEndDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateSalaryCycleRange();
        }
    }
}
