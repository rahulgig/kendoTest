namespace kendoTest.Models
{
    public class Report417LandDetails
    {
        public int SNo { get; set; }
        public LandLocation LandLocation { get; set; }
        public LandDetails LandDetails { get; set; }

        public LandOwnerDetails LandOwnerDetails { get; set; }
        public LandAcquirementDetails LandAcquirementDetails { get; set; }
        public LandUsageDetails LandUsageDetails { get; set; }
        public string Remarks { get; set; }
    }
    public class LandLocation
    {
        public string District { get; set; }
        public string LocalLevel { get; set; }
        public int WardNumber { get; set; }

    }
    public class LandDetails
    {
        public string MapSeatNumber { get; set; }
        public string KittaNumber { get; set; }
        public double Area { get; set; }
        public string Type { get; set; }

    }
    public class LandOwnerDetails
    {
        public string Name { get; set; }
        public string CertificateNumber { get; set; }

    }
    public class LandAcquirementDetails
    {
        public DateTime Date { get; set; }
        public double Price { get; set; }

    }
    public class LandUsageDetails
    {
        public double SelfUse { get; set; }
        public LeaseOccupancyDetails LeaseOccupancyDetails { get; set; }
        public bool StructureIsPresent { get; set; }
        
    }
    public class LeaseOccupancyDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Purpose { get; set; }
    }

}
