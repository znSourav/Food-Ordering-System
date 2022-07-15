using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace DATABASE
{
    public class FoodCrud
    {
        public bool Insert(byte[] Picture, string ID, string Name, string Price, string TableName)
        {
            DatabaseConnection dbc = new DatabaseConnection();
            SqlCommand cmd = new SqlCommand();

            if (TableName.Equals("Burger"))
            {
                cmd = new SqlCommand("insert into Burger(ID, Name, Price, Image) values(@id,@name,@price,@img)", dbc.MyConnection);
            }
            else if (TableName.Equals("Drink"))
            {
                cmd = new SqlCommand("insert into Drink(ID, Name, Price, Image) values(@id,@name,@price,@img)", dbc.MyConnection);
            }
            else if (TableName.Equals("ComboMeal"))
            {
                cmd = new SqlCommand("insert into ComboMeal(ID, Name, Price, Image) values(@id,@name,@price,@img)", dbc.MyConnection);
            }
            else if (TableName.Equals("Dessert"))
            {
                cmd = new SqlCommand("insert into Dessert(ID, Name, Price, Image) values(@id,@name,@price,@img)", dbc.MyConnection);
            }
            else if (TableName.Equals("Extra"))
            {
                cmd = new SqlCommand("insert into Extra(ID, Name, Price, Image) values(@id,@name,@price,@img)", dbc.MyConnection);
            }
            cmd.Parameters.AddWithValue("@img", Picture);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@price", Price);
            dbc.ConnectWithDB(); // DB On
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                dbc.CloseConnection(); // DB Off
            }
            return false;
        }

        public bool Update(byte[] Picture, string ID, string Name, string Price, string TableName)
        {
            DatabaseConnection dbc = new DatabaseConnection();
            SqlCommand cmd = new SqlCommand();

            if (TableName.Equals("Burger"))
            {
                cmd = new SqlCommand("UPDATE Burger SET Name=@name, Price=@price, Image=@img WHERE ID='" + ID + "'", dbc.MyConnection);
            }
            else if (TableName.Equals("Drink"))
            {
                cmd = new SqlCommand("UPDATE Drink SET Name=@name, Price=@price, Image=@img WHERE ID='" + ID + "'", dbc.MyConnection);
            }
            else
            {
                cmd = new SqlCommand("UPDATE ComboMeal SET Name=@name, Price=@price, Image=@img WHERE ID='" + ID + "'", dbc.MyConnection);
            }
            cmd.Parameters.AddWithValue("@img", Picture);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@price", Price);
            dbc.ConnectWithDB(); // DB On
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                dbc.CloseConnection(); // DB Off
            }
            return false;
        }

        public bool Delete(string ID, string TableName)
        {
            DatabaseConnection dbc = new DatabaseConnection();
            SqlCommand cmd = new SqlCommand();

            if (TableName.Equals("Burger"))
            {
                cmd = new SqlCommand("DELETE FROM Burger WHERE ID='" + ID + "'", dbc.MyConnection);
            }
            else if (TableName.Equals("Drink"))
            {
                cmd = new SqlCommand("DELETE FROM Drink WHERE ID='" + ID + "'", dbc.MyConnection);
            }
            else
            {
                cmd = new SqlCommand("DELETE FROM ComboMeal WHERE ID='" + ID + "'", dbc.MyConnection);
            }
            dbc.ConnectWithDB(); // DB On
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                dbc.CloseConnection(); // DB Off
            }
            return false;
        }

        public List<Food> GetAllFood(string TableName)
        {
            string query = "SELECT * from " + TableName;
            DatabaseConnection dbc = new DatabaseConnection();
            List<Food> foodList = new List<Food>();
            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);
            while (sdr.Read())
            {
                Food food = new Food();
                food.FoodID = sdr["ID"].ToString();
                food.Name = sdr["Name"].ToString();
                food.Price = Convert.ToDouble(sdr["Price"]);
                byte[] picture = (byte[])sdr["Image"];
                food.MemS = new MemoryStream(picture);
                food.MemS.Seek(0, SeekOrigin.Begin);
                food.FoodType = TableName;
                foodList.Add(food);
            }
            dbc.CloseConnection();
            return foodList;
        }

        public Food GetOneFood(string TableName, string ID)
        {
            Food food = new Food();
            string query = "SELECT * from " + TableName + " WHERE ID='" + ID + "'";
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);
            while (sdr.Read())
            {
                food.FoodID = sdr["ID"].ToString();
                food.Name = sdr["Name"].ToString();
                food.Price = Convert.ToDouble(sdr["Price"]);
                byte[] picture = (byte[])sdr["Image"];
                food.MemS = new MemoryStream(picture);
                food.MemS.Seek(0, SeekOrigin.Begin);
            }
            dbc.CloseConnection();
            return food;
        }
    }
}
