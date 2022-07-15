using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE
{
    public class MemoCrud
    {
        public bool Insert(int MemoId, string LocationType, string PaymentType, double cost)
        {
            DatabaseConnection dbc = new DatabaseConnection();
            SqlCommand cmd = new SqlCommand();
            DateTime now = DateTime.Now;

            cmd = new SqlCommand("insert into Memo(MemoID,Total,PaymentType,LocationType,Date) values(@memoid,@total,@paytype,@loctype,@date)", dbc.MyConnection);

            cmd.Parameters.AddWithValue("@memoid", MemoId);
            cmd.Parameters.AddWithValue("@total", cost);
            cmd.Parameters.AddWithValue("@paytype", PaymentType);
            cmd.Parameters.AddWithValue("@loctype", LocationType);
            cmd.Parameters.AddWithValue("@date", now);

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

        public bool Update(string memoid)
        {
            DatabaseConnection dbc = new DatabaseConnection();
            dbc.ConnectWithDB();
            SqlCommand cmd = new SqlCommand("UPDATE Memo SET Paid='true' WHERE MemoID = '" + memoid + "'", dbc.MyConnection);

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

        public List<SoldInfo> GetMemo(string memoID)
        {
            string query = "SELECT * FROM Sale WHERE MemoID = '" + memoID + "'";

            DatabaseConnection dbc = new DatabaseConnection();
            List<SoldInfo> list = new List<SoldInfo>();
            dbc.ConnectWithDB();
            SqlDataReader sdr = dbc.GetData(query);

            while (sdr.Read())
            {
                SoldInfo info = new SoldInfo();
                info.Name = sdr["FoodName"].ToString();
                info.Quantity = Convert.ToInt32(sdr["Quantity"].ToString());
                info.Price = Convert.ToDouble(sdr["Cost"].ToString());
                list.Add(info);
            }
            dbc.CloseConnection();
            return list;
        }
    }
}
