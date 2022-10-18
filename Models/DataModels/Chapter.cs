using Microsoft.Build.Framework;

namespace FirstBackEnd.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        [Required]
        public string Chapters { get; set; } = string.Empty;

        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
