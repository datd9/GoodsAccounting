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
    public partial class FormAccRare : Form
    {

        //Строка соединения
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();


        public FormAccRare()
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

        private void FormAccRare_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void fillData()
        {
            //Инициализация
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM `orderacrare`";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewAccAuc.DataSource = dt;
        }

        public void fillExc()
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewAccAuc.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridViewAccAuc.ColumnCount - 1; j++)
                {
                    ws.Cells[1, j + 1] = dataGridViewAccAuc.Columns[j].HeaderText.ToString();

                    ws.Cells[i + 2, j + 1] = dataGridViewAccAuc[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;
        }
    }
}
