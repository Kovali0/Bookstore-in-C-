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
    public partial class UserStatistics : Form
    {
        SqlConnection prConn;
        int currentuser;
        public UserStatistics(SqlConnection con, int userid)
        {
            this.prConn = con;
            this.currentuser = userid;
            InitializeComponent();
        }

        private void NotesChart_Click(object sender, EventArgs e)
        {

        }

        private void UserStatistics_Load(object sender, EventArgs e)
        {
            fillChart();
        }
 
        private void fillChart()
        {
            int[] notes = new int[11];
            DataSet ds = new DataSet();
            string query = "Select * from UsersStatistics WHERE User_Id LIKE @curid";
            SqlCommand cmd = new SqlCommand(query, prConn);
            cmd.Parameters.Add(new SqlParameter("@curid", SqlDbType.Int)).Value = currentuser;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    notes[0] = (int)reader["Note_0"];
                    notes[1] = (int)reader["Note_1"];
                    notes[2] = (int)reader["Note_2"];
                    notes[3] = (int)reader["Note_3"];
                    notes[4] = (int)reader["Note_4"];
                    notes[5] = (int)reader["Note_5"];
                    notes[6] = (int)reader["Note_6"];
                    notes[7] = (int)reader["Note_7"];
                    notes[8] = (int)reader["Note_8"];
                    notes[9] = (int)reader["Note_9"];
                    notes[10] = (int)reader["Note_10"];
                }
            }
            reader.Close();

            //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //adapt.Fill(ds);
            /*DataTable table = new DataTable();
            adapt.Fill(table);

            //Select all the records in database
            adapt.SelectCommand = cmd;

            //Retrieve the records from database
            adapt.Fill(table);
            //Set DataTable as data source to Chart
            notesChart.DataSource = table;

            //Mapping a field with x-value of chart
            notesChart.Series[0].Name = "Note_5";

            //notesChart.Series[1].Name = "Note_2";

            //Mapping a field with y-value of Chart
            //notesChart.Series[0].YName = "yName";

            //Bind the DataTable with Chart
            notesChart.DataBind();*/
            DataTable schema = null;
            using (var readercol = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
            {
                schema = readercol.GetSchemaTable();
            }
            List<string> listofcolumns = new List<string>();
            foreach (DataRow col in schema.Rows)
            {
                listofcolumns.Add(col.Field<String>("ColumnName"));
            }
            notesChart.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            //notesChart.Series["Notes"].XValueMember = "Note_5";
            int i = 0;
            foreach (string note in listofcolumns)
            {
                //notesChart.Series["Notes"].Points.AddXY(myreader.GetString("name"), cmd.GetInt32("Age")); 
                if(i>1)
                    notesChart.Series["Notes"].Points.AddXY(note,notes[i-2]);
                i++;
            }
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            //notesChart.Series["Notes"].YValueMembers = "Amount";
            //notesChart.Titles.Add("Salary Chart");
        }
    }
}
