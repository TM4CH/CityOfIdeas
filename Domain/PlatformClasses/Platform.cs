using Domain.UserClasses;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.PlatformClasses
{
    public class Platform
    {
        [Key] public string Id { get; set; }
        [Required] public bool IsDistrict { get; set; }
        [Required] public string Name { get; set; }
        public string Url { get; set; }
        [Required] public string Logo { get; set; }
        [Required] public virtual PlatformSettings Settings { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}