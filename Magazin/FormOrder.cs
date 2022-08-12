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
    public partial class FormOrder : Form
    {
        //Присоединение
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);



        public FormOrder()
        {
            InitializeComponent();
        }

        //Отмена
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainCLForm cl = new MainCLForm();
            cl.Show();
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {


                String connnection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
                string name = textBoxNameItem.Text;
                int count = Convert.ToInt32(textBoxPriceItem.Text);
                int price = Convert.ToInt32(textBoxPriceItem.Text);
                string saler = textBoxNameSaler.Text;

                string sql = "INSERT INTO `order` (Наименование, Количество, Стоимость, Поставщик) VALUES (@nameitem, @count, @price, @namesaler)";
                using (MySqlConnection con = new MySqlConnection(connnection))
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
                    MySqlParameter priceI = new MySqlParameter("@price", price);
                    cmd.Parameters.Add(priceI);
                    // параметр продавца
                    MySqlParameter salerI = new MySqlParameter("@namesaler", saler);
                    cmd.Parameters.Add(salerI);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Ваша заявка успешно отправлена!");
                MainCLForm maincl = new MainCLForm();
                maincl.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }
        }
    }
}
