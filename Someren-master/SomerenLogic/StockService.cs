using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class StockService
    {
        StockDao stockDao;

        public StockService()
        {
            this.stockDao = new StockDao();
        }

        public List<Stock> GetAll()
        {
            return stockDao.GetAll();
        }
        public void AddDrinkStock(int id)
        {
            stockDao.AddDrinkStock(id);
        }

        public void AddNewStock(Stock id)
        {
            stockDao.AddNewStock(id);
        }

        public void RemoveDrinkStock(int id)
        {
            stockDao.RemoveDrinkStock(id);
        }
    }
}
