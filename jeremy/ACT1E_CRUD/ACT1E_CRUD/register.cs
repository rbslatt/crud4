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
namespace ACT1E_CRUD
{
    public partial class register : Form
    {
        private MySqlConnection connection;
        public register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=jeremydb;username=root;password=;");
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please Enter both name, username and password");
            }

            try
            {
                connection.Open();
                string registerquery = "INSERT INTO users (username, password, name) VALUES (@username, @password, @name)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Account Successfully Registerd!");
                }
                else
                {
                    MessageBox.Show("Account Failed to Register, Please try again.");

                }

                txtName.Clear();
                txtPassword.Clear();
                txtUsername.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            {

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }


        }
    }
}
