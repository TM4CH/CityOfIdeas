using Domain.ProjectClasses.IdeationClasses;
using System.Collections.Generic;

namespace DAL.IProject.IIdeation
{
    public interface ITagRepository
    {
        /*
         *     CRUD Tag
         */
        
        //Create Methods
        void CreateTag(Tag tag);
        
        //Read Methods
        IEnumerable<Tag> ReadAllTags();
        Tag ReadTag(string id);
        
        //Update Methods
        void UpdateTag(Tag tag);
        
        //Delete Methods
        void DeleteTag(string id);
    }
}