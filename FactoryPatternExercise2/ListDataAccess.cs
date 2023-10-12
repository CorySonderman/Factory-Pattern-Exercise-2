using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            new Product() {Name = "Assorted 80's rock merch", Price = 85},
            new Product() {Name = "A day with Ozzie Ozborn", Price = 1500},
            new Product() {Name = "Guitar lesson from Ted Nugent", Price = 500},
            new Product() {Name = "A trip to Jumanji with you favoriate celebrity", Price = 2500},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine();
            Console.WriteLine("I am reading data from List Data Access");

            return Products;

        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List database");

        }
    }
}