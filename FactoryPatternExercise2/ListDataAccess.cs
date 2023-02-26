using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ name = "Blender", price = 300},
            new Product(){ name = "Microwave", price = 300},
            new Product() { name = "Coffee Pot", price = 100 }
        };

        public void SaveData()
        {

            Console.WriteLine("I am saving data to a List database");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access");
            return Products;
        }
    }
}
