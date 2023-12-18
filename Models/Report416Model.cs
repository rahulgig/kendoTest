﻿namespace kendoTest.Models
{
    public class Report416Model
    {
        public List<PreparedByModel> preparedByModels { get; set; }
        public List<AcceptedByModel> acceptedByModels { get; set; }

        public class Property
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string CodeNumber { get; set; }
            public string IdentificationNumber { get; set; }
            public string Model { get; set; }
            public string Specification { get; set; }
            public decimal Value { get; set; }
            public bool GivenOrTaken { get; set; }


        }
       





    }
}