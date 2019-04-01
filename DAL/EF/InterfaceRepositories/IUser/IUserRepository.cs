using System.Collections.Generic;
using Domain;

namespace DAL.IUser
{
    public interface IUserRepository
    {
        /*
         *     CRUD User
         */
        
        //Create Methods
        void CreateUser(User user);
        
        //Read Methods
        IEnumerable<User> ReadAllUsers();
        User ReadUser(string id);
        
        //Update Methods
        void UpdateUser(User user);
        
        //Delete Methods
        void DeleteUser(string id);
    }
}