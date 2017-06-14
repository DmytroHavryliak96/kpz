using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.CRUD
{
    public class AdminCrud : IHumanCRUD
    {
        public void addHuman(Human human)
        {
            throw new NotImplementedException();
        }

        public Human GetByLogin(string login)
        {
            HumanWorker<Entities.Admin> worker = new HumanWorker<Entities.Admin>("ADMIN.txt");
            List<Entities.Admin> admins = worker.ReadAll();

            var admin = admins.FirstOrDefault(a => a.Login.Equals(login));
            return admin;

        }

        public Human GetByPass(string pass)
        {
            throw new NotImplementedException();
        }
    }
}
