using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class DrinkService
    {
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

        public void ChangeDrinkName(String name, int id)
        {
            drinkdb.ChangeDrinkName(name, id);
        }
    }
}
