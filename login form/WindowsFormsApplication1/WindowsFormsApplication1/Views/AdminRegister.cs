using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;

namespace WindowsFormsApplication1.Views
{
    public partial class AdminRegister : Form
    {
        private AdminRegisterPresenter presenter;
        public AdminRegister()
        {
            InitializeComponent();
            presenter = new AdminRegisterPresenter(this);
            this.pass.PasswordChar = '*';
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (presenter.RegisterAdmin())
            {
                this.Close();
            }
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(AdminRegister_FormClosing);
        }

        private void AdminRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists("ADMIN.txt"))
            {
                Application.Exit();
            }
        }
    }
}
