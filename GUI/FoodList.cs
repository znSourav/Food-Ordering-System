using System;
using DATABASE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.VisualBasic.Devices;

namespace GUI
{
    public partial class FoodList : Form
    {
        private EmpHome userHome;
        private bool flag = false;
        private DatabaseConnection con;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();

        public FoodList(EmpHome user)
        {
            InitializeComponent();
            this.userHome = user;
            FoodGridView.Visible = true;
            con = new DatabaseConnection();
        }

        private void FoodList_Load(object sender, EventArgs e)
        {
            string query1 = "select * from Burger";
            string query2 = "select * from ComboMeal";
            string query3 = "select * from Drink";
            string query4 = "select * from Dessert";
            string query5 = "select * from Extra";

            SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
            SqlCommand cmd2 = new SqlCommand(query2, con.MyConnection);
            SqlCommand cmd3 = new SqlCommand(query3, con.MyConnection);
            SqlCommand cmd4 = new SqlCommand(query4, con.MyConnection);
            SqlCommand cmd5 = new SqlCommand(query5, con.MyConnection);

            SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter d2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter d3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter d4 = new SqlDataAdapter(cmd4);
            SqlDataAdapter d5 = new SqlDataAdapter(cmd5);

            d1.Fill(dt1);
            d2.Fill(dt2);
            d3.Fill(dt3);
            d4.Fill(dt4);
            d5.Fill(dt5);

            dt4.Merge(dt5);
            dt3.Merge(dt4);
            dt2.Merge(dt3);
            dt1.Merge(dt2);

            FoodGridView.DataSource = dt1;
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            flag = false;
            userHome.Show();
            userHome.Opacity = 0.1;
            timer1.Start();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            string query1 = "";

            if (metroComboBox1.SelectedItem.ToString() == "All Items")
            {
                FoodGridView.DataSource = dt1;
                textBox3.Text = "";
                textBox1.Text = "0";
                textBox2.Text = "100";
                return; 
            }
            else if (metroComboBox1.SelectedItem.ToString() == "Burger")
            {
                query1 = "select * from Burger";
                textBox3.Text = "";
                textBox1.Text = "0";
                textBox2.Text = "100";
                dtb = new DataTable();
            }
            else if (metroComboBox1.SelectedItem.ToString() == "Drink")
            {
                query1 = "select * from Drink";
                textBox3.Text = "";
                textBox1.Text = "0";
                textBox2.Text = "100";
                dtb = new DataTable();
            }
            else if (metroComboBox1.SelectedItem.ToString() == "ComboMeal")
            {
                query1 = "select * from ComboMeal";
                textBox3.Text = "";
                textBox1.Text = "0";
                textBox2.Text = "100";
                dtb = new DataTable();
            }
            else if (metroComboBox1.SelectedItem.ToString() == "Dessert")
            {
                query1 = "select * from Dessert";
                textBox3.Text = "";
                textBox1.Text = "0";
                textBox2.Text = "100";
                dtb = new DataTable();
            }
            else
            {
                query1 = "select * from Extra";
                textBox1.Text = "0";
                textBox2.Text = "100";
                textBox3.Text = "";
                dtb = new DataTable();

            }

            SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
            SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
            d1.Fill(dtb);
            FoodGridView.DataSource = dtb;
        }

        private void Search(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem == null)
            {
                MessageBox message = new MessageBox("SELECT ITEM");
                message.Show();
                return;
            }

            String val1 = textBox1.Text;
            if (val1.Count() == 0)
            {
                textBox1.Text = val1 = "0";
            }
            for (int i = 0; i < val1.Count(); i++)
            {
                if (val1[i] >= '0' && val1[i] <= '9') continue;
                else
                {
                    textBox1.Text = val1 = "0";
                    break;
                }
            }
            String val2 = textBox2.Text;
            if (val2.Count() == 0)
            {
                textBox2.Text = val2 = "100";
            }
            for (int i = 0; i < val2.Count(); i++)
            {
                if (val2[i] >= '0' && val2[i] <= '9') continue;
                else
                {
                    textBox2.Text = val2 = "100";
                    break;
                }
            }
            String tablename = metroComboBox1.SelectedItem.ToString();

