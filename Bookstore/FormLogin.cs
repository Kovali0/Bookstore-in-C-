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

namespace Bookstore
{
    public partial class FormLogin : Form
    {
        SqlConnection prConn;
        int result, id;

        public FormLogin(SqlConnection con)
        {
            InitializeComponent();
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");
            this.Text = "BookStore Application";
            this.prConn = con;
            this.result = 0;
            passwordField.PasswordChar = '*';
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("LoginCheck", prConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nick", usernameField.Text.ToString());
            cmd.Parameters.AddWithValue("@pass", passwordField.Text.ToString());

            result = (Int32)cmd.ExecuteScalar();

            if (result == 1)
            {
                SqlCommand cmd2 = new SqlCommand("TakeUserIdWhenLogin", prConn);
                cmd2.Parameters.AddWithValue("@nick", usernameField.Text.ToString());
                cmd2.Parameters.AddWithValue("@pass", passwordField.Text.ToString());
                cmd2.CommandType = CommandType.StoredProcedure;
                id = (Int32)cmd2.ExecuteScalar();
                MessageBox.Show("Successful login.", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password, try again.", "Error");
            }
        }
        public int SuccessLogin()
        {
            return result;
        }

        public int UserId()
        {
            return id;
        }
    }
}
