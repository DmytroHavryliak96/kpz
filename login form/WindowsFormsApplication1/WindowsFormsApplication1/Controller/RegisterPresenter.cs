using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.CRUD;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Hashing;
using WindowsFormsApplication1.ValidateInput;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1.Controller
{
    public class RegisterPresenter
    {
        private Register view;
        public RegisterPresenter(Register view)
        {
            this.view = view;
        }

        private bool CheckUserInput(string password, string login, string firstname, string lastname, string specialNumber, string phone)
        {
            if (!ValidateUser.CheckNullOrEmpty(password, login, firstname, lastname, specialNumber))
            {
                MessageBox.Show("input values must not be empty");
                return false;
            }

            if (!ValidateUser.CheckLetters(firstname, lastname))
            {
                MessageBox.Show("firstname and lastname must be letters");
                return false;
            }

            if (!ValidateUser.CkeckNumber(specialNumber))
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

        public void RegisterNewUser()
        {
            var password = view.getPassword();
            var login = view.getLogin();
            var firstname = view.getFirstname();
            var lastname = view.getLastName();
            var specialNumber = view.getNumber();
            var phone = view.getPhone();

            if (!CheckUserInput(password, login, firstname, lastname, specialNumber, phone))
                return;

            Human user = new Entities.User();
            user.FirstName = firstname;
            user.LastName = lastname;
            user.Login = login;
            user.Password = MD5Hashing.CalculateMD5Hash(password);
            user.Phone = phone;
            user.SpecialNumber = MD5Hashing.CalculateMD5Hash(specialNumber);

            CRUDBuilder builder = new CRUDBuilder();
            var instance = builder.GetCRUD("user");

            if (instance.GetByLogin(user.Login) != null || instance.GetByPass(user.Password) != null)
            {
                MessageBox.Show("There is already user with current pass or login. Please, enter new values");
                return;
            }

            instance.addHuman(user);
            MessageBox.Show("You are successfully registered in the system");

        }
    }
}
