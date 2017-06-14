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

namespace WindowsFormsApplication1.Controller
{
    public class RandomNumberPresenter
    {
        private RandomNumber view;

        public RandomNumberPresenter(RandomNumber view)
        {
            this.view = view;
        }

        private bool CheckUserInput(string login, string specialNumber)
        {
            if (!ValidateUser.CheckNullOrEmpty(login))
            {
                MessageBox.Show("input values must not be empty");
                return false;
            }

            if (!ValidateUser.CkeckNumber(specialNumber))
            {
                MessageBox.Show("special number must digits");
                return false;
            }

            return true;

        }

        public int GenerateRandomNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 101);
            return randomNumber;
        }

        private bool CheckInput()
        {
            var login = view.getLogin();
            var specialNumber = view.getSpecialNumber();
            var randNumber = view.getRandNumber();

            if (!CheckUserInput(login, specialNumber))
                return false;

            if(randNumber.Equals("") || randNumber == null)
            {
                MessageBox.Show("you must first generate random number");
                return false;
            }

            return true;
        }

        public bool CkeckNumber()
        {
            if (!CheckInput())
                return false;

            var login = view.getLogin();
            var specialNumber = view.getSpecialNumber();
            var randNumber = view.getRandNumber();
            ////////////////

            int enteredSum = Convert.ToInt32(specialNumber);
            int rand = Convert.ToInt32(randNumber);
            ////////////////

            string difference = (enteredSum - rand).ToString();

            var hashDifference = MD5Hashing.CalculateMD5Hash(difference);

            CRUDBuilder builder = new CRUDBuilder();
            var instance = builder.GetCRUDByLogin(login);
            if(instance == null)
            {
                MessageBox.Show("There is no user with current login");
                return false;
            }

            Human human = instance.GetByLogin(login);

            if (!human.SpecialNumber.Equals(hashDifference))
            {
                MessageBox.Show("You enter the wrong number");
                return false;
            }

            return true;

        }

    }
}
