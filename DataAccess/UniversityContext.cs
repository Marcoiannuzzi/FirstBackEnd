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
        public DbSet<Curso>? Curso { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Alumno>? Alumnos { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
    }
}
 