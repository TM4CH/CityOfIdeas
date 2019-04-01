using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.IIdeation
{
    public interface ITagRepository
    {
        /*
         *     CRUD Tag
         */
        
        //Create Methods
        Tag CreateTag(Tag tag);
        
        //Read Methods
        IEnumerable<Tag> ReadTag();
        Tag ReadTag(string id);
        
        //Update Methods
        void UpdateTag(Tag tag);
        
        //Delete Methods
        void DeleteTag(string id);
    }
}