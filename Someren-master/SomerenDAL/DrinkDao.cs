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

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

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
            return drinks;
        }
    }
}
