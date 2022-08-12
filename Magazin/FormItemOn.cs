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
using Excel = Microsoft.Office.Interop.Excel;

namespace Magazin
{
    public partial class FormItemOn : Form
    {
        //Строка соединения аукционных
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();

        //обычных
        DataTable dt2= new DataTable();


        public FormItemOn()
        {
            InitializeComponent();
        }

        //Выход
        private void buttonEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Назад
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        //Обновление аукционных
        private void reloadtableRAre()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;

            string sqlR = "SELECT Наименование, Состояние FROM rareinventory WHERE Наличие= 'В наличие'";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewRareOn.DataSource = dt;

        }

        //Обновление обычных
        private void reloadtableOrd()
        {
            DataTable dt2 = new DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand cmdR;

            string sqlR = "SELECT Наименование, Количество, Артикул, Продавец FROM inventory WHERE Наличие= 'В наличие'";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt2);
            dataGridViewOrdOn.DataSource = dt2;

        }

        //Загрузка
        private void FormItemOn_Load(object sender, EventArgs e)
        {
            fillDataR();
            //filldata();
        }

        //Заполнение
        private void fillDataR()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT Наименование, Состояние FROM rareinventory WHERE Наличие= 'В наличие'";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewRareOn.DataSource = dt;

            //sql
            string sql2 = "SELECT Наименование, Количество, Артикул, Продавец FROM inventory WHERE Наличие= 'В наличие'";
            cmd = new MySqlCommand(sql2, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt2);

            //bind dgv
            dataGridViewOrdOn.DataSource = dt2;


        }

        //Поиск по аукционным
        private void textBoxSearch1_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Наименование LIKE '%{0}%'", textBoxSearch1.Text);

            //bind
            dataGridViewRareOn.DataSource = dv;

        }

        //Поиск по обычным
        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt2);
            dv.RowFilter = string.Format("Наименование LIKE '%{0}%'", textBoxSearch2.Text);

            //bind
            dataGridViewOrdOn.DataSource = dv;



        }

        //Эксплорт аукционных
        private void buttonExR_Click(object sender, EventArgs e)
        {

            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewRareOn.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridViewRareOn.ColumnCount - 1; j++)
                {
                    ws.Cells[1, j + 1] = dataGridViewRareOn.Columns[j].HeaderText.ToString();

                    ws.Cells[i + 2, j + 1] = dataGridViewRareOn[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;

        }

        //Экспорт обычных
        private void buttonExp2_Click(object sender, EventArgs e)
        {

            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewOrdOn.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridViewOrdOn.ColumnCount - 1; j++)
                {
                    ws.Cells[1, j + 1] = dataGridViewOrdOn.Columns[j].HeaderText.ToString();

                    ws.Cells[i + 2, j + 1] = dataGridViewOrdOn[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;

        }
    }
}
