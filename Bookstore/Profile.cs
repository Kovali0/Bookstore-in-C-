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
    public partial class Profile : Form
    {
        SqlConnection prConn;
        int currentuser;
        string cuusername;
        string cuemail;
        Client parent;
        public Profile(SqlConnection con, int userid, Client parent)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.boooooks;
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");
            profileImage.Image = Properties.Resources.readingman;
            profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            profileImage.BackColor = System.Drawing.Color.Transparent;
            this.prConn = con;
            this.currentuser = userid;
            this.parent = parent;

            SqlCommand cmd1 = new SqlCommand("TakeCurrentUserNickAndEmail", prConn);
            cmd1.Parameters.AddWithValue("@cid", currentuser);
            cmd1.CommandType = CommandType.StoredProcedure;
            var qresult = cmd1.ExecuteScalar();
            cuusername = (string)qresult;
            SqlCommand cmd2 = new SqlCommand("SELECT Email FROM Users WHERE Id LIKE @curid;", prConn);
            cmd2.Parameters.Add(new SqlParameter("@curid", SqlDbType.Int)).Value = currentuser;
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                cuemail = (string)reader["Email"];
            }
            reader.Close();
            this.nickLabel.Text = cuusername;
            this.emailLab.Text = cuemail;
            this.checkIfAdmin();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            new Home(prConn, currentuser, parent).Show();
            this.Close();
        }

        private void BtnBestBooks_Click(object sender, EventArgs e)
        {
            new BestBooks(prConn, currentuser, parent).Show();
            this.Close();
        }

        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            new NewBook(prConn, currentuser, parent).Show();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AgeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NickLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeBox_ValueChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = prConn;
                transaction = prConn.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                cmd.CommandText = "INSERT INTO Users (Age) VALUES (@age) WHERE Id = @curid";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("curid", SqlDbType.Int).Value = currentuser;
                cmd.Parameters.Add("age", SqlDbType.Int).Value = ageBox.Value;
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exc)
            {
                //Console.WriteLine(exc.Message);
                transaction.Rollback();
            }
        }

        private void NickLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void Adminpbtn_Click(object sender, EventArgs e)
        {
            AdminPanel fadminpanel = new AdminPanel(prConn);
            fadminpanel.ShowDialog(this);
        }

        public void checkIfAdmin()
        {
            SqlCommand cmd = new SqlCommand("TakeCurrentUserRole", prConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", currentuser);

            string result = (string)cmd.ExecuteScalar();

            if (result == "user")
            {
                adminpbtn.Enabled = false;
                adminpbtn.Visible = false;
            }
        }

        private void ProfileImage_Click(object sender, EventArgs e)
        {

        }

        private void StatsBtn_Click(object sender, EventArgs e)
        {
            UserStatistics statspanel = new UserStatistics(prConn, currentuser);
            statspanel.ShowDialog(this);
        }
    }
}
