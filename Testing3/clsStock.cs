using System;

namespace Testing3
{
    internal class clsStock
    {
        public int StockID { get; internal set; }
        public string Brand { get; internal set; }
        public string Colour { get; internal set; }
        public string TypeOfCar { get; internal set; }
        public bool Gearbox { get; internal set; }
        public DateTime YearOfCar { get; internal set; }
        public int Prices { get; internal set; }
    }
}