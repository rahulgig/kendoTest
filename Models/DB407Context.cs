using Microsoft.EntityFrameworkCore;

namespace kendoTest.Models
{
    public class DB407Context : DbContext
    {
        public DB407Context(DbContextOptions<DB407Context> opts) : base(opts)
        {
        }

        public DbSet<Report407Model> Report407 { get; set; }
    }
}
