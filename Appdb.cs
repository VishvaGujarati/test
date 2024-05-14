using Microsoft.EntityFrameworkCore;
using test.Models.entity;

namespace test.Data
{
    public class Appdb:DbContext
    {
        public Appdb(DbContextOptions<Appdb> options):base(options) 
        {
            
        }
        public DbSet <v1> v1s { get; set; }
    }
}
