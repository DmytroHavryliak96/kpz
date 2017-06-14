using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controller;

namespace WindowsFormsApplication1.Views
{
    public partial class ChooseAdmin : Form
    {
        private ChooseAdminPresenter presenter;
        public ChooseAdmin()
        {
            InitializeComponent();
            presenter = new ChooseAdminPresenter(this);
        }

        public Panel getContainer()
        {
            return this.container;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.SetType();
            this.Close();
        }
    }
}
