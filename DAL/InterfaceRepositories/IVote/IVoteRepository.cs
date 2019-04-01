using System.Collections.Generic;
using Domain.Vote;

namespace DAL.IVote
{
    public interface IVoteRepository
    {
        /*
         *     CRUD Vote
         */
            
        //Create Methods
        Vote CreateVote(Vote vote);
        
        //Read Methods
        IEnumerable<Vote> ReadVote();
        Vote ReadVote(string id);
        
        //Update Methods
        void UpdateVote(Vote vote);
        
        //Delete Methods
        void DeleteVote(string id);
    }
}