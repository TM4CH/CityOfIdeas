using System;
using System.Collections.Generic;
using Domain.PlatformClasses;
using Domain.UserClasses;

namespace BL.InterfaceManagers.IPlatformManagers
{
    public interface IPlatformManager
    {
        /*
         *     CRUD Platform
         */
        
        //Create Methods
        void AddPlatform(String name, ICollection<User> admins);
        
        //Read Methods
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatform(string id);
        Platform GetPlatformByName(string name);
        
        //Update Methods
        void SetPlatform(Platform platform);
        
        //Delete Methods
        void RemovePlatform(string id);
    }
}