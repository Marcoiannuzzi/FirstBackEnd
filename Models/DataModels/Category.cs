using Microsoft.Build.Framework;

namespace FirstBackEnd.Models.DataModels
{
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }=String.Empty;
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    }
}
