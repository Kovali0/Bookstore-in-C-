using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class BestBooks : Form
    {
        SqlConnection prConn;
        int currentuser;
        DataTable dataTable = new DataTable();
        Client parent;

        public BestBooks(SqlConnection con, int userid, Client parent)
        {
            InitializeComponent();
            this.prConn = con;
            this.currentuser = userid;
            this.BackgroundImage = Properties.Resources.boooooks;
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");
            this.parent = parent;

            string query = "Select Title, Author, Description, Review, Rate, CreatedDate From Books Where User_Id = @cuid";
            SqlCommand cmd = new SqlCommand(query, prConn);
            cmd.Parameters.Add(new SqlParameter("@cuid", SqlDbType.Int)).Value = currentuser;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            mainBooksTable.DataSource = dataTable;
            DataTable dt = mainBooksTable.DataSource as DataTable;
        }

        private void BestBooks_Load(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            new Home(prConn, currentuser, parent).Show();
            this.Close();
        }

        private void BtnBestBooks_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            new NewBook(prConn, currentuser, parent).Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Parent.Show();
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
