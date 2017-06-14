using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entities
{
    public class Admin : Human
    {
        public Admin()
        {
            DefaultPermissions = Permissions.Admin;
        }

        
    }
}
