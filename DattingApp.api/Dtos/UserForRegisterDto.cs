using System.ComponentModel.DataAnnotations;

namespace DattingApp.api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4,ErrorMessage= " you must specify password between 4 to 8 charachters")]
        public string Password { get; set; }
    }
}