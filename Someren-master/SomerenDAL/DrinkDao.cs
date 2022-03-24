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
            string querry = "INSERT INTO RegisterScreen (drink_id, student_id, sales_date)" + 
                "VALUES (@drink_id, @student_id, @sales_date)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@drink_id", drink.DrinkId);
            sqlParameters[1] = new SqlParameter("@student_id", student.Number);
            sqlParameters[2] = new SqlParameter("@sales_date", DateTime.Now.ToString("yyyy/MM/dd"));
            ExecuteEditQuery(querry, sqlParameters);
        }
        public void AddDrink(Drink drink)
        {
            String querry = "INSERT INTO dbo.Drink (drink_id, drinkName, isAlcoholic, Drink.stock_id)" +
                "VALUES (@DrinkId, @DrinkName, @isAlcoholic, @stockId);";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@DrinkName", drink.DrinkName);
            sqlParameters[1] = new SqlParameter("@isAlcoholic", drink.DrinkType);
            sqlParameters[2] = new SqlParameter("@stockId", drink.DrinkId);
            sqlParameters[3] = new SqlParameter("@DrinkId", drink.DrinkId);
            ExecuteEditQuery(querry, sqlParameters);    
        }  

        public void ChangeDrinkName(string newNAme, int id)
        {
            string querry = "UPDATE dbo.Drink SET Drink.drinkName = @NewName WHERE drink_id = @DrinkID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@NewName", newNAme);
            sqlParameters[1] = new SqlParameter("@DrinkID", id);
            ExecuteEditQuery(querry, sqlParameters);
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
