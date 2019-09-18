using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;
using IsolationLevel = System.Data.IsolationLevel;

namespace Bookstore
{
    public partial class FormRegistration : Form
    {
        SqlConnection prConn = null;
        SqlTransaction transaction = null;

        public FormRegistration(SqlConnection con)
        {
            InitializeComponent();
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");
            this.Text = "BookStore Application";
            this.prConn = con;
            passwordField.PasswordChar = '*';
            passwordRepeatField.PasswordChar = '*';
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string email = emailField.Text;
            string password = passwordField.Text;
            string reppassword = passwordRepeatField.Text;
            bool flag = true;

            if (String.IsNullOrWhiteSpace(username) || username.Length < 4)
            {
                MessageBox.Show("Incorrect username. The lenght of username should be 4 characters minimum.", "Error"); flag = false;
            }

            if (String.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                MessageBox.Show("Incorrect email. Try again, remember email contains @.", "Error"); flag = false;
            }

            if (String.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("Incorrect password. The lenght of password should be 6 characters minimum.", "Error"); flag = false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("The password must contains numbers.", "Error"); flag = false;
            }

            if (password != reppassword)
            {
                MessageBox.Show("Password field and Repeated password is not the same.", "Error"); flag = false;
            }

            if (flag)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = prConn;
                    transaction = prConn.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;
                    cmd.CommandText = "INSERT INTO Users (Username, Password, Role, Email, CreatedDate) VALUES (@nick, @pass, @role, @email, @date)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("nick", SqlDbType.VarChar, 50).Value = username;
                    cmd.Parameters.Add("pass", SqlDbType.VarChar, 50).Value = password;
                    cmd.Parameters.Add("role", SqlDbType.Text).Value = "user";
                    cmd.Parameters.Add("email", SqlDbType.Text).Value = email;
                    cmd.Parameters.Add("date", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    transaction.Rollback();
                    flag = false;
                }
            }
            if (flag)
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand("TakeUserIdWhenLogin", prConn);
                    cmd2.Parameters.AddWithValue("@nick", username);
                    cmd2.Parameters.AddWithValue("@pass", password);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    int id = (Int32)cmd2.ExecuteScalar();
                    string query = "INSERT INTO UsersStatistics (User_Id) VALUES (@id)";
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = prConn;
                    transaction = prConn.BeginTransaction(IsolationLevel.ReadCommitted);
                    sqlCmd.Transaction = transaction;
                    sqlCmd.CommandText = query;
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                    sqlCmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    transaction.Rollback();
                    flag = false;
                }
            }
            if (flag)
            {
                MessageBox.Show("Successful registration.", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong, try again.", "Error");
            }
        }

        private void UsernameField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
