using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1
{
    public partial class UserPage : Form
    {
        private User user;
        public UserPage(User user)
        {
            InitializeComponent();
            this.user = user;
            this.credentials.Text = user.FirstName + ", " + user.LastName;
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
