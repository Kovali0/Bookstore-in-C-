using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Client : Form
    {
        SqlConnection prConn;
        string connstring;

        public Client()
        {
            InitializeComponent();
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");
            pictureBoxLogo.Image = Properties.Resources.bookstorelogo;
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = "BookStore Application";

            //////////////////////////////////////////////

            //SqlConnection prConn = new SqlConnection(ConfigurationManager.AppSettings["sqlconnectionstring"]);
            //SqlConnection prConn = new SqlConnection("Data Source=localhost;Initial Catalog=tempdb;Integrated Security=True;Connect Timeout=5");
            connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Database.mdf\"; Integrated Security=True;Connect Timeout=30";
            prConn = new SqlConnection(connstring);
            Console.WriteLine(prConn.ConnectionTimeout);
            try
            {
                Console.WriteLine("Start");
                prConn.Open();
                Console.WriteLine("Połączono z bazą danych!");
            }
            catch (Exception)
            {
                Console.WriteLine("Brak połączenia z bazą danych!");
            }
        }

        ~Client()
        {
            prConn.Close();
            Console.WriteLine("Stop");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin(prConn);
            fl.ShowDialog(this);
            if (fl.SuccessLogin()==1)
            {
                int userid = fl.UserId();
                new Home(prConn, userid, this).Show();
                this.Hide();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            new FormRegistration(prConn).ShowDialog(this);
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
