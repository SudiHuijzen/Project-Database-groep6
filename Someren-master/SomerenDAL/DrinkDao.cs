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
    public class DrinkDao: BaseDao
    {
        public List<Drink> GetAll()
        {
            string query = "SELECT drink_id, drinkName, drink_price, isAlcoholic, Drink.Stock_id, Stock_amount FROM [Drink]" +
                "JOIN Stock ON Drink.stock_id = STOCK.stock_id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddSale(Student student, Drink drink)
        {
            SqlCommand command = new SqlCommand("INSERT INTO RegisterScreen (drink_id, student_id, sales_date)" + 
                "VALUES (@drink_id, @student_id, @sales_date)", OpenConnection());
            command.Parameters.AddWithValue("@drink_id", drink.DrinkId);
            command.Parameters.AddWithValue("@student_id", student.Number);
            command.Parameters.AddWithValue("@sales_date", DateTime.Now.ToString("yyyy/MM/dd"));
            command.ExecuteNonQuery();
        }
        public void AddDrink(Drink drink)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.Drink (drinkName, isAlcoholic, Drink.stock_id)" +
                "VALUES (@DrinkName, @isAlcoholic, @stockId);", OpenConnection());
            command.Parameters.AddWithValue("@DrinkName", drink.DrinkName);
            command.Parameters.AddWithValue("@isAlcoholic", drink.DrinkType);
            command.Parameters.AddWithValue("@stockId", drink.DrinkId);
            command.ExecuteNonQuery();
        }  

        public void ChangeDrinkName(string newNAme, int id)
        { 
                 SqlCommand command = new SqlCommand("UPDATE dbo.Drink SET COLUMN drinkName = '@NewName' " +
                     "WHERE drink_id = @DrinkID", OpenConnection());
            command.Parameters.AddWithValue("@NewName", newNAme);
            command.Parameters.AddWithValue("@DrinkID", id);
            command.ExecuteNonQuery();
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();
          
            foreach (DataRow dr in dataTable.Rows)
            {
                    Drink drink = new Drink()
                    {
                        DrinkId = (int)dr["drink_id"],
                        DrinkName = (string)(dr["drinkName"]),
                        DrinkPrice = (decimal)(dr["drink_price"]),
                        DrinkType = (bool)(dr["isAlcoholic"]),
                        DrinkStockId = (int)(dr["stock_id"]),
                        DrinkStock = (int)(dr["stock_amount"])
                    };
                    drinks.Add(drink);
            }
            return drinks;
        } 
    }
}
