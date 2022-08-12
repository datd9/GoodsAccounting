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

namespace Magazin
{
    public partial class FormRare : Form
    {
        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        SD.DataTable dt = new SD.DataTable();

        public FormRare()
        {
            InitializeComponent();

        }

        //Обновление
        private void reloadtableR()
        {
            SD.DataTable dt = new SD.DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;

            string sqlR = "SELECT * FROM rareinventory";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewRare.DataSource = dt;
        }

        //Загрузка
        private void FormRare_Load(object sender, EventArgs e)
        {
            fillDataR();
        }


        //Заполнение
        private void fillDataR()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM rareinventory";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewRare.DataSource = dt;

        }

        //Добавить
        private void buttonAddR_Click(object sender, EventArgs e)
        {
            FormAddRare addR = new FormAddRare();
            addR.Show();
            this.Close();
        }

        //Удаление
        private void buttonDelR_Click(object sender, EventArgs e)
        {

            String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

            string selectedid = dataGridViewRare.CurrentRow.Cells["id"].Value.ToString();

            string delete = "DELETE FROM rareinventory WHERE id= " + selectedid;

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            reloadtableR();

        }

        //Назад
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        //Поиск по наименованию
        private void textBoxS_TextChanged_1(object sender, EventArgs e)
        {
            SD.DataView dv = new SD.DataView(dt);
            dv.RowFilter = string.Format("Наименование LIKE '%{0}%'", textBoxS.Text);

            //bind
            dataGridViewRare.DataSource = dv;

        }

        //Поиск по состоянию
        private void textBoxSC_TextChanged(object sender, EventArgs e)
        {

            SD.DataView dv = new SD.DataView(dt);
            dv.RowFilter = string.Format("Состояние LIKE '%{0}%'", textBoxSC.Text);

            //bind
            dataGridViewRare.DataSource = dv;


        }

        //Экспорт редких товаров
        private void buttonExp_Click(object sender, EventArgs e)
        {

            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewRare.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridViewRare.ColumnCount - 1; j++)
                {
                    ws.Cells[1, j + 1] = dataGridViewRare.Columns[j].HeaderText.ToString();

                    ws.Cells[i + 2, j + 1] = dataGridViewRare[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;

        }




        //Обновление строки
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {




                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";

                string selectedid = dataGridViewRare.CurrentRow.Cells["id"].Value.ToString();
                string nameI = textBoxNameItem.Text;
                string cond = textBoxCond.Text;
                int startprice = Convert.ToInt32(textBoxStartPrice.Text);
                string avail = textBoxAvail.Text;


                string update = "UPDATE rareinventory SET Наименование=@nameI, Состояние=@cond, `Начальная стоимость`=@startprice, Наличие=@avail WHERE id= " + selectedid;
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(update, con);
                    //параметр имени
                    MySqlParameter nameU = new MySqlParameter("@nameI", nameI);
                    cmd.Parameters.Add(nameU);
                    // параметр состояниея
                    MySqlParameter condU = new MySqlParameter("@cond", cond);
                    cmd.Parameters.Add(condU);
                    // параметр начальной цены
                    MySqlParameter priceU = new MySqlParameter("@startprice", startprice);
                    cmd.Parameters.Add(priceU);
                    // параметр статуса
                    MySqlParameter availU = new MySqlParameter("@avail", avail);
                    cmd.Parameters.Add(availU);





                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Данные успешно изменены!");
                reloadtableR();
            }
            catch
            {
                MessageBox.Show("Введите верные данные!");
            }




        }

        //Выбор заполнения изменений
        private void dataGridViewRare_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {

                if (dataGridViewRare.SelectedRows.Count >= 0)
                {

                    textBoxNameItem.Text = dataGridViewRare.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxCond.Text = dataGridViewRare.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxStartPrice.Text = dataGridViewRare.SelectedRows[0].Cells[3].Value.ToString();
                    textBoxAvail.Text = dataGridViewRare.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете только одну строку!");
            }
        }
    }
    
}
