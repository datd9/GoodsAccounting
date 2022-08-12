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
    public partial class RegisterCLForm : Form
    {
        public RegisterCLForm()
        {
            InitializeComponent();

            // Подключение к БД
            String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * From client", con);
            DataSet ds_store = new DataSet("store");
            data.Fill(ds_store, "client");
            DataTable table;
            table = ds_store.Tables["client"];
            DataRow row;
            row = table.Rows[0];

            con.Close();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginCLForm logcl = new LoginCLForm();
            logcl.Show();
            this.Close();
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Внесение информации о пользователе
        private void FillData()
        {


            String connnection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
            string name = textBoxName.Text;
            string login = textBoxLog.Text;
            string pass = textBoxPass.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Заполните все поля!");

            }

            else
            {

                
                    //errorProvider1.SetError(textBox1, "");

                    string sql = "INSERT INTO client (name, login, pass) VALUES (@name, @login, @pass)";
                    using (MySqlConnection con = new MySqlConnection(connnection))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        //параметр имени
                        MySqlParameter nameP = new MySqlParameter("@name", name);
                        cmd.Parameters.Add(nameP);
                        // параметр количества
                        MySqlParameter loginP = new MySqlParameter("@login", login);
                        cmd.Parameters.Add(loginP);
                        // параметр цены
                        MySqlParameter passP = new MySqlParameter("@pass", pass);
                        cmd.Parameters.Add(passP);



                        cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Вы успешно зарегистрированы, " + name);
                    LoginCLForm logf = new LoginCLForm();
                    logf.Show();
                    this.Hide();
                

            }
        }


        private void buttonReg_Click(object sender, EventArgs e)
        {




                String connection = "Database=store;server=localhost;User Id=root;Password=sql123456789";
                string login = textBoxLog.Text;

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM client WHERE login = @login", con);

                    MySqlParameter loginP = new MySqlParameter("@login", login);
                    cmd.Parameters.Add(loginP);

                    MySqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            MessageBox.Show("Имя пользователя занято!");
                        }

                    }
                    else
                    {
                        FillData();
                    }
                    reader.Close();

                }
            



        }

    }
}

