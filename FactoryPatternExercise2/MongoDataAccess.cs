﻿using System;
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
            new Product() {Name = "Private self defense lesson", Price = 150},
            new Product() {Name = "Prime swamp land next to Shrek", Price = 15000},
            new Product() {Name = "Shiny new toaster oven(Almost new)", Price = 20},
            new Product() {Name = "Pet rock", Price = 5},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine();
            Console.WriteLine("I am reading data from Mongo Data Access");

            return Products;

        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }
}