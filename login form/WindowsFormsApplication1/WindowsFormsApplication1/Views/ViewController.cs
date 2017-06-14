using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Views
{
    public class ViewController
    {
        private string viewName;
        public ViewController(string defaultview)
        {
            viewName = defaultview;
        }

        public Form getDefaultView()
        {
            Form login = new MainLogin();

            if (!File.Exists("ADMIN.txt"))
            {
                
            }

            switch (viewName)
            {
                case "MainLogin":
                    {
                        return login;
                    }
                case "RandomNumber":
                    {
                        login = new RandomNumber();
                        return login;
                    }
                case "SMS":
                    {
                        login = new SMS();
                        return login;
                    }
                case "Admin":
                    {
                        login = new Admin();
                        return login;
                    }
                default:
                    return login;

                  //  return login;
            }
        }
    }
}
