using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Project.Phase
{
    public class Phase
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public int PhaseNumber { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public virtual Project Project { get; set; }
    }
}
