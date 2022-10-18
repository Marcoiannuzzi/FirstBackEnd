using System.ComponentModel.DataAnnotations;

namespace FirstBackEnd.Models.DataModels
{
    public class Alumno: BaseEntity
    {
        [Required, StringLength(50)]
        public string FirstName { get; set; } = String.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; } = String.Empty;
        [Required]
        public DateTime Dob { get; set; }
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    }
}
