using System.ComponentModel.DataAnnotations;

namespace ClientLibrary.Models.Authentication
{
    public class AuthenticationBase
    {
        [EmailAddress, Required]
        public string? EmailAddress { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
