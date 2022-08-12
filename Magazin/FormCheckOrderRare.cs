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
    public partial class FormCheckOrderRare : Form
    {

        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();

        public FormCheckOrderRare()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        //Обновление
        private void reloadtable()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;

            string sqlR = "SELECT * FROM `orderrare`";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewOrders.DataSource = dt;

        }

        private void FormCheckOrderRare_Load(object sender, EventArgs e)
        {
            fillDataR();
        }


        private void fillDataR()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM `orderrare`";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewOrders.DataSource = dt;


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Наименование LIKE '%{0}%'", textBoxSearch.Text);

            //bind
            dataGridViewOrders.DataSource = dv;
        }

        private void dataGridViewOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {


                if (dataGridViewOrders.SelectedRows.Count >= 0)
                {
                    MessageBox.Show("Вы выбрали заявку");
                    textBoxId.Text = dataGridViewOrders.SelectedRows[0].Cells[0].Value.ToString();
                    textBoxNameI.Text = dataGridViewOrders.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxCond.Text = dataGridViewOrders.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxPrice.Text = dataGridViewOrders.SelectedRows[0].Cells[3].Value.ToString();
                    textBoxSaler.Text = dataGridViewOrders.SelectedRows[0].Cells[4].Value.ToString();
                    textBoxNumber.Text = dataGridViewOrders.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете только одну строку!");
            }
        }

        private void accept()
        {

            String connnection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

            int id = Convert.ToInt32(textBoxId.Text);
            string nameI = textBoxNameI.Text;
            string condI = textBoxCond.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            string saler = textBoxSaler.Text;
            long number = Convert.ToInt64(textBoxNumber.Text);

            string accept = "INSERT INTO `orderacrare` (id, Наименование, Состояние, Цена, Покупатель, Номер) VALUES (@id, @name, @cond, @price, @saler, @number)";
            using (MySqlConnection con = new MySqlConnection(connnection))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(accept, con);

                //параметр id
                MySqlParameter idP = new MySqlParameter("@id", id);
                cmd.Parameters.Add(idP);
                //параметр наименования товара
                MySqlParameter nameP = new MySqlParameter("@name", nameI);
                cmd.Parameters.Add(nameP);
                // параметр состояния
                MySqlParameter condP = new MySqlParameter("@cond", condI);
                cmd.Parameters.Add(condP);
                // параметр цены
                MySqlParameter priceP = new MySqlParameter("@price", price);
                cmd.Parameters.Add(priceP);
                // параметр покупателя
                MySqlParameter salerP = new MySqlParameter("@saler", saler);
                cmd.Parameters.Add(salerP);
                //параметр номера
                MySqlParameter numberP = new MySqlParameter("@number", number);
                cmd.Parameters.Add(numberP);




                cmd.ExecuteNonQuery();

            }

        }

        private void update()
        {




            int id = Convert.ToInt32(textBoxId.Text);
            string avail = "Продан";

            string update = "UPDATE rareinventory SET Наличие=@avail WHERE id=@id";
            using (MySqlConnection con = new MySqlConnection(constr))
            {

                con.Open();
                MySqlCommand cmdU = new MySqlCommand(update, con);

                MySqlParameter idP = new MySqlParameter("@id", id);
                cmdU.Parameters.Add(idP);

                MySqlParameter availP = new MySqlParameter("@avail", avail);
                cmdU.Parameters.Add(availP);






                cmdU.ExecuteNonQuery();

            }



        }

        private void deletefrom()
        {

            int id = Convert.ToInt32(textBoxId.Text);
            string delete = "DELETE FROM `orderrare` WHERE id=@id";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();

                MySqlCommand cmdd = new MySqlCommand(delete, con);

                MySqlParameter idP = new MySqlParameter("@id", id);
                cmdd.Parameters.Add(idP);


                cmdd.ExecuteNonQuery();


            }


            reloadtable();



        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {


                accept();
                update();
                deletefrom();
                MessageBox.Show("Победитель выбран!");
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }
        }
    }
}
