using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Vote
{
    public class Vote
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public virtual User.User User { get; set; }
    }
}
