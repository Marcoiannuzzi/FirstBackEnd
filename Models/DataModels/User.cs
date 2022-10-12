using System.ComponentModel.DataAnnotations;

namespace FirstBackEnd.Models.DataModels
{
    public class User:BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }=String.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; }= String.Empty;
        [Required,EmailAddress]
        public string EmailAddress { get; set; }=String.Empty;
        [Required]
        public string Password { get; set; }=String.Empty;

    }
}