            if (tablename == "All Items")
            {
                string query1 = "select * from Burger Where Price BETWEEN " + val1 + " AND " + val2;
                string query2 = "select * from ComboMeal Where Price BETWEEN " + val1 + " AND " + val2;
                string query3 = "select * from Drink Where Price BETWEEN " + val1 + " AND " + val2;
                string query4 = "select * from Dessert Where Price BETWEEN " + val1 + " AND " + val2;
                string query5 = "select * from Extra Where Price BETWEEN " + val1 + " AND " + val2; ;

                SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
                SqlCommand cmd2 = new SqlCommand(query2, con.MyConnection);
                SqlCommand cmd3 = new SqlCommand(query3, con.MyConnection);
                SqlCommand cmd4 = new SqlCommand(query4, con.MyConnection);
                SqlCommand cmd5 = new SqlCommand(query5, con.MyConnection);

                SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter d2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter d3 = new SqlDataAdapter(cmd3);
                SqlDataAdapter d4 = new SqlDataAdapter(cmd4);
                SqlDataAdapter d5 = new SqlDataAdapter(cmd5);

                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                DataTable dt5 = new DataTable();

                d1.Fill(dt1);
                d2.Fill(dt2);
                d3.Fill(dt3);
                d4.Fill(dt4);
                d5.Fill(dt5);

                dt4.Merge(dt5);
                dt3.Merge(dt4);
                dt2.Merge(dt3);
                dt1.Merge(dt2);

                FoodGridView.DataSource = dt1;
            }
            else
            {
                Console.WriteLine("HAHAHAH: " + val1 + " -- " + val2);
                string query = "select * from " + tablename + " Where Price BETWEEN " + val1 + " AND " + val2;
                SqlCommand cmd = new SqlCommand(query, con.MyConnection);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dts = new DataTable();
                d.Fill(dts);
                FoodGridView.DataSource = dts;
            }
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
                    userHome.Hide();
                }
            }
            else
            {
                if (userHome.Opacity <= 0.9)
                {
                    userHome.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void Search2(object sender, EventArgs e)
        {

        }

        private void SearchKey(object sender, KeyEventArgs e)
        {
            if (metroComboBox1.SelectedItem == null)
            {
                MessageBox message = new MessageBox("SELECT ITEM");
                message.Show();
                textBox3.Text = "";
                return;
            }

            String val1 = textBox1.Text;
            Console.WriteLine(val1);
         
            for (int i = 0; i < val1.Count(); i++)
            {
                if (val1[i] >= '0' && val1[i] <= '9') continue;
                else
                {
                    textBox1.Text = val1 = "0";
                    break;
                }
            } 
            String val2 = textBox2.Text; 
            Console.WriteLine(val2);
            for (int i = 0; i < val2.Count(); i++)
            {
                if (val2[i] >= '0' && val2[i] <= '9') continue;
                else
                {
                    textBox2.Text = val2 = "100";
                    break;
                }
            }
            String val3 = textBox3.Text;
            String tablename = metroComboBox1.SelectedItem.ToString();

            if (tablename == "All Items")
            {
                string query1 = "select * from Burger Where Name LIKE '%" + val3 + "%' AND Price BETWEEN " + val1 + " AND " + val2;
                string query2 = "select * from ComboMeal Where Name LIKE '%" + val3 + "%' AND Price BETWEEN " + val1 + " AND " + val2;
                string query3 = "select * from Drink Where Name LIKE '%" + val3 + "%' AND Price BETWEEN " + val1 + " AND " + val2;
                string query4 = "select * from Dessert Where Name LIKE '%" + val3 + "%' AND Price BETWEEN " + val1 + " AND " + val2;
                string query5 = "select * from Extra Where Name LIKE '%" + val3 + "%' AND Price BETWEEN " + val1 + " AND " + val2;


                //Console.Write(query1);

                SqlCommand cmd1 = new SqlCommand(query1, con.MyConnection);
                SqlCommand cmd2 = new SqlCommand(query2, con.MyConnection);
                SqlCommand cmd3 = new SqlCommand(query3, con.MyConnection);
                SqlCommand cmd4 = new SqlCommand(query4, con.MyConnection);
                SqlCommand cmd5 = new SqlCommand(query5, con.MyConnection);

                SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter d2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter d3 = new SqlDataAdapter(cmd3);
                SqlDataAdapter d4 = new SqlDataAdapter(cmd4);
                SqlDataAdapter d5 = new SqlDataAdapter(cmd5);

                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                DataTable dt5 = new DataTable();

                d1.Fill(dt1);
                d2.Fill(dt2);
                d3.Fill(dt3);
                d4.Fill(dt4);
                d5.Fill(dt5);

                dt4.Merge(dt5);
                dt3.Merge(dt4);
                dt2.Merge(dt3);
                dt1.Merge(dt2);

                FoodGridView.DataSource = dt1;
            }
            else
            {
                string query = "select * from " + tablename + " Where Name LIKE '%" + val3 + "%' AND Price BETWEEN " + val1 + " AND " + val2;
                SqlCommand cmd = new SqlCommand(query, con.MyConnection);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dts = new DataTable();
                d.Fill(dts);
                FoodGridView.DataSource = dts;
            }
        }   
    }
}
