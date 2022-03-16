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
        private bool drinkType;
        private float drinkPrice;

        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public float DrinkPrice {
            get {
                if (drinkType == true)
                {
                    return (drinkPrice + (drinkPrice * 0.21f));
                }
             
                    return drinkPrice + (drinkPrice * 0.06f);
                
                }
            set => drinkPrice = value;
        }

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

    }
}
