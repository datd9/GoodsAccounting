using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Magazin
{
    public partial class MainCLForm : Form
    {
        public MainCLForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Close();
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOrd_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder();
            order.Show();
            this.Close();
        }

        private void buttonOpenInv_Click(object sender, EventArgs e)
        {
            FormOrderBuy buy = new FormOrderBuy();
            buy.Show();
            this.Close();
        }

        private void buttonAuc_Click(object sender, EventArgs e)
        {
            FormOrderRare rare = new FormOrderRare();
            rare.Show();
            this.Close();
        }
    }
}
