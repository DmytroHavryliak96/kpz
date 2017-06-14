using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Hashing;

namespace WindowsFormsApplication1.Controller
{
    public class AdminLoginPresenter
    {
        private AdminLogin view;

        public AdminLoginPresenter(AdminLogin view)
        {
            this.view = view;
        }

        public bool CheckAdmin()
        {
            HumanWorker<Entities.Admin> worker = new HumanWorker<Entities.Admin>("ADMIN.txt");
            List<Entities.Admin> admins = worker.ReadAll();

            var inputPassword = view.getPass();
            var inputLogin = view.getLogin();
            var hashPassword = MD5Hashing.CalculateMD5Hash(inputPassword);

            if(admins.Any(a => a.Login.Equals(inputLogin) && a.Password.Equals(hashPassword)))
            {
                return true;
            }
            return false;
            
        }
    }
}
