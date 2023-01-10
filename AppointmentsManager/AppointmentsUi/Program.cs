using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentsUi
{
    static class Program
    {
        public static MainForm mainForm = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool dbConnectionSuccessful = AppointmentsLib.Database.Connect("docker01.solidstage.icu", 3306, "school", "school", "aaa");

            if(!dbConnectionSuccessful)
            {
                MessageBox.Show("Database connection failed, exiting...");

                return;
            } else
            {
                //MessageBox.Show("Database connected successfully");
            }

            Application.Run(mainForm);
        }
    }
}
