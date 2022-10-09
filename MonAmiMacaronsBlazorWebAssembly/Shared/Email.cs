using System.ComponentModel.DataAnnotations;

namespace MonAmiMacaronsBlazorWebAssembly.Shared
{
    public class Email
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Subject { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string From { get; set; } = string.Empty;     

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(1000, MinimumLength = 10)]
        public string Body { get; set; } = string.Empty ;
    }
}
