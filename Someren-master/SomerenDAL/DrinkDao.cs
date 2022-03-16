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
            string query = "SELECT drink_id, drinkName, drink_price, stock.stock_amount FROM [Drink] JOIN [Stock] ON Drink.stock_id = Stock.stock_id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    DrinkPrice = (int)(dr["drink_price"]),
                   // DrinkType = (bool)(dr["isAlcoholic"]),
                   // DrinkStock = (int)(dr["Stock.stock_amount"])
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void AddSale(Student student, Drink drink)
        {
            SqlCommand command = new SqlCommand("INSERT INTO RegisterScreen (drink_id, student_id, sales_date)" + 
                "VALUES (@drink_id, @student_id, @sales_date)");
            command.Parameters.AddWithValue("@drink_id", drink.DrinkId);
            command.Parameters.AddWithValue("@student_id", student.Number);
            command.Parameters.AddWithValue("@sales_date", DateTime.Now);
            command.ExecuteNonQuery();
        }
    }
}
