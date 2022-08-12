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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Подключение к БД
            String connection = "Database=store;server=localhost;User Id=root;Password=Sql123456789";
            MySqlConnection con = new MySqlConnection(connection);


            // Заполнение поля

            
            con.Close();

        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            FormBuy b = new FormBuy();
            b.Show();
            this.Hide();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRare_Click(object sender, EventArgs e)
        {
            FormRare rare = new FormRare();
            rare.Show();
            this.Hide();
        }

        //Товары в наличие
        private void buttonItemOn_Click(object sender, EventArgs e)
        {
            FormItemOn itemon = new FormItemOn();
            itemon.Show();
            this.Hide();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormCheckOrder orders = new FormCheckOrder();
            orders.Show();
            this.Close();
        }

        //Списанный
        private void buttonWrittenOf_Click(object sender, EventArgs e)
        {
            FormWrittenOf written = new FormWrittenOf();
            written.Show();
            this.Close();
        }

        private void buttonCheckOrdBuy_Click(object sender, EventArgs e)
        {
            FormCheckBuy check = new FormCheckBuy();
            check.Show();
            this.Close();
        }

        private void buttonAccOrdBuy_Click(object sender, EventArgs e)
        {
            FormAcceptOrderBuy accept = new FormAcceptOrderBuy();
            accept.Show();
            this.Close ();
        }

        private void buttonAucOrd_Click(object sender, EventArgs e)
        {
            FormCheckOrderRare checkrare = new FormCheckOrderRare();
            checkrare.Show();
            this.Close();
        }

        private void buttonChowAcAuc_Click(object sender, EventArgs e)
        {
            FormAccRare accrare = new FormAccRare();
            accrare.Show();
            this.Close();
        }
    }
}
