namespace ObjectOrientedPrograms.StockAccountManagement
{
    internal class StockAccountHandler
    {
        private static StockAccountManagement objStockAccountManagement;

        static StockAccountHandler()
        {
            objStockAccountManagement = new StockAccountManagement();
        }

        public static void StockHandler()
        {
            bool start = true;

            while (start)
            {
                Console.WriteLine("1. Add Stock");
                Console.WriteLine("2. Print Stock Details");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice from [1 - 3] = ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the number of stock details you want to add = ");
                        int NoOfStocks = int.Parse(Console.ReadLine());
                        for (int i = 1; i < NoOfStocks; i++)
                        {
                            objStockAccountManagement.AddStock(ReadStockDetails());
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nOutput: ");
                        PrintStockDetails(objStockAccountManagement.GetAllStockDetails());
                        break;
                    case 3:
                        start = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }

        private static Stock ReadStockDetails()
        {
            Stock stock = new Stock();
            Console.Write("Enter Stock Name = ");
            stock.Name = Console.ReadLine();
            Console.Write("Enter Stock Price = ");
            stock.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number of Shares = ");
            stock.NoOfShares = int.Parse(Console.ReadLine());
            return stock;
        }

        private static void PrintStockDetails(List<Stock> lstOfStocks)
        {
            foreach (Stock stockData in lstOfStocks)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Share Name: {0}", stockData.Name);
                Console.WriteLine("Share Price: {0}", stockData.Price);
                Console.WriteLine("No of Shares: {0}", stockData.NoOfShares);
                Console.WriteLine("Total Value: {0}", stockData.TotalValue);
                Console.WriteLine("========================================");
            }
            Console.WriteLine();
        }
    }
}
