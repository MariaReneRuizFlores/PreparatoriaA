using System.Data.Entity;

namespace PreparatoriaA.Models
{
    public class DataContext : DbContext
    {

        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PreparatoriaA.Models.Student> Students { get; set; }
    }
}
