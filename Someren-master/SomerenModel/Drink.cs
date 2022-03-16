using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
       
        private int drinkStock;

        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public int DrinkPrice {get; set; }

        public int DrinkStock { 
            
            get => this.drinkStock;

            set 
            { 
                if (this.drinkStock > value)
                {
                    this.drinkStock = value;
                }
            } 
        }
        
        public bool DrinkType {get; set; } // if true drink is alcoholic


        public Drink(int drinkId)
        {
            DrinkId = drinkId;
        }

        public Drink()
        {}
    }
}
