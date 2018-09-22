using System.Data.Entity;
using Week5Demo.Domain.Entities;

namespace Week5Demo.Domain
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base()
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
