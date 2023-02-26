using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ name = "XBox", price = 300},
            new Product(){ name = "Playstation", price = 300},
            new Product() { name = "Switch", price = 250 }
        };

        public void SaveData()
        {
            
            Console.WriteLine("I am saving data to a mongo database");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access");
            return Products;
        }
    }
}
