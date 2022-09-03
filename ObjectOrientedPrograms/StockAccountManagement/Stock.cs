namespace ObjectOrientedPrograms.StockAccountManagement
{
    internal class Stock
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public double Price { get; set; }
        public int NoOfShares { get; set; }
        public double TotalValue
        {
            get
            {
                double totalValueOfStock = Price * NoOfShares;
                return totalValueOfStock;
            }
        }
    }
}
