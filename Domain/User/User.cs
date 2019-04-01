using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain.User
{
    public class User : IdentityUser
    {
        public virtual ICollection<Vote.Vote> Votes { get; set; }
    }
}
