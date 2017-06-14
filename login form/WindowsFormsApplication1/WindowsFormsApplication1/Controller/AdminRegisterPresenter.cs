using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Hashing;
using WindowsFormsApplication1.ValidateInput;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1.Controller
{
    public class AdminRegisterPresenter 
    {
        private AdminRegister view;
        public AdminRegisterPresenter(AdminRegister view)
        {
            this.view = view;
        }

        protected bool CheckUserInput(string password, string login, string firstname, string lastname, string specialNumber, string phone)
        {
            if (!ValidateUser.CheckNullOrEmpty(password, login, firstname, lastname, specialNumber))
            {
                MessageBox.Show("input values must not be empty");
                return false;
            }

            if(!ValidateUser.CheckLetters(firstname, lastname))
            {
                MessageBox.Show("firstname and lastname must be letters");
                return false;
            }

            if(!ValidateUser.CkeckNumber(specialNumber))
            {
                MessageBox.Show("special number must digits");
                return false;
            }

            if (!ValidateUser.CheckLettersAndDigits(login, password))
            {
                MessageBox.Show("login and password must be letters or digits");
                return false;
            }

            if (!ValidateUser.CheckPhone(phone))
            {
                MessageBox.Show("phone number is incorrect");
                return false;
            }

            return true;
                
        }

        public bool RegisterAdmin()
        {
            var password = view.getPassword();
            var login = view.getLogin();
            var firstname = view.getFirstname();
            var lastname = view.getLastName();
            var specialNumber = view.getNumber();
            var phone = view.getPhone();
            if (!CheckUserInput(password, login, firstname, lastname, specialNumber, phone))
                return false;
                
            Human admin = new Entities.Admin();
            admin.FirstName = firstname;
            admin.LastName = lastname;
            admin.Login = login;
            admin.Password = MD5Hashing.CalculateMD5Hash(password);
            admin.Phone = phone;
            admin.SpecialNumber = MD5Hashing.CalculateMD5Hash(specialNumber);

            HumanWorker<Entities.Admin> worker = new HumanWorker<Entities.Admin>("ADMIN.txt");
            worker.Write(new List<Entities.Admin> { admin as Entities.Admin });
            MessageBox.Show("You are register as admin");
            return true;         

        }
       
    }
}
