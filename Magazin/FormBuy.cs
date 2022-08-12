using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using SL =System.Data.Linq;

namespace Magazin
{
    public partial class FormBuy : Form
    {
        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        SD.DataTable dt = new SD.DataTable();



        public FormBuy()
        {
            InitializeComponent();
            
            //Заполнение качества
            string sqlcondition = "SELECT * FROM conditions";
            MySqlCommand sqlcond = new MySqlCommand(sqlcondition, con);
            con.Open();
            MySqlDataAdapter cond = new MySqlDataAdapter(sqlcond);
            SD.DataTable dt2 = new SD.DataTable();
            cond.Fill(dt2);
            comboBoxCond.DataSource = dt2;
            comboBoxCond.DisplayMember = "NameOfConditions";

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спасибо, что пользуетесь программой." + "\r\n" + " ", " ",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm prof = new MainForm();
            prof.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Обновление
        private void reloadtable()
        {
            reloadtableif();

            SD.DataTable dt = new SD.DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;

            string sqlR = "SELECT * FROM inventory";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewFood.DataSource = dt; 

        }

        //Обновление с условием
        private void reloadtableif()
        {

            String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
            /*SD.DataTable dt = new SD.DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;*/
            

            string availnet = "Нет в наличие";

            string updatenet = "UPDATE inventory SET Наличие=@avail WHERE Количество= '0'";
            using (MySqlConnection c = new MySqlConnection(connection))
            {
                c.Open();
                MySqlCommand cmdnet = new MySqlCommand(updatenet, con);

                MySqlParameter availU = new MySqlParameter("@avail", availnet);
                cmdnet.Parameters.Add(availU);
                cmdnet.ExecuteNonQuery();

            }

            


            /*string sqlR = "SELECT * FROM inventory";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewFood.DataSource = dt;*/







        }





        //Загрузка
        private void FormBuy_Load(object sender, EventArgs e)
        {
            fillData();
            reloadtable();

        }

        //Заполнение
        private void fillData()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM inventory";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewFood.DataSource = dt;

        }

        //Поиск по наименованию
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            SD.DataView dv = new SD.DataView(dt);
            dv.RowFilter = string.Format("Наименование LIKE '%{0}%'", textBoxSearch.Text);

            //bind
            dataGridViewFood.DataSource=dv;

        }

        //Поиск по артикулу
        private void textBoxSearchArt_TextChanged(object sender, EventArgs e)
        {

            SD.DataView dv = new SD.DataView(dt);
            dv.RowFilter = string.Format("Артикул LIKE '%{0}%'", textBoxSearchArt.Text);

            //bind
            dataGridViewFood.DataSource = dv;

        }

        private void FormBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Кнопка добавить
        private void buttonAdditem_Click(object sender, EventArgs e)
        {
            FormAdd addi = new FormAdd();
            addi.Show();
            this.Hide();
        }

        //Удаление
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {


                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewFood.CurrentRow.Cells["id"].Value.ToString();

                string delete = "DELETE FROM inventory WHERE id= " + selectedid;

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(delete, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Данные успешно удалены!");
                reloadtable();
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }

        }

