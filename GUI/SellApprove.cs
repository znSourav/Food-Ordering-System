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
    public partial class SellApprove : Form
    {
        private EmpHome empObj;
        private bool flag = false;
        private DatabaseConnection con;

        public SellApprove(EmpHome empObj)
        {
            InitializeComponent();
            this.empObj = empObj;
            con = new DatabaseConnection();
        }

        private void SellApprove_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT MemoID,Date,LocationType,Total,Paid FROM Memo WHERE  Paid= 'false'";
            SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
            SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            MemoGridView.DataSource = dt1;
        }

        private void BackClick(object sender, EventArgs e)
        {
            flag = false;
            empObj.Show();
            empObj.Opacity = 0.1;
            timer1.Start();
        }

        private void ApproveClick(object sender, EventArgs e)
        {
            String memoid = textBox1.Text;
            MemoCrud crudOp = new MemoCrud();
            bool x = crudOp.Update(memoid);

            if (!x)
            {
                MessageBox message = new MessageBox("ERROR !");
                message.Show();
                return;
            }

            string query1 = "SELECT MemoID,Date,LocationType,Total,Paid FROM Memo WHERE  Paid= 'false'";
            SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
            SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            MemoGridView.DataSource = dt1;

            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= .9)
                {
                    this.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    empObj.Hide();
                }
            }
            else
            {
                if (empObj.Opacity <= 0.9)
                {
                    empObj.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void C_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = MemoGridView.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = item.ToString();
        }
    }
}
