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
    public partial class NewBook : Form
    {
        SqlConnection prConn;
        SqlTransaction transaction = null;
        int currentuser;
        Client parent;

        public NewBook(SqlConnection con, int userid, Client parent)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.boooooks;
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");
            newBookArt.Image = Properties.Resources.book;
            newBookArt.SizeMode = PictureBoxSizeMode.StretchImage;
            newBookArt.BackColor = System.Drawing.Color.Transparent;
            this.prConn = con;
            this.currentuser = userid;
            this.parent = parent;
        }

        private void BtnHome_Click_1(object sender, EventArgs e)
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

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();

        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            new Profile(prConn, currentuser, parent).Show();
            this.Close();
        }

        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            string title = titleField.Text;
            string author = authorField.Text;
            string desc = descField.Text;
            string rev = reviewField.Text;
            int rate = (int)rateBox.Value;
            bool flag = true;

            Console.WriteLine(flag);

            if (String.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title field is empty!", "Error"); flag = false;
            }

            if (String.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Author field is empty!", "Error"); flag = false;
            }

            if (String.IsNullOrWhiteSpace(desc))
            {
                MessageBox.Show("Descryption field is empty!", "Error"); flag = false;
            }

            if (String.IsNullOrWhiteSpace(rev))
            {
                MessageBox.Show("Review field is empty! ", "Error"); flag = false;
            }


            Console.WriteLine(flag);
            if (flag)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = prConn;
                    transaction = prConn.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;
                    cmd.CommandText = "INSERT INTO Books (Title, Author, Description, Rate, User_Id, Review, CreatedDate) VALUES (@title, @author, @descryption, @rate, @userid, @review, @date)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("title", SqlDbType.VarChar, 100).Value = title;
                    cmd.Parameters.Add("author", SqlDbType.VarChar, 100).Value = author;
                    cmd.Parameters.Add("descryption", SqlDbType.Text).Value = desc;
                    cmd.Parameters.Add("rate", SqlDbType.Int).Value = rate;
                    cmd.Parameters.Add("desc", SqlDbType.Text).Value = desc;
                    cmd.Parameters.Add("userid", SqlDbType.Int).Value = currentuser;
                    cmd.Parameters.Add("review", SqlDbType.Text).Value = rev;
                    cmd.Parameters.Add("date", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    string query = "";
                    switch (rate)
                    {
                        case 1:
                            query = "update UsersStatistics set Note_1 = Note_1 + 1 Where User_Id = @cuid";
                            break;
                        case 2:
                            query = "update UsersStatistics set Note_2 = Note_2 + 1 Where User_Id = @cuid";
                            break;
                        case 3:
                            query = "update UsersStatistics set Note_3 = Note_3 + 1 Where User_Id = @cuid";
                            break;
                        case 4:
                            query = "update UsersStatistics set Note_4 = Note_4 + 1 Where User_Id = @cuid";
                            break;
                        case 5:
                            query = "update UsersStatistics set Note_5 = Note_5 + 1 Where User_Id = @cuid";
                            break;
                        case 6:
                            query = "update UsersStatistics set Note_6 = Note_6 + 1 Where User_Id = @cuid";
                            break;
                        case 7:
                            query = "update UsersStatistics set Note_7 = Note_7 + 1 Where User_Id = @cuid";
                            break;
                        case 8:
                            query = "update UsersStatistics set Note_8 = Note_8 + 1 Where User_Id = @cuid";
                            break;
                        case 9:
                            query = "update UsersStatistics set Note_9 = Note_9 + 1 Where User_Id = @cuid";
                            break;
                        case 10:
                            query = "update UsersStatistics set Note_10 = Note_10 + 1 Where User_Id = @cuid";
                            break;
                        default:
                            Console.WriteLine("Smth went wrong, with saving statistics!"); break;
                    }
                    //SqlCommand sqlCmd = new SqlCommand(query, prConn);
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = prConn;
                    transaction = prConn.BeginTransaction(IsolationLevel.ReadCommitted);
                    sqlCmd.Transaction = transaction;
                    sqlCmd.CommandText = query;
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.Add("cuid", SqlDbType.Int).Value = currentuser;
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
            Console.WriteLine(flag);
            if (flag)
            {
                MessageBox.Show("Successfuly added new book review.", "Success");
            }
            else
            {
                MessageBox.Show("Something went wrong, try again.", "Error");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            authorField.Text = String.Empty;
            titleField.Text = String.Empty;
            descField.Text = String.Empty;
            reviewField.Text = String.Empty;
        }

        private void RateBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
