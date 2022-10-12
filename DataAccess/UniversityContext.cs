using FirstBackEnd.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FirstBackEnd.DataAccess
{
    public class UniversityContext:DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
            
        }

        //TODO: add DbSet (tables of our data base)
        public DbSet<User>? Users { get; set; }
    }
}
