using System.Numerics;

namespace kendoTest.Models
{
    public class LedgerEntry414ka
    {
        public int SNO { get; set; }

        public Double Total { get; set; }

        public double Tax { get; set; }

        public double AggregateCost {get; set;}

        public double TotalCost { get; set;}


        public class Return
        {
            public string productname { get; set; }
            public int Unit { get; set; }

            public double Amount { get; set; }

            public double Total { get; set; }
        }
        public class expenses
        {
            public string Description { get; set; }

            public string Price { get; set; }


        }

    }








    }

