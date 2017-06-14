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
using WindowsFormsApplication1.CRUD;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1
{
    public partial class RandomNumber : Form, IViewLogin
    {
        private RandomNumberPresenter presenter;

        private int currentNumber;
        public RandomNumber()
        {
            InitializeComponent();
            ContinueFlag = false;
            presenter = new RandomNumberPresenter(this);
        }

        public bool ContinueFlag { get; set; }
      

        public DateTime CurrentTime { get; set; }
        

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
            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Control)
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

        private void RandomNumber_Load(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            this.KeyDown += Form_KeyDown;
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void generateNumber_Click(object sender, EventArgs e)
        {
            currentNumber = presenter.GenerateRandomNumber();
            this.randNumber.Text = currentNumber.ToString();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if (!presenter.CkeckNumber())         
                return;

            CRUDBuilder builder = new CRUDBuilder();
            var instance = builder.GetCRUDByLogin(login.Text);

            Human human = instance.GetByLogin(login.Text);
            Form form = null;

            if (human.GetType() == typeof(User))
                form = new UserPage(human as Entities.User);
            else
                form = new AdminPage(human as Entities.Admin);

            this.Hide();
            form.ShowDialog();
            ContinueFlag = true;
            this.Close();


        }

        public string getLogin()
        {
            return this.login.Text;
        }

        public string getSpecialNumber()
        {
            return this.userNumber.Text;
        }

        public string getRandNumber()
        {
            return this.randNumber.Text;
        }
    }
}
