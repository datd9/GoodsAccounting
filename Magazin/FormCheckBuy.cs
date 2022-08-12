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
    public partial class FormCheckBuy : Form
    {
        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();





        public FormCheckBuy()
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

            string sqlR = "SELECT * FROM `orderbuy`";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewOrderBuy.DataSource = dt;

        }

        private void FormCheckBuy_Load(object sender, EventArgs e)
        {
            fillData();
        }


        private void fillData()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM `orderbuy`";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewOrderBuy.DataSource = dt;

        }

        private void dataGridViewOrderBuy_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {


                if (dataGridViewOrderBuy.SelectedRows.Count >= 0)
                {
                    MessageBox.Show("Вы выбрали заказ");
                    textBoxNameI.Text = dataGridViewOrderBuy.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxCount.Text = dataGridViewOrderBuy.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxArt.Text = dataGridViewOrderBuy.SelectedRows[0].Cells[3].Value.ToString();
                    textBoxNumber.Text = dataGridViewOrderBuy.SelectedRows[0].Cells[4].Value.ToString();
                    textBoxAll.Text = dataGridViewOrderBuy.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете только одну строку!");
            }
        }


        //Метод занесения в таблицу принятых заказов
        private void accept()
        {
            try
            {



                String connnection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewOrderBuy.CurrentRow.Cells["id"].Value.ToString();
                string name = textBoxNameI.Text;
                int count = Convert.ToInt32(textBoxCount.Text);
                string art = textBoxArt.Text;
                long number = Convert.ToInt64(textBoxNumber.Text);
                int all = Convert.ToInt32(textBoxAll.Text);


                string accept = "INSERT INTO `orderaccept` (Наименование, Количество, Артикул, Номер) VALUES (@name, @count, @art, @number)";
                using (MySqlConnection con = new MySqlConnection(connnection))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(accept, con);
                    //параметр имени
                    MySqlParameter nameP = new MySqlParameter("@name", name);
                    cmd.Parameters.Add(nameP);
                    // параметр количества
                    MySqlParameter countP = new MySqlParameter("@count", count);
                    cmd.Parameters.Add(countP);
                    // параметр артикула
                    MySqlParameter artP = new MySqlParameter("@art", art);
                    cmd.Parameters.Add(artP);
                    // параметр номера
                    MySqlParameter numberP = new MySqlParameter("@number", number);
                    cmd.Parameters.Add(numberP);




                    cmd.ExecuteNonQuery();

                }
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }

        }

        //Обновление количества
        private void update()
        {
            try
            {



                int all = Convert.ToInt32(textBoxAll.Text);
                int count = Convert.ToInt32(textBoxCount.Text);
                string art = textBoxArt.Text;

                string update = "UPDATE inventory SET Количество=@all - @count WHERE Артикул=@art";
                using (MySqlConnection con = new MySqlConnection(constr))
                {

                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(update, con);
                    //параметр общего
                    MySqlParameter allU = new MySqlParameter("@all", all);
                    cmd2.Parameters.Add(allU);
                    //параметр количества
                    MySqlParameter countU = new MySqlParameter("@count", count);
                    cmd2.Parameters.Add(countU);
                    //параметр артикула
                    MySqlParameter artU = new MySqlParameter("@art", art);
                    cmd2.Parameters.Add(artU);

                    cmd2.ExecuteNonQuery();



                }
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }


        }

        //Удаление
        private void delete()
        {
            try
            {



                string selectedid = dataGridViewOrderBuy.CurrentRow.Cells["id"].Value.ToString();

                string delete = "DELETE FROM `orderbuy` WHERE id= " + selectedid;

                using (MySqlConnection con = new MySqlConnection(constr))
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

        private void buttonAcc_Click(object sender, EventArgs e)
        {
            accept();
            update();
            delete();
            MessageBox.Show("Заявка принята!");
        }
    }
}
