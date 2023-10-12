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
            new Product() {Name = "Weekly private island rental", Price = 23500},
            new Product() {Name = "Assorted autographed Philadelphia Eagles jersey", Price = 750},
            new Product() {Name = "Vintage Show Biz Pizza T-shirt", Price = 50},
            new Product() {Name = "Little rubber bouncing ball", Price = 0.25},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine();
            Console.WriteLine("I am reading data from SQL Data Access");

            return Products;

        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}