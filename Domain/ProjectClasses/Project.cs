using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.PlatformClasses;
using Domain.ProjectClasses.PhaseClasses;
using Domain.UserClasses;

namespace Domain.ProjectClasses
{
    public class Project
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required] public virtual Platform Platform { get; set; }
    }
}
