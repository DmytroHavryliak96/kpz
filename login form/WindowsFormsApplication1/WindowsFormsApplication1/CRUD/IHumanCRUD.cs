using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.CRUD
{
    public interface IHumanCRUD
    {
        Human GetByLogin(string login);

        Human GetByPass(string pass);
        void addHuman(Human human);
    }
}
