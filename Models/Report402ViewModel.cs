namespace kendoTest.Models
{
    public class Report402ViewModel: Report400BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }
        public string PhoneNumber { get; set; }
        public int PurchaseOrderNo { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        public string PurchaseDecisionNo { get; set; }

        public DateTime PurchaseDecisionDate { get; set; }

        public List<Report402StocksModel> StocksAndAssets { get; set; }

        public float TotalAmount { get; set; }

        public PersonBaseModel PreparedBy {  get; set; }

        public DateTime PreparedDate { get; set; }

        public PersonBaseModel RecommendedBy { get; set; }

        public DateTime RecommendDate { get; set; }

        public string BudgetSubTitleNo { get; set; }

        public string ExpenseTitleNo { get; set; }

        public string ActivityNo { get; set; }

        public string EconomicAdministrationBranch {  get; set; }

        public PersonBaseModel AdministrativeBranchRep { get; set; }

        public DateTime AdministrativeDate { get; set; }
        public PersonBaseModel AcceptedBy { get; set; }

        public DateTime AcceptedDate { get; set;}

        public DateTime DeliveryDate { get; set; }

        public string DeliveringEntity { get; set; }



    }
}
