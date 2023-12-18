namespace kendoTest.Models
{
    public class LedgerEntry418
    {
        public class ProductModel
        {
            public int SerialNumber { get; set; }

            public string Model { get; set; }

            public string IdentificationNumber { get; set; }

            public string Specification { get; set; }

            public int Quantity { get; set; }

            public decimal StartingPrice { get; set; }

            public DateTime PurchaseOrAcquisitionDate { get; set; }

            // Asset Valuation Details
            public class AssetValuationDetails
            {
                public decimal PreviousYearBookValue { get; set; }

                public decimal AdditionalOrReducedAmount { get; set; }

                public decimal TotalDepreciationUntilLastYear { get; set; }

                public decimal DepreciationForThisYear { get; set; }

                public decimal TotalDepreciationForThisYear { get; set; }

                public decimal CurrentYearBookValue { get; set; }

                // Summary Information

                public string Remarks { get; set; }
            }

        }
    }
}

