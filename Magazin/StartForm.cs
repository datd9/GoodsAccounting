using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdm_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void buttonCl_Click(object sender, EventArgs e)
        {
            LoginCLForm clientlog = new LoginCLForm();
            clientlog.Show();
            this.Hide();
        }
    }
}
