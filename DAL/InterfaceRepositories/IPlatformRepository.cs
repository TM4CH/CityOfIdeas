using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IPlatformRepository
    {
        /*
         *     CRUD Platform
         */
        
        //Create Methods
        Platform CreatePlatform(Platform platform);
        
        //Read Methods
        IEnumerable<Platform> ReadPlatform();
        Platform ReadPlatform(string id);
        
        //Update Methods
        void UpdatePlatform(Platform ticket);
        
        //Delete Methods
        void DeletePlatform(string id);
    }
}