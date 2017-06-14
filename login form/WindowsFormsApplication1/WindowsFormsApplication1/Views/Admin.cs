using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.CRUD;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Views;

namespace WindowsFormsApplication1
{
    public partial class Admin : Form, IViewLogin
    {
        public Admin()
        {
            InitializeComponent();
            ContinueFlag = false;
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

        private void Admin_Load(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            this.KeyDown += Form_KeyDown;
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            HumanWorker<Entities.Admin> worker = new HumanWorker<Entities.Admin>("ADMIN.txt");
            List<Entities.Admin> admins = worker.ReadAll();

            Human human = admins.First();
            this.Hide();

            Form form = new AdminPage(human as Entities.Admin);
            form.ShowDialog();
            ContinueFlag = true;
            this.Close();
        }
    }
}
