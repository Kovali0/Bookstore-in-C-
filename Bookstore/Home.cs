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
    public partial class Home : Form
    {
        SqlConnection prConn;
        int currentuser;
        DataTable dataTable = new DataTable();
        Client parent;

        public Home(SqlConnection con, int userid, Client parent)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.boooooks;
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");
            this.prConn = con;
            this.currentuser = userid;
            this.parent = parent;

            string query = "Select Title, Author, Description, Review, Rate, CreatedDate From Books";
            SqlCommand cmd = new SqlCommand(query, prConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            mainBooksTable.DataSource = dataTable;
            DataTable dt = mainBooksTable.DataSource as DataTable;
        }

        ~Home()
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.Books' . Możesz go przenieść lub usunąć.
            this.booksTableAdapter.Fill(this.databaseDataSet.Books);

        }

        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            new NewBook(prConn, currentuser, parent).Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //nic ma nie robic
        }

        private void BtnBestBooks_Click(object sender, EventArgs e)
        {
            new BestBooks(prConn, currentuser, parent).Show();
            this.Close();
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

        private void MainBooksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
