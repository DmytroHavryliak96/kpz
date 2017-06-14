using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;
using WindowsFormsApplication1.Properties;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool continueValue = false;


            if (!File.Exists("ADMIN.txt"))
            {
                Application.Run(new AdminRegister());
                Application.ExitThread();
            }

            do
            {
                ViewController controller = new ViewController(Settings.Default.DefaultView);
                Form currentForm = controller.getDefaultView();
                Application.Run(currentForm);
                continueValue = (currentForm as IViewLogin).ContinueFlag;
            } while (continueValue);

        }
    }
}
