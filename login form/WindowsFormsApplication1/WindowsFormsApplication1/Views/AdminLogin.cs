using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1
{
    public partial class AdminLogin : Form
    {
        private AdminLoginPresenter presenter;
        public AdminLogin()
        {
            InitializeComponent();
            presenter = new AdminLoginPresenter(this);
            this.pass.PasswordChar = '*';
        }

        public string getLogin()
        {
            return this.login.Text;
        }

        public string getPass()
        {
            return this.pass.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (presenter.CheckAdmin())
            {
                this.Hide();
                Form form = new ChooseAdmin();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("There is no admin with current login and password");
            }
                
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
