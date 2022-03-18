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
            string query = "SELECT drink_id, drinkName, drink_price, isAlcoholic FROM [Drink]";
            string secondquery = "SELECT stock_amount FROM Stock";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), ExecuteSelectQuery(secondquery, sqlParameters2));
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
        public void AddNewStock(Drink drink)
        {
            
            SqlCommand command = new SqlCommand("INSERT INTO Stock (stock_amount)" +
              "VALUES (@Stock_amount);", OpenConnection());
            command.Parameters.AddWithValue("@Stock_amount", drink.DrinkStock);
            command.ExecuteNonQuery();
            
            
        }
        public void AddDrinkStock(Drink drink)
        {
            SqlCommand command = new SqlCommand("UPDATE Stock SET stock_amout = stock_amount + 1 " +
                "FROM Stock WHERE stock_id = @id", OpenConnection());
            command.Parameters.AddWithValue("@id", drink.DrinkId);
            command.ExecuteNonQuery();
        }  
        public void RemoveDrinkStock(Drink drink)
        {
            
            SqlCommand command = new SqlCommand("UPDATE Stock SET stock_amount = stock_amount - 1 " +
                "FROM Stock WHERE stock_id = @id");
            command.Parameters.AddWithValue("@id", drink.DrinkId);
            command.ExecuteNonQuery();
        }

        private List<Drink> ReadTables(DataTable dataTable, DataTable secondDataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (DataRow st in secondDataTable.Rows)
                {
                    Drink drink = new Drink()
                    {
                        DrinkId = (int)dr["drink_id"],
                        DrinkName = (string)(dr["drinkName"]),
                        DrinkPrice = (decimal)(dr["drink_price"]),
                        DrinkType = (bool)(dr["isAlcoholic"]),
                        DrinkStock = (int)(st["stock_amount"])
                    };
                    drinks.Add(drink);
                }
            }
          
            return drinks;
        } 
    }
}
