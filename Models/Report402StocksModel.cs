namespace kendoTest.Models
{
    public class Report402StocksModel: ItemsBaseModel
    {
        public string SignalNumber { get; set; }

        public string Model { get; set; }

        public QuantitiesModel Quantities { get; set; }

        public float Rate { get; set; }

        public float Total {  get; set; }

        


    }
}
