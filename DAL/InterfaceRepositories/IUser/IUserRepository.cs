using System.Collections.Generic;
using Domain.User;

namespace DAL.IUser
{
    public interface IUserRepository
    {
        /*
         *     CRUD User
         */
        
        //Create Methods
        User CreateUser(User user);
        
        //Read Methods
        IEnumerable<User> ReadUser();
        User ReadUser(string id);
        
        //Update Methods
        void UpdateUser(User user);
        
        //Delete Methods
        void DeleteUser(string id);
    }
}