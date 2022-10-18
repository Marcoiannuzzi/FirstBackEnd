using System.ComponentModel.DataAnnotations;

namespace FirstBackEnd.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medium,
        Advance,
        expert
    }

    public class Curso:BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescripcion { get; set; } = string.Empty;
        [Required]
        public string Descripcion { get; set; } = string.Empty;
        public Level Level { get; set; } = Level.Basic;
        [Required]
        public ICollection<Category>Categories { get; set; } = new List<Category>();
        [Required]
        public ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();
        [Required]
        public Chapter Chapters { get; set; } = new Chapter();


}
}
