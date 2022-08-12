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
    public partial class LoginCLForm : Form
    {


        public LoginCLForm()
        {
            InitializeComponent();
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnt_Click(object sender, EventArgs e)
        {
            String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM client", con);
            DataSet ds_store = new DataSet("store");
            data.Fill(ds_store, "client");
            DataTable table;
            table = ds_store.Tables["client"];
            DataRow row;
            row = table.Rows[0];

            string sql = "SELECT * FROM `client` WHERE binary `login` = @un and binary `pass`= @up";


            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(sql, con);
            command.Parameters.Add("@un", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@up", MySqlDbType.VarChar, 100);

            command.Parameters["@un"].Value = textBoxLog.Text;
            command.Parameters["@up"].Value = textBoxPass.Text;

            //adapter.SelectCommand = command;
            //adapter.Fill(table);
            MySqlDataReader reader = command.ExecuteReader();





            if (reader.HasRows)
            {
                MessageBox.Show("Вы авторизованы!" + "\r\n" + "Добро пожаловать!");
                MainCLForm cl = new MainCLForm();
                cl.Show();
                this.Close();
            }
            else
                MessageBox.Show("Логин или пароль не верны!");

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Hide();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegisterCLForm reg = new RegisterCLForm();
            reg.Show();
            this.Close();
        }
    }
}
