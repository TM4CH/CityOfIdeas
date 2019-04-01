using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.ISurvey.IQuestion
{
    public interface IChoiceRepository
    {
        /*
         *     CRUD Choice
         */
            
        //Create Methods
        Choice CreateChoice(Choice choice);
        
        //Read Methods
        IEnumerable<Choice> ReadChoice();
        Choice ReadChoice(string id);
        
        //Update Methods
        void UpdateChoice(Choice choice);
        
        //Delete Methods
        void DeleteChoice(string id);  
    }
}