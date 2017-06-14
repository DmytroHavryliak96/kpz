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
using WindowsFormsApplication1.CRUD;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1
{
    public partial class MainLogin : Form, IViewLogin
    {
        private MainLoginPresenter presenter;
        public bool ContinueFlag {get; set;}
        public MainLogin()
        {
            InitializeComponent();
            ContinueFlag = false;
            presenter = new MainLoginPresenter(this);
            this.pass.PasswordChar = '*';
        }

        public DateTime CurrentTime{ get; set; }

        public DateTime StartTime { get; set; }

        public bool CheckTime()
        {
            TimeSpan ts = CurrentTime - StartTime;
            int sec = ts.Seconds;
            if (sec <= 15)
                return true;
            return false;
        }

        public void Form_KeyDown(object sender, KeyEventArgs e)
        {
            CurrentTime = DateTime.Now;
            if ( e.KeyCode == Keys.Up && e.Modifiers == Keys.Control)
            {
               
                if (CheckTime())
                {
                    Form form = new AdminLogin();
                    form.ShowDialog();
                    ContinueFlag = true;
                    this.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string getLogin()
        {
            return this.login.Text;
        }

        public string getPassword()
        {
            return this.pass.Text;
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            this.KeyDown += Form_KeyDown;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(!presenter.CheckUserInput(this.pass.Text, login.Text))
                return;
            

            if (presenter.CheckAdmin())
            {
                CRUDBuilder builder = new CRUDBuilder();
                var instance = builder.GetCRUD("admin");
                Human human = instance.GetByLogin(this.login.Text);
                this.Hide();
                Form form = new AdminPage(human as Entities.Admin);
                form.ShowDialog();
                ContinueFlag = true;
                this.Close();
            }

            if (presenter.CheckUser())
            {
                CRUDBuilder builder = new CRUDBuilder();
                var instance = builder.GetCRUD("user");
                Human human = instance.GetByLogin(this.login.Text);
                this.Hide();
                Form form = new UserPage(human as User);
                form.ShowDialog();
                ContinueFlag = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password or login");
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
