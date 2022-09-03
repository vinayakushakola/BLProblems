using ObjectOrientedPrograms.StockAccountManagement;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Object Oriented Programs ========");

            bool start = true;
            while (start)
            {
                Console.WriteLine("1. Stock Account Management");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice from [1 - 2] = ");
                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        StockAccountHandler.StockHandler();
                        break;
                    case 2:
                        start = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}