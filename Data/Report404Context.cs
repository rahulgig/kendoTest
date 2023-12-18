using kendoTest.Models;
using Microsoft.EntityFrameworkCore;

namespace kendoTest.Data
{

    public class Report404Context:DbContext
    {
        public  Report404Context(DbContextOptions <Report404Context> options): base(options)
        {
            
        }
       // public DbSet<PersonBase> PersonBase {  get; set; }
        public DbSet<AcceptedByModel> AcceptedByModel { get; set;}
        public DbSet<PreparedByModel> PreparedByModel { get; set;}
        public DbSet<RecommendedByModel> RecommendedByModel { get;set;} 
        /*public DbSet<Report400BaseModel> Report400BaseModel { get; set;}  */  
        public DbSet<Report404ViewModel> Report404Models { get; set;}   
        public DbSet<Report404ModelSubField> Report404SubForms { get; set;}
    }
}
