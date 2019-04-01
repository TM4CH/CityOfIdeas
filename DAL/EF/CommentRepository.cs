using System.Collections.Generic;
using DAL.IProject.IIdeation;
using Domain.Project;

namespace DAL.EF
{
    public class CommentRepository : ICommentRepository
    {
        //Fields
        private ApplicationDbContext _ctx;
        

        //Constructors
        public CommentRepository()
        {
            _ctx = new ApplicationDbContext();
        }
        

        #region CRUD
        
        /*
         *     CRUD Comment
         */
        
        //Create Methods
        public Comment CreateComment(Comment comment)
        {
            throw new System.NotImplementedException();
        }

        //Read Methods
        public IEnumerable<Comment> ReadComment()
        {
            throw new System.NotImplementedException();
        }

        public Comment ReadComment(string id)
        {
            throw new System.NotImplementedException();
        }

        //Update Methods
        public void UpdateComment(Comment comment)
        {
            throw new System.NotImplementedException();
        }

        //Delete Methods
        public void DeleteComment(string id)
        {
            throw new System.NotImplementedException();
        }
        
        #endregion
    }
}