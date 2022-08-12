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
    public partial class FormAcceptOrderBuy : Form
    {

        //Строка соединения аукционных
        static String constr = "server=localhost;database=store;user=root;password=sql123456789";
        MySqlConnection con = new MySqlConnection(constr);
        DataTable dt = new DataTable();


        public FormAcceptOrderBuy()
        {
            InitializeComponent();
        }

        private void FormAcceptOrderBuy_Load(object sender, EventArgs e)
        {
            filldata();
            ExcExport();
        }

        private void filldata()
        {

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;


            //sql
            string sql = "SELECT * FROM orderaccept";
            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            //заполнение dgv
            adapter.Fill(dt);

            //bind dgv
            dataGridViewAccOrdBuy.DataSource = dt;

        }

        private void ExcExport()
        {

            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewAccOrdBuy.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridViewAccOrdBuy.ColumnCount - 1; j++)
                {
                    ws.Cells[1, j + 1] = dataGridViewAccOrdBuy.Columns[j].HeaderText.ToString();

                    ws.Cells[i + 2, j + 1] = dataGridViewAccOrdBuy[j, i].Value.ToString();
                }
            }

            exApp.Visible = true;


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }
    }
}
