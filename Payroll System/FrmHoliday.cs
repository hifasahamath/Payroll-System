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
    public partial class FrmHoliday : Form
    {
        public FrmHoliday()
        {
            InitializeComponent();
        }


        ClassHoliday classHoliday = new ClassHoliday();

        private void FrmHoliday_Load(object sender, EventArgs e)
        {
            ControlBox = false;

            classHoliday.HolidayTable = dataGridViewHoliday;
            classHoliday.DisplayDetails();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHolidayName.Text == "" || dateTimePickerHoliday.Text == "" || txtTotalHolidays.Text == "")
            {
                MessageBox.Show("Empty Fields, Please fill the data");
            }
            else
            {
                classHoliday.HolidayName = txtHolidayName.Text;
                classHoliday.HolidayDate = dateTimePickerHoliday.Value.ToString("yyyy-MM-dd");
                classHoliday.TotalHolidayDays = txtTotalHolidays.Text;
                classHoliday.InsertDetails();
            }
        }

        private void dataGridViewHoliday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHolidayID.ReadOnly = true;
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridViewHoliday.Rows[index];

            txtHolidayID.Text = selectedrow.Cells[0].Value.ToString();
            txtHolidayName.Text = selectedrow.Cells[1].Value.ToString();
            dateTimePickerHoliday.Text = selectedrow.Cells[2].Value.ToString();
            txtTotalHolidays.Text = selectedrow.Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHolidayID.ReadOnly = false;
            txtHolidayID.Text = "";
            txtHolidayName.Text = "";
            dateTimePickerHoliday.Text = "";
            txtTotalHolidays.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtHolidayName.Text == "" || dateTimePickerHoliday.Text == "" || txtTotalHolidays.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classHoliday.HolidayName = txtHolidayName.Text;
                    classHoliday.HolidayDate = dateTimePickerHoliday.Value.ToString("yyyy-MM-dd");
                    classHoliday.TotalHolidayDays = txtTotalHolidays.Text;
                    classHoliday.UpdateDetails();
                }
                else
                {
                    MessageBox.Show("Update Cancelled");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtHolidayName.Text == "" || dateTimePickerHoliday.Text == "" || txtTotalHolidays.Text == "")
            {
                MessageBox.Show("Empty Fields, Fill the data");
            }
            else
            {
                if (MessageBox.Show("Do You Want To Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classHoliday.HolidayName = txtHolidayName.Text;
                    classHoliday.HolidayDate = dateTimePickerHoliday.Value.ToString("yyyy-MM-dd");
                    classHoliday.TotalHolidayDays = txtTotalHolidays.Text;
                    classHoliday.DeleteDetails();
                }
                else
                {
                    MessageBox.Show("Delete Cancelled");
                }



            }
        }
    }
}
