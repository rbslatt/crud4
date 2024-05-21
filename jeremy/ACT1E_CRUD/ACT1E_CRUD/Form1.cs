using MySql.Data.MySqlClient;
using System.Linq.Expressions;
namespace ACT1E_CRUD
{
    //REGISTER.CS
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            //Declare variable for connection string
            connection = new MySqlConnection("server=localhost;database=jeremydb;username=root;password=;");

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Create variable username and password
            string username = txtUsername.Text.Trim();
            string password = txtUsername.Text;

            //Check if username and password are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter both username and password");
            }

            try
            {
                //Login code
                //open connection
                connection.Open();
                //Create SQL query for login
                string loginquery = "SELECT COUNT(*) FROM users WHERE username=@username And password=@password";
                //Execute sql command
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                //Sanitize query sql injection
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //Get Total reward
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Successfully Login");
                    Admin adminpage = new Admin();
                    adminpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and passowrd");
                }
            }
            catch (Exception ex)
            {
                //display error
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //Close Connection
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerpage = new register();
            registerpage.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


