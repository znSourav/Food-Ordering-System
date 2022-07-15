using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class SaleCrud
    {
        public bool Insert(int MemoId, string FoodType, string FoodName, string FoodId, string LocationType, string PaymentType, int quantity, double cost)
        {
            DatabaseConnection dbc = new DatabaseConnection();
            SqlCommand cmd = new SqlCommand();
            DateTime now = DateTime.Now;

            cmd = new SqlCommand("insert into Sale(MemoID,Date,FoodType,FoodName,FoodID,LocationType,Quantity,Cost,PaymentType) values(@memoid,@date,@foodtype,@foodname,@foodid,@locationtype,@quantity,@cost,@paytype)", dbc.MyConnection);

            cmd.Parameters.AddWithValue("@memoid", MemoId);
            cmd.Parameters.AddWithValue("@date", now);
            cmd.Parameters.AddWithValue("@foodtype", FoodType);
            cmd.Parameters.AddWithValue("@foodname", FoodName);
            cmd.Parameters.AddWithValue("@foodid", FoodId);
            cmd.Parameters.AddWithValue("@locationtype", LocationType);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@paytype", PaymentType);

            dbc.ConnectWithDB(); // DB On
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0) return true;
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
    }
}
