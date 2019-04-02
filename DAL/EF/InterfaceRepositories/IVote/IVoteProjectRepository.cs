using System.Collections.Generic;
using Domain;
using Domain.VoteClasses;

namespace DAL.IVote
{
    public interface IVoteProjectRepository
    {
        /*
         *     CRUD VoteProject
         */
        
        //Create Methods
        void CreateVoteProject(VoteProject voteProject);
        
        //Read Methods
        IEnumerable<VoteProject> ReadAllVoteProjects();
        VoteProject ReadVoteProject(string id);
        
        //Update Methods
        void UpdateVoteProject(VoteProject voteProject);
        
        //Delete Methods
        void DeleteVoteProject(string id);
    }
}