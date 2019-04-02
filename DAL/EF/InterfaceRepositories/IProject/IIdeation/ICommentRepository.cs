using System.Collections.Generic;
using Domain.ProjectClasses.IdeationClasses;

namespace DAL.IProject.IIdeation
{
    public interface ICommentRepository
    {
        /*
         *     CRUD Comment
         */
        
        //Create Methods
        void CreateComment(Comment comment);
        
        //Read Methods
        IEnumerable<Comment> ReadAllComments();
        Comment ReadComment(string id);
        
        //Update Methods
        void UpdateComment(Comment comment);
        
        //Delete Methods
        void DeleteComment(string id);
    }
}