using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace kendoTest.ViewModels
{
    public class FormDetails
    {
        public Form404Model? Form{ get; set; }
        public string Mantralaya { get; set; }
        public string Karlaya { get; set; }
        public int financialyear { get; set; }
        public int KharchaNikasaNo { get; set; }
        public int KharchaFormNumber { get; set; }
        public DateTime Datetime { get; set; }

    }
}
