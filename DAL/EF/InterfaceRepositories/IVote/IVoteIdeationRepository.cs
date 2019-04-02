using System.Collections.Generic;
using Domain;
using Domain.VoteClasses;

namespace DAL.IVote
{
    public interface IVoteIdeationRepository
    {
        /*
         *     CRUD VoteIdeation
         */
        
        //Create Methods
        void CreateVoteIdeation(VoteIdeation voteIdeation);
        
        //Read Methods
        IEnumerable<VoteIdeation> ReadAllVoteIdeations();
        VoteIdeation ReadVoteIdeation(string id);
        
        //Update Methods
        void UpdateVoteIdeation(VoteIdeation voteIdeation);
        
        //Delete Methods
        void DeleteVoteIdeation(string id);
    }
}