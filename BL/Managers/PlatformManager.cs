using System.Collections.Generic;
using BL.InterfaceManagers.IPlatformManagers;
using DAL;
using DAL.EF.Repositories.PlatformRepositories;
using Domain;

namespace BL.Managers
{
    public class PlatformManager : IPlatformManager
    {
        private readonly IPlatformRepository _repo;

        public PlatformManager()
        {
            _repo = new PlatformRepository();
        }
        
        #region CRUD
        
        /*
         *     CRUD Platform
         */

        //Add Methods
        public void AddPlatform(Platform platform)
        { 
            _repo.CreatePlatform(platform);
        }

        //Get Methods
        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _repo.ReadAllPlatforms();
        }

        public Platform GetPlatform(string id)
        {
            return _repo.ReadPlatform(id);
        }
        
        public Platform GetPlatformByName(string name)
        {
            return _repo.ReadPlatformByName(name);
        }

        //Set Methods
        public void SetPlatform(Platform ticket)
        {
            _repo.UpdatePlatform(ticket);
        }

        //Remove Methods
        public void RemovePlatform(string id)
        {
            _repo.DeletePlatform(id);
        }

        #endregion
    }
}