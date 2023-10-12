namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.DarkCyan ;
            Console.WriteLine("What database would you like to work with?");
            Console.WriteLine("Please only type: sql, mongo, or list.  " +
                "Otherwise you will get the default.");
            //Could use a do/while to avoid user error but I am
            //trying to get though other assignments as well.  
            var input = Console.ReadLine();
            var database = DataAccessFactory.GetDataAccessType(input);
            var products = database.LoadData();
            

            foreach (var product in products)
            {
                
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Get it NOW for only ${product.Price}!!!");
                Console.WriteLine();

            }
            database.SaveData();
            Console.ResetColor();
        }
    }
}
