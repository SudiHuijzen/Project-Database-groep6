using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class StockDao : BaseDao
    {
        public List<Stock> GetAll()
        {
            string query = "SELECT stock_id, stock_amount FROM [Stock]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddNewStock(Stock stock)
        {

            string querry = "INSERT INTO Stock (stock_id ,stock_amount)" +
              "VALUES (@Stock_id ,@Stock_amount);";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Stock_id", stock.Id);
            sqlParameters[1] = new SqlParameter("@Stock_amount", stock.StockAmount);
            ExecuteEditQuery(querry, sqlParameters);

        }
        public void AddDrinkStock(int id)
        {
            SqlCommand command = new SqlCommand("UPDATE Stock SET stock_amount = stock_amount + 1 " +
                "FROM Stock WHERE stock_id = @id", OpenConnection());
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
        public void RemoveDrinkStock(int id)
        {

            SqlCommand command = new SqlCommand("UPDATE Stock SET stock_amount = stock_amount - 1 " +
              "FROM Stock WHERE stock_id = @id", OpenConnection());
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        private List<Stock> ReadTables(DataTable dataTable)
        {
            List<Stock> supply = new List<Stock>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Stock stock = new Stock()
                {
                    Id = (int)dr["stock_id"],
                    StockAmount = (int)(dr["stock_amount"]),
                };
                supply.Add(stock);
            }
            return supply;
        }
    }
}
