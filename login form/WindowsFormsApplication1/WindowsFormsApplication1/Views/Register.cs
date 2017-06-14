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

namespace WindowsFormsApplication1.Views
{
    public partial class Register : Form
    {
        private RegisterPresenter presenter;
        public Register()
        {
            InitializeComponent();
            this.pass.PasswordChar = '*';
            presenter = new RegisterPresenter(this);
        }

        public string getPassword()
        {
            return this.pass.Text;
        }

        public string getLogin()
        {
            return this.login.Text;
        }

        public string getFirstname()
        {
            return this.firstname.Text;
        }
        public string getLastName()
        {
            return this.lastname.Text;
        }

        public string getNumber()
        {
            return this.specialNumber.Text;
        }

        public string getPhone()
        {
            return this.phone.Text;
        }

        private void reg_Click(object sender, EventArgs e)
        {
            presenter.RegisterNewUser();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
