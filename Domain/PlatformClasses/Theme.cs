using System.ComponentModel.DataAnnotations;

namespace Domain.PlatformClasses
{
    public class Theme
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Font { get; set; }
        [Required]
        public string BackgroundColor { get; set; }
        [Required]
        public string Color { get; set; }
    }
}