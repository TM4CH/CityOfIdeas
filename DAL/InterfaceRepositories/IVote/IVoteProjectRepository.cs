using System.Collections.Generic;
using Domain.Vote;

namespace DAL.IVote
{
    public interface IVoteProjectRepository
    {
        /*
         *     CRUD VoteProject
         */
        
        //Create Methods
        VoteProject CreateVoteProject(VoteProject voteProject);
        
        //Read Methods
        IEnumerable<VoteProject> ReadProject();
        VoteProject ReadVoteProject(string id);
        
        //Update Methods
        void UpdateVoteProject(VoteProject voteProject);
        
        //Delete Methods
        void DeleteVoteProject(string id);
    }
}