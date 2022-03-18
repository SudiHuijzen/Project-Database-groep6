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
            string query = "SELECT drink_id, drinkName, drinkPrice FROM [Drink]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

<<<<<<< Updated upstream
        private List<Drink> ReadTables(DataTable dataTable)
=======
        public void AddSale(Student student, Drink drink)
        {
            SqlCommand command = new SqlCommand("INSERT INTO RegisterScreen (drink_id, student_id, sales_date, stock_id)" + 
                "VALUES (@drink_id, @student_id, @sales_date, @stock_id)", OpenConnection());
            command.Parameters.AddWithValue("@drink_id", drink.DrinkId);
            command.Parameters.AddWithValue("@student_id", student.Number);
            command.Parameters.AddWithValue("@sales_date", DateTime.Now.ToString("yyyy/MM/dd"));
            command.Parameters.AddWithValue("@stock_id", drink.DrinkId);
            command.ExecuteNonQuery();
        }
        public void AddDrink(Drink drink)
        {

            SqlCommand command = new SqlCommand("INSERT INTO dbo.Drink (drink_id ,drinkName, isAlcoholic, Drink.stock_id)" +
                "VALUES (@drinkId, @DrinkName, @isAlcoholic, @stockId);", OpenConnection());
            command.Parameters.AddWithValue("@DdrinkId", drink.DrinkId);
            command.Parameters.AddWithValue("@DrinkName", drink.DrinkName);
            command.Parameters.AddWithValue("@isAlcoholic", drink.DrinkType);
            command.Parameters.AddWithValue("@stockId", drink.DrinkId);
            command.ExecuteNonQuery();
        }  
        public void AddNewStock(int drink, int stock)
        {
            
            SqlCommand command = new SqlCommand("INSERT INTO Stock (stock_id ,stock_amount)" +
              "VALUES (@StockId, @Stock_amount);", OpenConnection());
            command.Parameters.AddWithValue("@StockId", drink);
            command.Parameters.AddWithValue("@Stock_amount", stock);
            command.ExecuteNonQuery();
            
            
        }
        public void AddDrinkStock(int drink)
        {
            SqlCommand command = new SqlCommand("UPDATE Stock SET stock_amout = stock_amount + 1 " +
                "FROM Stock WHERE stock_id = @id", OpenConnection());
            command.Parameters.AddWithValue("@id", drink);
            command.ExecuteNonQuery();
        }  
        public void RemoveDrinkStock(int drink)
        {
            
            SqlCommand command = new SqlCommand("UPDATE Stock SET stock_amount = stock_amount - 1 " +
                "FROM Stock WHERE stock_id = @id");
            command.Parameters.AddWithValue("@id", drink);
            command.ExecuteNonQuery();
        }

        private List<Drink> ReadTables(DataTable dataTable, DataTable secondDataTable)
>>>>>>> Stashed changes
        {
            List<Drink> drinks = new List<Drink>();
            DataRow drinkRow = dataTable.NewRow();
            DataRow stockRow = secondDataTable.NewRow();
            

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkId = (int)dr["drink_id"],
                    DrinkName = (string)(dr["drinkName"]),
                    DrinkPrice = (float)(dr["drink_price"]),
                    DrinkType = (bool)(dr["isAlcoholic"])
                };
                drinks.Add(drink);
            }
<<<<<<< Updated upstream
=======

           
            
          
>>>>>>> Stashed changes
            return drinks;
        }
    }
}
