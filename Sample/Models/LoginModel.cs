using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? EmailId { get; set; }

        [Required]
        [StringLength(14)]
        public string? Password { get; set; }

    }
}
