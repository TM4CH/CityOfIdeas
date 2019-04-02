using System;
using System.Collections.Generic;
using Domain.VoteClasses;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class User : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
