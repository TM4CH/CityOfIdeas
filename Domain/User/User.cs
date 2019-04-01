using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain.User
{
    public class User : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual ICollection<Vote.Vote> Votes { get; set; }
    }
}
