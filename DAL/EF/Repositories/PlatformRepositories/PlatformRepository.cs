using System.Collections.Generic;
using System.Linq;
using Domain;

namespace DAL.EF.Repositories.PlatformRepositories
{
    public class PlatformRepository : IPlatformRepository
    {
        //Fields
        private ApplicationDbContext _ctx;
        

        //Constructors
        public PlatformRepository()
        {
            _ctx = new ApplicationDbContext();
        }
        

        #region CRUD
        
        /*
         *     CRUD Platform
         */

        //Create
        public void CreatePlatform(Platform platform)
        {
            _ctx.Platforms.Update(platform);    //Vragen aan knikkertje
            _ctx.SaveChanges();
        }

        //Read
        public IEnumerable<Platform> ReadAllPlatforms()
        {
            return _ctx.Platforms.AsEnumerable();
        }

        public Platform ReadPlatform(string id)
        {
            return _ctx.Platforms.Find(id);
        }
        
        public Platform ReadPlatformByName(string name)
        {
            return _ctx.Platforms.FirstOrDefault(platform => platform.Name.Equals(name));
        }

        //Update
        public void UpdatePlatform(Platform platform)
        {
            _ctx.Platforms.Update(platform);
            _ctx.SaveChanges();
        }
        
        //Delete
        public void DeletePlatform(string id)
        {
            _ctx.Platforms.Remove(ReadPlatform(id));
            _ctx.SaveChanges();
        }

        #endregion
    }
}