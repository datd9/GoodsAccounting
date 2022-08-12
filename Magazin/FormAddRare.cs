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
    public partial class FormAddRare : Form
    {
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        


        public FormAddRare()
        {
            InitializeComponent();

            //Заполнение качества
            string sqlcondition = "SELECT * FROM conditions";
            MySqlCommand sqlcond = new MySqlCommand(sqlcondition, con);
            con.Open();
            MySqlDataAdapter cond = new MySqlDataAdapter(sqlcond);
            DataTable dt = new DataTable();
            cond.Fill(dt);
            comboBoxCondition.DataSource = dt;
            comboBoxCondition.DisplayMember = "NameOfConditions";

            //Заполнение статуса
            string sqlstatus = "SELECT * FROM status";
            MySqlCommand sqlstat = new MySqlCommand(sqlstatus, con);
            MySqlDataAdapter stat = new MySqlDataAdapter(sqlstat);
            DataTable dt2 = new DataTable();
            stat.Fill(dt2);
            comboBoxStatus.DataSource = dt2;
            comboBoxStatus.DisplayMember = "statusitem";


        }

        //Назад
        private void buttonCancelR_Click(object sender, EventArgs e)
        {
            FormRare formRare = new FormRare();
            formRare.Show();
            this.Close();
        }

        private void buttonOkR_Click(object sender, EventArgs e)
        {
            try
            {



                String connnection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
                string nameR = textBoxNameR.Text;
                string cond = comboBoxCondition.Text;
                int startprice = Convert.ToInt32(textBoxPriceR.Text);
                string status = comboBoxStatus.Text;

                string sql = "INSERT INTO rareinventory (Наименование, Состояние, `Начальная стоимость`, Наличие) VALUES (@nameR, @cond, @startprice, @status)";
                using (MySqlConnection con = new MySqlConnection(connnection))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //параметр имени
                    MySqlParameter name = new MySqlParameter("@nameR", nameR);
                    cmd.Parameters.Add(name);
                    // параметр качества
                    MySqlParameter condR = new MySqlParameter("@cond", cond);
                    cmd.Parameters.Add(condR);
                    // параметр цены
                    MySqlParameter priceR = new MySqlParameter("@startprice", startprice);
                    cmd.Parameters.Add(priceR);
                    // параметр статуса
                    MySqlParameter statusR = new MySqlParameter("@status", status);
                    cmd.Parameters.Add(statusR);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Данные добавлены!");
                FormRare formRare = new FormRare();
                formRare.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }
        }    
    }
}
