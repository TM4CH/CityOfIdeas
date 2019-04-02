using System.Collections.Generic;
using Domain.Project;
using Domain.ProjectClasses;

namespace DAL.IProject.ISurvey.IQuestion
{
    public interface IChoiceRepository
    {
        /*
         *     CRUD Choice
         */
            
        //Create Methods
        void CreateChoice(Choice choice);
        
        //Read Methods
        IEnumerable<Choice> ReadAllChoices();
        Choice ReadChoice(string id);
        
        //Update Methods
        void UpdateChoice(Choice choice);
        
        //Delete Methods
        void DeleteChoice(string id);  
    }
}