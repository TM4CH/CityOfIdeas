using System.Collections.Generic;
using Domain.Vote;

namespace DAL.IVote
{
    public interface IVoteIdeationRepository
    {
        /*
         *     CRUD VoteIdeation
         */
        
        //Create Methods
        VoteIdeation CreateVoteIdeation(VoteIdeation voteIdeation);
        
        //Read Methods
        IEnumerable<VoteIdeation> ReadVoteIdeations();
        VoteIdeation ReadVoteIdeation(string id);
        
        //Update Methods
        void UpdateVoteIdeation(VoteIdeation voteIdeation);
        
        //Delete Methods
        void DeleteVoteIdeation(string id);
    }
}