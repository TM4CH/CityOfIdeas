using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.VoteClasses
{
    public class Vote
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}
