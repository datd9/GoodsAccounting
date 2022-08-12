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
    public partial class FormCheckOrder : Form
    {

        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();

        public FormCheckOrder()
        {
            InitializeComponent();
        }

        //Назад
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

            string sqlR = "SELECT * FROM `order`";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewOrders.DataSource = dt;

        }

        //Загрузка
        private void FormCheckOrder_Load(object sender, EventArgs e)
        {
            fillDataR();
        }

        private void fillDataR()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM `order`";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewOrders.DataSource = dt;

        }

        //Выбор и заполнение
        private void dataGridViewOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            { 
            
            if (dataGridViewOrders.SelectedRows.Count >= 0)
            {
                MessageBox.Show("Вы выбрали заявку!");
                textBoxNameItem.Text = dataGridViewOrders.SelectedRows[0].Cells[1].Value.ToString();
                textBoxCountItem.Text = dataGridViewOrders.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPriceItem.Text = dataGridViewOrders.SelectedRows[0].Cells[3].Value.ToString();
                textBoxNameSaler.Text = dataGridViewOrders.SelectedRows[0].Cells[4].Value.ToString();
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете только одну строку!");
            }

        }

        //

        private void delete()
        {

            try
            {

                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewOrders.CurrentRow.Cells["id"].Value.ToString();

                string delete = "DELETE FROM `order` WHERE id= " + selectedid;

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(delete, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
                reloadtable();
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }

        }

        //Внесение в таблицу товаров
        private void buttonEnterOrd_Click(object sender, EventArgs e)
        {
            try
            {

            String connnection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

            string name = textBoxNameItem.Text;
            int count = Convert.ToInt32(textBoxCountItem.Text);

            //Наценка
            double price = Convert.ToInt32(textBoxPriceItem.Text);
            double pricePLUS = price * 1.3;

            string status = "Товар ожидается";

            //Артикул
            //Создание объекта случайного класса
            Random rand = new Random();

            int stringlen = rand.Next(4, 10);
            int randValue;
            string str = "";
            char letter;

            for (int i = 0; i < stringlen; i++)
            {
                //Создание случайного числа
                randValue = rand.Next(0, 26);

                //Генерация случайного символа путем преобразования
                //Случайное число в символ
                letter = Convert.ToChar(randValue + 65);
                str = str + letter;
            }
            string artstr = str;

            //Проверка на оригинальность
            con.Open();
            string sql2 = "SELECT COUNT(id) FROM inventory WHERE Артикул=@art";
            MySqlCommand check = new MySqlCommand(sql2, con);
            MySqlParameter checkart = new MySqlParameter("@art", artstr);
            check.Parameters.Add(checkart);
            MySqlDataReader reader = check.ExecuteReader();
            if (reader.HasRows) ;
            string art = artstr;
            con.Close();

            //Продавец
            string saler = textBoxNameSaler.Text;

            string sql = "INSERT INTO inventory (Наименование, Количество, Стоимость, Наличие, Артикул, Продавец) VALUES (@name, @count, @priceplus, @status, @art, @saler)";
            using (MySqlConnection con = new MySqlConnection(connnection))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //параметр имени
                MySqlParameter nameP = new MySqlParameter("@name", name);
                cmd.Parameters.Add(nameP);
                // параметр количества
                MySqlParameter countP = new MySqlParameter("@count", count);
                cmd.Parameters.Add(countP);
                // параметр цены
                MySqlParameter priceP = new MySqlParameter("@priceplus", pricePLUS);
                cmd.Parameters.Add(priceP);
                // параметр статуса
                MySqlParameter statusP = new MySqlParameter("@status", status);
                cmd.Parameters.Add(statusP);
                // параметр артикула
                MySqlParameter artP = new MySqlParameter("@art", art);
                cmd.Parameters.Add(artP);
                // параметр продавца
                MySqlParameter salerP = new MySqlParameter("@saler", saler);
                cmd.Parameters.Add(salerP);



                cmd.ExecuteNonQuery();

            }
            MessageBox.Show("Заявка одобрена!");
            delete();
            reloadtable();
        }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }

        }
    }
}
