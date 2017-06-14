using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Views
{
    public partial class AdminPage : Form
    {
        private Entities.Admin admin;
        public AdminPage(Entities.Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.credentials.Text = admin.FirstName + ", " + admin.LastName;
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
