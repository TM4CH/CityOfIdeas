using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.IIdeation
{
    public interface IPropertyEnabledRepository
    {
        /*
         *     CRUD PropertyEnabled
         */
        
        //Create Methods
        void CreatePropertyEnabled(PropertyEnabled propertyEnabled);
        
        //Read Methods
        IEnumerable<PropertyEnabled> ReadAllPropertiesEnabled();
        PropertyEnabled ReadPropertyEnabled(string id);
        
        //Update Methods
        void UpdatePropertyEnabled(PropertyEnabled propertyEnabled);
        
        //Delete Methods
        void DeletePropertyEnabled(string id);
    }
}