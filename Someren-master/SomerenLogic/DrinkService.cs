using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkService
    {
<<<<<<< Updated upstream
=======
        DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAll();
            return drinks;
        }
        public void AddSale(Student student, Drink drink)
        {
            drinkdb.AddSale(student, drink);
        }

        public void AddDrink(Drink drink)
        {
            drinkdb.AddDrink(drink);
        }

        public void AddDrinkStock(int id)
        {
            drinkdb.AddDrinkStock(id);
        }

        public void AddNewStock(int id, int stock)
        {
            drinkdb.AddNewStock(id, stock);
        }

        public void RemoveDrinkStock(int id)
        {
            drinkdb.RemoveDrinkStock(id);
        }
>>>>>>> Stashed changes
    }
}
