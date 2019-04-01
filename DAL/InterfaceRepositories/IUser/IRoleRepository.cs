using System.Collections.Generic;
using Domain.User;

namespace DAL.IUser
{
    public interface IRoleRepository
    {
        /*
         *     CRUD Role
         */
        
        //Create Methods
        Role CreateRole(Role role);
        
        //Read Methods
        IEnumerable<Role> ReadRole();
        Role ReadRole(string id);
        
        //Update Methods
        void UpdateRole(Role role);
        
        //Delete Methods
        void DeleteRole(string id);
    }
}