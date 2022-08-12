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
    public partial class FormWrittenOf : Form
    {
        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();



        public FormWrittenOf()
        {
            InitializeComponent();
            fillData();
            fillExc();


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

            string sqlR = "SELECT * FROM writtenofinventory";
            cmdR = new MySqlCommand(sqlR, con);
            adapterR.SelectCommand = cmdR;

            adapterR.Fill(dt);
            dataGridViewWrittenOf.DataSource = dt;

        }

        private void FormWrittenOf_Load(object sender, EventArgs e)
        {
            fillData();
        }

        //Заполнение
        private void fillData()
        {

            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM writtenofinventory";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewWrittenOf.DataSource = dt;

        }


        //Excel
        public void fillExc()
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewWrittenOf.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridViewWrittenOf.ColumnCount - 1; j++)
                {
                    ws.Cells[1, j + 1] = dataGridViewWrittenOf.Columns[j].HeaderText.ToString();

                    ws.Cells[i + 2, j + 1] = dataGridViewWrittenOf[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;
        }





    }
}
