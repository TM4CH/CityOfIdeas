using System;
using System.Collections.Generic;
using Domain.PlatformClasses;
using Domain.VoteClasses;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class User : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual Platform Platform { get; set; }

    }
}
