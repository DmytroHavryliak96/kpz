using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.CRUD
{
    public class CRUDBuilder
    {
        public IHumanCRUD GetCRUDByLogin(string login)
        {
            AdminCrud admin = new AdminCrud();
            if (admin.GetByLogin(login) != null)
                return admin;

            UserCrud user = new UserCrud();
            if (user.GetByLogin(login) != null)
                return user;

            return null;

        }

        public IHumanCRUD GetCRUD(string input)
        {
            switch (input)
            {
                case "admin":
                    return new AdminCrud();

                default:
                    return new UserCrud();
            }
        }
    }
}
