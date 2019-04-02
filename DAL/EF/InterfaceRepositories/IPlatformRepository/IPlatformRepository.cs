using System.Collections.Generic;
using Domain;
using Domain.PlatformClasses;

namespace DAL
{
    public interface IPlatformRepository
    {
        /*
         *     CRUD Platform
         */
        
        //Create Methods
        void CreatePlatform(Platform platform);
        
        //Read Methods
        IEnumerable<Platform> ReadAllPlatforms();
        Platform ReadPlatform(string id);
        Platform ReadPlatformByName(string name);
        
        //Update Methods
        void UpdatePlatform(Platform ticket);
        
        //Delete Methods
        void DeletePlatform(string id);
    }
}