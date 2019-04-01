using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Platform
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public virtual ICollection<User> Admins { get; set; }

/*      public Platform(string name, ICollection<User> admins)
        {
            Name = name;
            Admins = admins;
        }*/
    }
}