        //Отчетность
        public void fillExc()
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewFood.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridViewFood.ColumnCount - 1; j++)
                {
                    ws.Cells[1, j + 1] = dataGridViewFood.Columns[j].HeaderText.ToString();

                    ws.Cells[i + 2, j + 1] = dataGridViewFood[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;
        }

        //Отчетность по наличию обычных товаров
        private void buttonExport_Click(object sender, EventArgs e)
        {
           
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewFood.RowCount-2; i++)
            {
                for (j = 0; j <= dataGridViewFood.ColumnCount-1; j++)
                {
                    ws.Cells[1, j+1] = dataGridViewFood.Columns[j].HeaderText.ToString();

                    ws.Cells[i+2,j+1] = dataGridViewFood[j,i].Value.ToString();
                }
            }

            exApp.Visible = true;

        }



        //Изменение строки
        private void buttonChange_Click(object sender, EventArgs e)
        {

            try
            {



                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewFood.CurrentRow.Cells["id"].Value.ToString();
                string nameI = textBoxNameItem.Text;
                int count = Convert.ToInt32(textBoxCount.Text);
                double price = Convert.ToDouble(textBoxPriceItem.Text);
                string avail = textBoxAvailItem.Text;
                string saler = textBoxSaler.Text;

                string update = "UPDATE inventory SET Наименование=@nameI, Количество=@count, Стоимость=@price, Наличие=@avail, Продавец=@saler WHERE id= " + selectedid;

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(update, con);
                    //параметр имени
                    MySqlParameter nameU = new MySqlParameter("@nameI", nameI);
                    cmd.Parameters.Add(nameU);
                    // параметр количества
                    MySqlParameter countU = new MySqlParameter("@count", count);
                    cmd.Parameters.Add(countU);
                    // параметр цены
                    MySqlParameter priceU = new MySqlParameter("@price", price);
                    cmd.Parameters.Add(priceU);
                    // параметр статуса
                    MySqlParameter availU = new MySqlParameter("@avail", avail);
                    cmd.Parameters.Add(availU);
                    // параметр продавца
                    MySqlParameter salerU = new MySqlParameter("@saler", saler);
                    cmd.Parameters.Add(salerU);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Данные успешно изменены!");


                reloadtable();
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }

        }

        //Выбор вывода выбранной строки
        private void dataGridViewFood_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {


                if (dataGridViewFood.SelectedRows.Count >= 0)
                {
                    MessageBox.Show("Товар выбран!");
                    textBoxNameItem.Text = dataGridViewFood.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxCount.Text = dataGridViewFood.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxPriceItem.Text = dataGridViewFood.SelectedRows[0].Cells[3].Value.ToString();
                    textBoxAvailItem.Text = dataGridViewFood.SelectedRows[0].Cells[4].Value.ToString();
                    textBoxSaler.Text = dataGridViewFood.SelectedRows[0].Cells[6].Value.ToString();
                    labelabv.Text = dataGridViewFood.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете только одну строку!");
            }
        }

        //Помещение в списаное
        public void writtenof()
        {
            try
            {


                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewFood.CurrentRow.Cells["id"].Value.ToString();
                string nameI = textBoxNameItem.Text;
                int count = Convert.ToInt32(textBoxCount.Text);
                double price = Convert.ToDouble(textBoxPriceItem.Text);
                string avail = "Списан";
                string art = labelabv.Text;
                string saler = textBoxSaler.Text;


                string sql = "INSERT INTO writtenofinventory (Наименование, Стоимость, Наличие, Артикул) VALUES (@nameI, @price, @avail, @art)";

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(sql, con);
                    //параметр имени
                    MySqlParameter nameU = new MySqlParameter("@nameI", nameI);
                    cmd2.Parameters.Add(nameU);
                    // параметр цены
                    MySqlParameter priceU = new MySqlParameter("@price", price);
                    cmd2.Parameters.Add(priceU);
                    // параметр статуса
                    MySqlParameter availU = new MySqlParameter("@avail", avail);
                    cmd2.Parameters.Add(availU);
                    // параметр артикула
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


        //Списание товара
        private void buttonWrittenOf_Click(object sender, EventArgs e)
        {
            try
            {



                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewFood.CurrentRow.Cells["id"].Value.ToString();
                string nameI = textBoxNameItem.Text;
                int count = Convert.ToInt32(textBoxCount.Text);
                double price = Convert.ToDouble(textBoxPriceItem.Text);
                string avail = "Списан";
                string saler = textBoxSaler.Text;

                string update = "UPDATE inventory SET Наименование=@nameI, Количество=@count, Стоимость=@price, Наличие=@avail, Продавец=@saler WHERE id= " + selectedid;

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(update, con);
                    //параметр имени
                    MySqlParameter nameU = new MySqlParameter("@nameI", nameI);
                    cmd.Parameters.Add(nameU);
                    // параметр количества
                    MySqlParameter countU = new MySqlParameter("@count", count);
                    cmd.Parameters.Add(countU);
                    // параметр цены
                    MySqlParameter priceU = new MySqlParameter("@price", price);
                    cmd.Parameters.Add(priceU);
                    // параметр статуса
                    MySqlParameter availU = new MySqlParameter("@avail", avail);
                    cmd.Parameters.Add(availU);
                    // параметр продавца
                    MySqlParameter salerU = new MySqlParameter("@saler", saler);
                    cmd.Parameters.Add(salerU);




                    cmd.ExecuteNonQuery();
                }

                writtenof();
                MessageBox.Show("Товар успешно списан!");
                reloadtable();
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }



        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        //Внесение в аукционные
        private void enterrare()
        {

            try
            {



                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewFood.CurrentRow.Cells["id"].Value.ToString();
                string nameI = textBoxNameItem.Text;
                string cond = comboBoxCond.Text;

                //Начальная стоимость
                double startpriceE = Convert.ToDouble(textBoxPriceItem.Text);
                double startprice = startpriceE * 1.5;

                string avail = "В наличие";

                string sql = "INSERT INTO rareinventory (Наименование, Состояние, `Начальная стоимость`, Наличие) VALUES (@nameI, @cond, @startprice, @avail)";

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(sql, con);
                    //параметр имени
                    MySqlParameter nameU = new MySqlParameter("@nameI", nameI);
                    cmd2.Parameters.Add(nameU);
                    // параметр цены
                    MySqlParameter priceU = new MySqlParameter("@startprice", startprice);
                    cmd2.Parameters.Add(priceU);
                    // параметр статуса
                    MySqlParameter availU = new MySqlParameter("@avail", avail);
                    cmd2.Parameters.Add(availU);
                    // параметр качества
                    MySqlParameter condU = new MySqlParameter("@cond", cond);
                    cmd2.Parameters.Add(condU);

                    cmd2.ExecuteNonQuery();


                }

            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }


        }

        //Помещение товара на аукцион
        private void buttonAuc_Click(object sender, EventArgs e)
        {

            try
            {



                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewFood.CurrentRow.Cells["id"].Value.ToString();


                //Количество
                int countT = Convert.ToInt32(textBoxCount.Text);
                int count = countT - 1;
                if (countT > 0)
                {
                    string update = "UPDATE inventory SET Количество=@count WHERE id= " + selectedid;

                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(update, con);

                        // параметр количества
                        MySqlParameter countU = new MySqlParameter("@count", count);
                        cmd.Parameters.Add(countU);

                        cmd.ExecuteNonQuery();
                    }
                    enterrare();
                    MessageBox.Show("Товар успешно помещен на аукцион!");

                    reloadtable();
                }
                else
                {
                    MessageBox.Show("Товара недостаточно!");
                }

            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }


        }
    }

}


