using System.Collections.Generic;
using Domain;

namespace BL.InterfaceManagers.IPlatformManagers
{
    public interface IPlatformManager
    {
        /*
         *     CRUD Platform
         */
        
        //Create Methods
        void AddPlatform(Platform platform);
        
        //Read Methods
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatform(string id);
        Platform GetPlatformByName(string name);
        
        //Update Methods
        void SetPlatform(Platform ticket);
        
        //Delete Methods
        void RemovePlatform(string id);
    }
}