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
        public decimal DrinkPrice {get; set; }

        public int DrinkStock { 
            
            get => this.drinkStock;

            set 
            { 
                if (this.drinkStock >= 0)
                {
                    this.drinkStock = value;
                }
            } 
        }
        
        public bool DrinkType {get; set; } // if true drink is alcoholic


        public string AlcoholCheck()
        {
            if(DrinkType == false) // shows Non or Is alcoholic in the list
            {
                return "Non ";
            }
            return "Is";
        }
    }
}
