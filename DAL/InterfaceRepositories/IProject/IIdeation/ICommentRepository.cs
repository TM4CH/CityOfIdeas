using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.IIdeation
{
    public interface ICommentRepository
    {
        /*
         *     CRUD Comment
         */
        
        //Create Methods
        Comment CreateComment(Comment comment);
        
        //Read Methods
        IEnumerable<Comment> ReadComment();
        Comment ReadComment(string id);
        
        //Update Methods
        void UpdateComment(Comment comment);
        
        //Delete Methods
        void DeleteComment(string id);
    }
}