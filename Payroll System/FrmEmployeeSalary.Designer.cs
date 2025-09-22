namespace MyGrifindoToysPayroll
{
    partial class FrmEmployeeSalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalHolidays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeeSalary = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmployeeSalaryID = new System.Windows.Forms.TextBox();
            this.dateTimePickerEmployeeSalary = new System.Windows.Forms.DateTimePicker();
            this.txtTotalLeaves = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalAbsents = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotalAttendance = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOvertimeRatePerHour = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalOvertimePayment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBasePayValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalOvertimeHours = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNoPayValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGrossPayValue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalaryCycleStartDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalaryCycleEndDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSalaryCycleRange = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeSalary)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(533, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 32);
            this.label4.TabIndex = 77;
            this.label4.Text = "Employee Salary";
            this.label4.UseWaitCursor = true;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.ItemHeight = 20;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(28, 298);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(130, 28);
            this.comboBoxEmployeeID.TabIndex = 132;
            this.comboBoxEmployeeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 131;
            this.label7.Text = "EmployeeID:";
            // 
            // txtTotalHolidays
            // 
            this.txtTotalHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHolidays.Location = new System.Drawing.Point(796, 293);
            this.txtTotalHolidays.Multiline = true;
            this.txtTotalHolidays.Name = "txtTotalHolidays";
            this.txtTotalHolidays.Size = new System.Drawing.Size(130, 35);
            this.txtTotalHolidays.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(792, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 127;
            this.label5.Text = "Total Holidays:";
            // 
            // dataGridViewEmployeeSalary
            // 
            this.dataGridViewEmployeeSalary.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployeeSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeSalary.Location = new System.Drawing.Point(19, 100);
            this.dataGridViewEmployeeSalary.Name = "dataGridViewEmployeeSalary";
            this.dataGridViewEmployeeSalary.RowHeadersWidth = 51;
            this.dataGridViewEmployeeSalary.RowTemplate.Height = 24;
            this.dataGridViewEmployeeSalary.Size = new System.Drawing.Size(1283, 140);
            this.dataGridViewEmployeeSalary.TabIndex = 126;
            this.dataGridViewEmployeeSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeSalary_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtEmployeeSalaryID);
            this.panel1.Controls.Add(this.dateTimePickerEmployeeSalary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-3, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 92);
            this.panel1.TabIndex = 125;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(59, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 22);
            this.label18.TabIndex = 159;
            this.label18.Text = "EmployeeSalaryID:";
            // 
            // txtEmployeeSalaryID
            // 
            this.txtEmployeeSalaryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSalaryID.Location = new System.Drawing.Point(232, 32);
            this.txtEmployeeSalaryID.Multiline = true;
            this.txtEmployeeSalaryID.Name = "txtEmployeeSalaryID";
            this.txtEmployeeSalaryID.Size = new System.Drawing.Size(96, 35);
            this.txtEmployeeSalaryID.TabIndex = 159;
            // 
            // dateTimePickerEmployeeSalary
            // 
            this.dateTimePickerEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEmployeeSalary.Location = new System.Drawing.Point(1010, 30);
            this.dateTimePickerEmployeeSalary.Name = "dateTimePickerEmployeeSalary";
            this.dateTimePickerEmployeeSalary.Size = new System.Drawing.Size(284, 27);
            this.dateTimePickerEmployeeSalary.TabIndex = 133;
            // 
            // txtTotalLeaves
            // 
            this.txtTotalLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLeaves.Location = new System.Drawing.Point(410, 293);
            this.txtTotalLeaves.Multiline = true;
            this.txtTotalLeaves.Name = "txtTotalLeaves";
            this.txtTotalLeaves.Size = new System.Drawing.Size(130, 35);
            this.txtTotalLeaves.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 123;
            this.label3.Text = "Total Leaves:";
            // 
            // txtTotalAbsents
            // 
            this.txtTotalAbsents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAbsents.Location = new System.Drawing.Point(599, 293);
            this.txtTotalAbsents.Multiline = true;
            this.txtTotalAbsents.Name = "txtTotalAbsents";
            this.txtTotalAbsents.Size = new System.Drawing.Size(130, 35);
            this.txtTotalAbsents.TabIndex = 122;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(595, 258);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(126, 22);
            this.label.TabIndex = 121;
            this.label.Text = "Total Absents:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(219, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 56);
            this.btnExit.TabIndex = 120;
            this.btnExit.Text = "← Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtTotalAttendance
            // 
            this.txtTotalAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAttendance.Location = new System.Drawing.Point(221, 293);
            this.txtTotalAttendance.Multiline = true;
            this.txtTotalAttendance.Name = "txtTotalAttendance";
            this.txtTotalAttendance.Size = new System.Drawing.Size(130, 35);
            this.txtTotalAttendance.TabIndex = 119;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(828, 650);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 56);
            this.btnUpdate.TabIndex = 116;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1030, 650);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 56);
            this.btnDelete.TabIndex = 117;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(418, 650);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 56);
            this.btnClear.TabIndex = 114;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(625, 650);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 56);
            this.btnSave.TabIndex = 115;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 118;
            this.label1.Text = "Total Attendance:";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlySalary.Location = new System.Drawing.Point(28, 390);
            this.txtMonthlySalary.Multiline = true;
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(130, 35);
            this.txtMonthlySalary.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 133;
            this.label6.Text = "Monthly Salary:";
            // 
            // txtAllowance
            // 
            this.txtAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllowance.Location = new System.Drawing.Point(28, 482);
            this.txtAllowance.Multiline = true;
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(130, 35);
            this.txtAllowance.TabIndex = 136;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 135;
            this.label8.Text = "Allowance:";
            // 
            // txtOvertimeRatePerHour
            // 
            this.txtOvertimeRatePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOvertimeRatePerHour.Location = new System.Drawing.Point(28, 570);
            this.txtOvertimeRatePerHour.Multiline = true;
            this.txtOvertimeRatePerHour.Name = "txtOvertimeRatePerHour";
            this.txtOvertimeRatePerHour.Size = new System.Drawing.Size(130, 35);
            this.txtOvertimeRatePerHour.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 22);
            this.label9.TabIndex = 137;
            this.label9.Text = "Overtime Rate Per Hour:";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(32, 662);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(130, 35);
            this.txtTax.TabIndex = 140;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 22);
            this.label10.TabIndex = 139;
            this.label10.Text = "Tax Rate:";
            // 
            // txtTotalOvertimePayment
            // 
            this.txtTotalOvertimePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOvertimePayment.Location = new System.Drawing.Point(34, 88);
            this.txtTotalOvertimePayment.Multiline = true;
            this.txtTotalOvertimePayment.Name = "txtTotalOvertimePayment";
            this.txtTotalOvertimePayment.Size = new System.Drawing.Size(130, 35);
            this.txtTotalOvertimePayment.TabIndex = 142;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 22);
            this.label11.TabIndex = 141;
            this.label11.Text = "Total Overtime Payment:";
            // 
            // txtBasePayValue
            // 
            this.txtBasePayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePayValue.Location = new System.Drawing.Point(255, 88);
            this.txtBasePayValue.Multiline = true;
            this.txtBasePayValue.Name = "txtBasePayValue";
            this.txtBasePayValue.Size = new System.Drawing.Size(130, 35);
            this.txtBasePayValue.TabIndex = 144;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 22);
            this.label12.TabIndex = 143;
            this.label12.Text = "Base Pay Value:";
            // 
            // txtTotalOvertimeHours
            // 
            this.txtTotalOvertimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOvertimeHours.Location = new System.Drawing.Point(985, 293);
            this.txtTotalOvertimeHours.Multiline = true;
            this.txtTotalOvertimeHours.Name = "txtTotalOvertimeHours";
            this.txtTotalOvertimeHours.Size = new System.Drawing.Size(130, 35);
            this.txtTotalOvertimeHours.TabIndex = 146;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(981, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 22);
            this.label13.TabIndex = 145;
            this.label13.Text = "Total Overtime Hours:";
            // 
            // txtNoPayValue
            // 
            this.txtNoPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPayValue.Location = new System.Drawing.Point(457, 88);
            this.txtNoPayValue.Multiline = true;
            this.txtNoPayValue.Name = "txtNoPayValue";
            this.txtNoPayValue.Size = new System.Drawing.Size(130, 35);
            this.txtNoPayValue.TabIndex = 148;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(453, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 22);
            this.label14.TabIndex = 147;
            this.label14.Text = "No Pay Value:";
            // 
            // txtGrossPayValue
            // 
            this.txtGrossPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPayValue.Location = new System.Drawing.Point(662, 88);
            this.txtGrossPayValue.Multiline = true;
            this.txtGrossPayValue.Name = "txtGrossPayValue";
            this.txtGrossPayValue.Size = new System.Drawing.Size(130, 35);
            this.txtGrossPayValue.TabIndex = 150;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(658, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 22);
            this.label15.TabIndex = 149;
            this.label15.Text = "Gross Pay Value:";
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalculateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSalary.ForeColor = System.Drawing.Color.White;
            this.btnCalculateSalary.Location = new System.Drawing.Point(1097, 472);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(203, 56);
            this.btnCalculateSalary.TabIndex = 151;
            this.btnCalculateSalary.Text = "Calculate Salary";
            this.btnCalculateSalary.UseVisualStyleBackColor = false;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoPayValue);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtGrossPayValue);
            this.groupBox1.Controls.Add(this.txtTotalOvertimePayment);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBasePayValue);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(221, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 162);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary Calculation";
            // 
            // txtSalaryCycleStartDate
            // 
            this.txtSalaryCycleStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryCycleStartDate.Location = new System.Drawing.Point(258, 581);
            this.txtSalaryCycleStartDate.Multiline = true;
            this.txtSalaryCycleStartDate.Name = "txtSalaryCycleStartDate";
            this.txtSalaryCycleStartDate.Size = new System.Drawing.Size(130, 35);
            this.txtSalaryCycleStartDate.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 153;
            this.label2.Text = "Salary Cycle Start Date:  ";
            // 
            // txtSalaryCycleEndDate
            // 
            this.txtSalaryCycleEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryCycleEndDate.Location = new System.Drawing.Point(487, 581);
            this.txtSalaryCycleEndDate.Multiline = true;
            this.txtSalaryCycleEndDate.Name = "txtSalaryCycleEndDate";
            this.txtSalaryCycleEndDate.Size = new System.Drawing.Size(130, 35);
            this.txtSalaryCycleEndDate.TabIndex = 156;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(483, 546);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(206, 22);
            this.label16.TabIndex = 155;
            this.label16.Text = "Salary Cycle End Date:  ";
            // 
            // txtSalaryCycleRange
            // 
            this.txtSalaryCycleRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryCycleRange.Location = new System.Drawing.Point(709, 581);
            this.txtSalaryCycleRange.Multiline = true;
            this.txtSalaryCycleRange.Name = "txtSalaryCycleRange";
            this.txtSalaryCycleRange.Size = new System.Drawing.Size(130, 35);
            this.txtSalaryCycleRange.TabIndex = 158;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(705, 546);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 22);
            this.label17.TabIndex = 157;
            this.label17.Text = "Salary Cycle Range:  ";
            // 
            // FrmEmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 732);
            this.Controls.Add(this.txtSalaryCycleRange);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSalaryCycleEndDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSalaryCycleStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculateSalary);
            this.Controls.Add(this.txtTotalOvertimeHours);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOvertimeRatePerHour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMonthlySalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalHolidays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewEmployeeSalary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotalLeaves);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalAbsents);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotalAttendance);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmployeeSalary";
            this.Text = "EmployeeSalary";
            this.Load += new System.EventHandler(this.FrmEmployeeSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeSalary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalHolidays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeSalary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalLeaves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalAbsents;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotalAttendance;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmployeeSalary;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOvertimeRatePerHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalOvertimePayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBasePayValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalOvertimeHours;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNoPayValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGrossPayValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalaryCycleStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalaryCycleEndDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSalaryCycleRange;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmployeeSalaryID;
    }
}