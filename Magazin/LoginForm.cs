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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * From users", con);
            DataSet ds_store = new DataSet("store");
            data.Fill(ds_store, "users");
            DataTable table;
            table = ds_store.Tables["users"];
            DataRow row;
            row = table.Rows[0];

            string sql = "SELECT * FROM `users` WHERE binary `login` = @un and binary `pass`= @up";


            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(sql, con);
            command.Parameters.Add("@un", MySqlDbType.VarChar, 25);
            command.Parameters.Add("@up", MySqlDbType.VarChar, 25);

            command.Parameters["@un"].Value = textBoxLog.Text;
            command.Parameters["@up"].Value = textBoxPass.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы авторизованы!");
                MainForm s = new MainForm();
                s.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Логин или пароль не верны!");

        }
    }
}
