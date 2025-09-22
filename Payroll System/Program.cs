using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGrifindoToysPayroll
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FrmLogin()); //First Run

            //Application.Run(new FrmAdmin()); 
            //Application.Run(new FrmContactDetails());
            //Application.Run(new FrmEmployeeType());
            //Application.Run(new FrmEmployee());
            //Application.Run(new FrmAttendance());
            //Application.Run(new FrmHoliday());
            //Application.Run(new FrmInsuarance());
            //Application.Run(new FrmEmployeeInsurance());
            //Application.Run(new FrmSetting());
            //Application.Run(new FrmLeave());
            //Application.Run(new FrmLeaveAssign());
            //Application.Run(new FrmDashboard());
            Application.Run(new FrmEmployeeSalary());




        }
    }
}
