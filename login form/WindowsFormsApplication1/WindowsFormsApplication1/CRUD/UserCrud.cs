using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.CRUD
{
    public class UserCrud : IHumanCRUD
    {
        public void addHuman(Human human)
        {
            HumanWorker<User> worker = new HumanWorker<User>("USER.txt");
            List<User> users = worker.ReadAll();

            users.Add(human as User);

            worker.Write(users);
        }

        public Human GetByLogin(string login)
        {
            HumanWorker<User> worker = new HumanWorker<User>("USER.txt");
            List<User> users = worker.ReadAll();

            var user = users.FirstOrDefault(u => u.Login.Equals(login));
            return user;
        }

        public Human GetByPass(string pass)
        {
            HumanWorker<User> worker = new HumanWorker<User>("USER.txt");
            List<User> users = worker.ReadAll();

            var user = users.FirstOrDefault(u => u.Password.Equals(pass));
            return user;
        }
    }
}
