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
    public partial class AdminPanel : Form
    {
        SqlConnection prConn;
        DataTable uT = new DataTable();
        DataTable bT = new DataTable();
        public AdminPanel(SqlConnection prConn)
        {
            InitializeComponent();
            this.prConn = prConn;
            this.Icon = new Icon("C:\\Users\\Kovalio\\source\\repos\\Bookstore\\Bookstore\\Resources\\icons8_book_96_NVN_icon.ico");

            string query1 = "Select * From Users";
            string query2 = "Select * From Books";
            SqlCommand cmd1 = new SqlCommand(query1, prConn);
            SqlCommand cmd2 = new SqlCommand(query2, prConn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da1.Fill(uT);
            da2.Fill(bT);
            usertable.DataSource = uT;
            bookstable.DataSource = bT;
            DataTable ut1 = usertable.DataSource as DataTable;
            DataTable bt1 = bookstable.DataSource as DataTable;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
