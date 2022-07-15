using DATABASE;
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

namespace GUI
{
    public partial class ApproveSale : Form
    {


        private DatabaseConnection con;
        public ApproveSale()
        {
            InitializeComponent();
            con = new DatabaseConnection();
        }

        private void ApproveSale_Load(object sender, EventArgs e)
        {

            string query1 = "SELECT MemoID,Total,Date,Paid FROM Memo WHERE  Paid= 'false'";
            SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
            SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            MemoGridView.DataSource = dt1;
        }

        private void ApproveClick(object sender, EventArgs e)
        {
            String memoid = textBox1.Text;
            con.ConnectWithDB();
            string query = "UPDATE Memo SET Paid='true' WHERE MemoID = '" + memoid + "'";
            SqlCommand cmd = new SqlCommand(query, con.MyConnection);
            try
            {
                int res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.CloseConnection(); // DB Off
            }

            

            string query1 = "SELECT MemoID,Total,Date,Paid FROM Memo WHERE  Paid= 'false'";
            SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
            SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            MemoGridView.DataSource = dt1;
        }
    }
}
