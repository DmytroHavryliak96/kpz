using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Hashing;
using WindowsFormsApplication1.ValidateInput;

namespace WindowsFormsApplication1.Controller
{
    public class MainLoginPresenter
    {
        private MainLogin view;

        public MainLoginPresenter(MainLogin view)
        {
            this.view = view;
        }

        public bool CheckUserInput(string password, string login)
        {
            if(!ValidateUser.CheckNullOrEmpty(password, login))
            {
                MessageBox.Show("input values must not be empty");
                return false;
            }
            return true;
        }

        public bool CheckAdmin()
        {
            
            HumanWorker<Entities.Admin> worker = new HumanWorker<Entities.Admin>("ADMIN.txt");
            List<Entities.Admin> admins = worker.ReadAll();

            var inputPassword = view.getPassword();
            var inputLogin = view.getLogin();
            
            var hashPassword = MD5Hashing.CalculateMD5Hash(inputPassword);

            if (admins.Any(a => a.Login.Equals(inputLogin) && a.Password.Equals(hashPassword)))
            {
                return true;
            }
            return false;
        }

        public bool CheckUser()
        {
            HumanWorker<Entities.User> worker = new HumanWorker<Entities.User>("USER.txt");
            List<Entities.User> users = worker.ReadAll();

            var inputPassword = view.getPassword();
            var inputLogin = view.getLogin();

            var hashPassword = MD5Hashing.CalculateMD5Hash(inputPassword);

            if (users.Any(u => u.Login.Equals(inputLogin) && u.Password.Equals(hashPassword)))
            {
                return true;
            }
            return false;
        }
    }
}
