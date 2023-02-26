namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctIput;
            do
            {
                Console.Clear();
                correctIput = true;
                Console.WriteLine("What database would you like to work with?");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: mongo");
                Console.WriteLine("Type: list");

                userInput = Console.ReadLine().ToLower();
                if (userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctIput = false;
                    Console.WriteLine("Wrong iput");
                    Thread.Sleep(1000);
                }


            } while (!correctIput);

            

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();

            db.SaveData();

            foreach(var product in products )
            {
                Console.WriteLine($"Name: {product.name} Price: ${product.price}");
            }

        }
    }
}
