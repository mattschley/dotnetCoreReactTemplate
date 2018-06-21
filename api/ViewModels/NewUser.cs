using System.ComponentModel.DataAnnotations;

namespace aspnetCoreReactTemplate.ViewModels
{
    public class NewUser
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
}
}
