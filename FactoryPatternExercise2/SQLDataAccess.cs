using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ name = "Towel", price = 20},
            new Product(){ name = "Toilet Paper", price = 10},
            new Product() { name = "Soap", price = 10}
        };

        public void SaveData()
        {

            Console.WriteLine("I am saving data to a SQL database");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access");
            return Products;
        }
    }
}
