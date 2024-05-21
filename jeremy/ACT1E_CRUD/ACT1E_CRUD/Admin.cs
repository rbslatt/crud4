using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
namespace ACT1E_CRUD
{
    public partial class Admin : Form
    {
        private MySqlConnection connection;
        public Admin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=jeremydb;username=root;password=;");
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecords = "SELECT ID, name, username, role FROM users ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(showallrecords, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                //display error
                MessageBox.Show("Error:" + ex.Message);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                cbRole.Text = row.Cells["role"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                connection.Open();
                string showallrecords = "SELECT ID, name, username, role FROM users WEHRE ID LIKE CONCAT('%', @search, '%') OR name LIKE CONCAT('%', @search, '%') OR username LIKE CONCAT('%', @search, '%')";
                MySqlCommand command = new MySqlCommand(showallrecords, connection);
                command.Parameters.AddWithValue("@search", search);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbRole.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter both role, name, username and password");
            }
            try
            {
                connection.Open();
                string registerquery = "INSERT INTO users (username, password, name,role) VALUES (@username, @password, @name, @role)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Account Successfully Registered");
                }
                else
                {
                    MessageBox.Show("Account Failed to Register!, Please Try Again.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                loaddata();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbRole.Text;
            string ID = txtID.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter both role, name, username and password");
            }
            try
            {
                connection.Open();
                string registerquery = "UPDATE users SET name = @name, username = @username, password = @password, role = @role WHERE ID = @id";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("ID", ID);
                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Account Successfully Update");
                }
                else
                {
                    MessageBox.Show("Account Failed to Update!, Please Try Again.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                loaddata();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this record?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string ID = txtID.Text;

                if (string.IsNullOrWhiteSpace(ID))
                {
                    MessageBox.Show("No Record Found!");
                    return;
                }
                try
                {
                    connection.Open();
                    string deletequery = "DELETE FROM users WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(deletequery, connection);
                    command.Parameters.AddWithValue("@ID", ID);

                    int rowaffected = command.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Account Successfully Update");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    loaddata();
                    txtID.Clear();
                    txtName.Clear();
                    txtPassword.Clear();
                    txtUsername.Clear();

                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
