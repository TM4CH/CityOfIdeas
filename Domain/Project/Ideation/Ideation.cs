using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Project
{
    public class Ideation
    {
        [Key] public string Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Description { get; set; }
        public string Link { get; set; }
        [Required]
        public Boolean AdminOnly { get; set; }
        public virtual ICollection<Idea> Ideas { get; set; }
        [Required] public virtual Phase Phase { get; set; }
        public virtual User.User User { get; set; }
        
        private ICollection<PropertyEnabled> _propertyEnabled;
        
        public virtual ICollection<PropertyEnabled> PropertyEnabled
        {
            get { return _propertyEnabled; }
            set
            {
                value = new Collection<PropertyEnabled>(){
                    new PropertyEnabled("Map", true),
                    new PropertyEnabled("Video", true),
                    new PropertyEnabled("Image", true),
                    new PropertyEnabled("ClosedQuestion", true),
                    new PropertyEnabled("OpenQuestion", true)
                };
            }
        }
    }
}