using System.Collections.Generic;
using Domain;

namespace DAL.IVote
{
    public interface IVoteRepository
    {
        /*
         *     CRUD Vote
         */
            
        //Create Methods
        void CreateVote(Vote vote);
        
        //Read Methods
        IEnumerable<Vote> ReadAllVotes();
        Vote ReadVote(string id);
        
        //Update Methods
        void UpdateVote(Vote vote);
        
        //Delete Methods
        void DeleteVote(string id);
    }
}