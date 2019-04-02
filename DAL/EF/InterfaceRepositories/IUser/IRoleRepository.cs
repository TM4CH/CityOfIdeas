using System.Collections.Generic;
using Domain.UserClasses;

namespace DAL.IUser
{
    public interface IRoleRepository
    {
        /*
         *     CRUD Role
         */
        
        //Create Methods
        void CreateRole(Role role);
        
        //Read Methods
        IEnumerable<Role> ReadAllRoles();
        Role ReadRole(string id);
        
        //Update Methods
        void UpdateRole(Role role);
        
        //Delete Methods
        void DeleteRole(string id);
    }
}