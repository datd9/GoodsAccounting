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
    public partial class FormOrderBuy : Form
    {
        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();

        public FormOrderBuy()
        {
            InitializeComponent();
        }

        //Назад
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainCLForm clform = new MainCLForm();
            clform.Show();
            this.Hide();
        }

        //Обновление обычных
        private void reloadtableOrd()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;

            string sqlR = "SELECT id, Наименование, Количество, Артикул FROM inventory WHERE Наличие= 'В наличие'";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewOrdOn.DataSource = dt;

        }

        private void FormOrderBuy_Load(object sender, EventArgs e)
        {
            fillData();
        }

        //Заполнение dgv
        private void fillData()
        {

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;

            string sql2 = "SELECT id, Наименование, Количество, Артикул FROM inventory WHERE Наличие= 'В наличие'";
            cmd = new MySqlCommand(sql2, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewOrdOn.DataSource = dt;

        }

        //Поиск
        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Наименование LIKE '%{0}%'", textBoxSearch2.Text);

            //bind
            dataGridViewOrdOn.DataSource = dv;


        }

        //Выбор товара
        private void dataGridViewOrdOn_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //

            try
            {


                if (dataGridViewOrdOn.SelectedRows.Count >= 0)
                {
                    MessageBox.Show("Вы выбрали товар!");
                    textBoxNameI.Text = dataGridViewOrdOn.SelectedRows[0].Cells[1].Value.ToString();
                   
                    textBoxCountCheck.Text = dataGridViewOrdOn.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxArt.Text = dataGridViewOrdOn.SelectedRows[0].Cells[3].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете только один товар!");
            }

        }

        //Оформление заявки
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {


                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewOrdOn.CurrentRow.Cells["id"].Value.ToString();

                string name = textBoxNameI.Text;
                int count = Convert.ToInt32(textBoxCount.Text);
                string art = textBoxArt.Text;
                int countcheck = Convert.ToInt32(textBoxCountCheck.Text);
                long number = Convert.ToInt64(textBoxNumber.Text);

                if (count <= countcheck)
                {
                    if (count > 0)
                    {
                        string sql = "INSERT INTO `orderbuy` (Наименование, Количество, Артикул, Номер, Общее) VALUES (@nameitem, @count, @art, @number, @obsh)";
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {

                            con.Open();
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            //параметр наименования товара
                            MySqlParameter nameI = new MySqlParameter("@nameitem", name);
                            cmd.Parameters.Add(nameI);
                            // параметр количества
                            MySqlParameter countI = new MySqlParameter("@count", count);
                            cmd.Parameters.Add(countI);
                            // параметр цены
                            MySqlParameter artI = new MySqlParameter("@art", art);
                            cmd.Parameters.Add(artI);
                            // параметр номера телефона
                            MySqlParameter numberI = new MySqlParameter("@number", number);
                            cmd.Parameters.Add(numberI);
                            // параметр общего количества
                            MySqlParameter obsh = new MySqlParameter("@obsh", countcheck);
                            cmd.Parameters.Add(obsh);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Ваш заказ успешно отправлен!");
                    }
                    else
                    {
                        MessageBox.Show("Введите верное количество товара!");
                    }


                }

                else
                {

                    MessageBox.Show("У нас нет столько товара, выберите верное количество!");

                }
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }


        }
    }
}
