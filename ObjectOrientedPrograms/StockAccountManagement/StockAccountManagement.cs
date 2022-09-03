namespace ObjectOrientedPrograms.StockAccountManagement
{
    internal class StockAccountManagement
    {
        private List<Stock> LstOfStocks;

        public StockAccountManagement()
        {
            LstOfStocks = new List<Stock>();
        }

        public void AddStock(Stock stockData)
        {
            if (stockData != null)
            {
                LstOfStocks.Add(stockData);
            }
        }

        public List<Stock> GetAllStockDetails()
        {
            return LstOfStocks;
        }
    }
}
