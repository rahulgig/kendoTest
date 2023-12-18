

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kendoTest.Models
{
    public class Report404ModelSubField
    {
        [Key]
        public int Id { get; set; }
        //public long ReportId { get; set; }
        public long SN { get; set; }
        public string? Symbol_No { get; set; }
        public string Specificatin_No { get; set; }
        public string Akin_no { get; set; }
        public string Quantity { get; set; }
        public string Rate { get; set; }
        public long Total { get; set; }
        public string Remark { get; set; }

        public long ReportId { get; set; }
        [ForeignKey("ReportId")]
        public Report404ViewModel Report404Model { get; set; }

    }
}