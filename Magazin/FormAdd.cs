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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();

            // Подключение к БД
            String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * From inventory", con);
            DataSet ds_store = new DataSet("store");
            data.Fill(ds_store, "inventory");
            DataTable table;
            table = ds_store.Tables["inventory"];
            DataRow row;
            row = table.Rows[0];


            //Заполнение наличия
            string sqlcondition = "SELECT * FROM status";
            MySqlCommand sqlcond = new MySqlCommand(sqlcondition, con);
            MySqlDataAdapter cond = new MySqlDataAdapter(sqlcond);
            DataTable dt = new DataTable();
            cond.Fill(dt);
            comboBoxAvail.DataSource = dt;
            comboBoxAvail.DisplayMember = "statusitem";

            con.Close();


        }

        private void buttonCanc_Click(object sender, EventArgs e)
        {
            FormBuy buy = new FormBuy();
            buy.Show();
            this.Hide();
        }

        //Добавление
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {

            
            String connnection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
            string name = textBoxNamei.Text;
            int count = Convert.ToInt32(textBoxCounti.Text);

            //Наценка
            int price = Convert.ToInt32(textBoxPricei.Text);
            string status = comboBoxAvail.Text;
            string art = textBoxArtic.Text;
            string saler = textBoxSaler.Text;

            string sql = "INSERT INTO inventory (Наименование, Количество, Стоимость, Наличие, Артикул, Продавец) VALUES (@name, @count, @price, @status, @art, @saler)";
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
                MySqlParameter priceP = new MySqlParameter("@price", price);
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
            MessageBox.Show("Данные добавлены!");
            FormBuy buy = new FormBuy();
            buy.Show();
            this.Hide();

            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }

        }


    }
    
}
