using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entities
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string Phone { get; set; }

        public string SpecialNumber { get; set; }
       
        public Permissions DefaultPermissions { get; set; }
    }
}

