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
    public partial class FormOrderRare : Form
    {

        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();


        public FormOrderRare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainCLForm main = new MainCLForm();
            main.Show();   
            this.Close();
        }

        private void FormOrderRare_Load(object sender, EventArgs e)
        {
            fillDataR();
        }

        private void fillDataR()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT id, Наименование, Состояние, `Начальная стоимость` FROM rareinventory WHERE Наличие= 'В наличие'";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewRareOn.DataSource = dt;


        }


        private void reloadtable()
        {
            

            DataTable dt = new DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;

            string sqlR = "SELECT id, Наименование, Состояние, `Начальная стоимость` FROM rareinventory WHERE Наличие= 'В наличие'";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewRareOn.DataSource = dt;



        }






        private void buttonAccpet_Click(object sender, EventArgs e)
        {
            try
            {



                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string id = textBoxId.Text;
                string nameI = textBoxNameItem.Text;
                string coundI = textBoxCound.Text;
                double price = Convert.ToDouble(textBoxPrise.Text);
                string nameU = textBoxNameUser.Text;
                long number = Convert.ToInt64(textBoxNumber.Text);
                int startprice = Convert.ToInt32(textBoxStartPrice.Text);


                if (price > startprice)
                {



                    string sql = "INSERT INTO `orderrare` (id, Наименование, Состояние, Цена, Покупатель, Номер, Начальная) VALUES (@id, @nameI, @coundI, @price, @nameU, @number, @startprice)";

                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        con.Open();
                        MySqlCommand cmd2 = new MySqlCommand(sql, con);
                        //параметр id
                        MySqlParameter idP = new MySqlParameter("@id", id);
                        cmd2.Parameters.Add(idP);
                        // параметр названия товара
                        MySqlParameter nameP = new MySqlParameter("@nameI", nameI);
                        cmd2.Parameters.Add(nameP);
                        // параметр состояния
                        MySqlParameter coundP = new MySqlParameter("@coundI", coundI);
                        cmd2.Parameters.Add(coundP);
                        // параметр цены
                        MySqlParameter priceP = new MySqlParameter("@price", price);
                        cmd2.Parameters.Add(priceP);
                        //параметр покупатель
                        MySqlParameter nameUP = new MySqlParameter("@nameU", nameU);
                        cmd2.Parameters.Add(nameUP);
                        //параметр номер
                        MySqlParameter numberP = new MySqlParameter("@number", number);
                        cmd2.Parameters.Add(numberP);
                        //параметр начальной стоимости
                        MySqlParameter startpriceP = new MySqlParameter("@startprice", startprice);
                        cmd2.Parameters.Add(startpriceP);



                        cmd2.ExecuteNonQuery();


                    }
                    MessageBox.Show("Заявка успешно отправлена!");


                    string update = "UPDATE `rareinventory` SET `Начальная стоимость`=@price WHERE id=@id";


                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        MySqlCommand cmdu = new MySqlCommand(update, con);

                        con.Open();

                        MySqlParameter priceP = new MySqlParameter("@price", price);
                        cmdu.Parameters.Add(priceP);

                        MySqlParameter idP = new MySqlParameter("@id", id);
                        cmdu.Parameters.Add(idP);

                        cmdu.ExecuteNonQuery();




                    }


                    reloadtable();





                }
                else
                {
                    MessageBox.Show("Ваша ставка должна быть выше начальной стоимости");
                }
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }





        }






            private void dataGridViewRareOn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {


                if (dataGridViewRareOn.SelectedRows.Count >= 0)
                {
                    MessageBox.Show("Вы выбрали товар!");

                    textBoxId.Text = dataGridViewRareOn.SelectedRows[0].Cells[0].Value.ToString();
                    textBoxNameItem.Text = dataGridViewRareOn.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxCound.Text = dataGridViewRareOn.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxStartPrice.Text = dataGridViewRareOn.SelectedRows[0].Cells[3].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете только одну строку!");
            }
        }



    }
}
