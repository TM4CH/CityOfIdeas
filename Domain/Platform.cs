using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Platform
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public virtual ICollection<User.User> Admin { get; set; }
        
    }
}