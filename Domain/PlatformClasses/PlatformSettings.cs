using System.ComponentModel.DataAnnotations;

namespace Domain.PlatformClasses
{
    public class PlatformSettings
    {
        [Key] public string Id { get; set; }
        public virtual Theme Theme { get; set; }
        public int FontSize { get; set; }
    }
}