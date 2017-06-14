using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1.Controller
{
    public class ChooseAdminPresenter
    {
        private ChooseAdmin view;

        public ChooseAdminPresenter(ChooseAdmin view)
        {
            this.view = view;
        }

        private RadioButton Check_RadioButton()
        {
            var radioButton = view.getContainer().Controls.OfType<RadioButton>().
                FirstOrDefault(r => r.Checked);
            return radioButton;
        }

        public void SetType()
        {
            var button = Check_RadioButton();
            if (button == null)
                return;
            var oldsettings = Settings.Default.DefaultView;
            var name = button.Text;
            switch (name)
            {
                case "Transitive":
                    {
                        Settings.Default.DefaultView = "Admin";
                        break;
                    }
                case "Login and Password":
                    {
                        Settings.Default.DefaultView = "MainLogin";
                        break;
                    }
                case "via SMS":
                    {
                        Settings.Default.DefaultView = "SMS";
                        break;
                    }
                case "via Random Number":
                    {
                        Settings.Default.DefaultView = "RandomNumber";
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
            Properties.Settings.Default.Save();
        }
    }
}
