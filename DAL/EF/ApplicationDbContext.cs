using Domain.PlatformClasses;
using Domain.ProjectClasses;
using Domain.ProjectClasses.IdeationClasses;
using Domain.ProjectClasses.PhaseClasses;
using Domain.ProjectClasses.SurveyClasses;
using Domain.ProjectClasses.SurveyClasses.AnswerClasses;
using Domain.ProjectClasses.SurveyClasses.QuestionClasses;
using Domain.UserClasses;
using Domain.VoteClasses;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=185.182.56.49;port=3306;database=muhamda216_cityofideas;user=muhamda216_ipt11;password=CoIipt11").UseLazyLoadingProxies();
        }

        #region Platform

            public DbSet<Platform> Platforms { get; set; }  
            public DbSet<Theme> Themes { get; set; }  

        #endregion

        #region Project

            #region Ideation
                public DbSet<Comment> Comments { get; set; }   
                public DbSet<Idea> Ideas { get; set; }       
                public DbSet<Ideation> Ideations { get; set; }  
                public DbSet<PropertyEnabled> PropertiesEnabled { get; set; }  
                public DbSet<Tag> Tags { get; set; }  
            #endregion

            #region Phase
                public DbSet<Phase> Phases { get; set; }
            #endregion

            #region Survey

                #region Answer
                    public DbSet<Answer> Answers { get; set; }  
                    public DbSet<ChoiceAnswer> ChoiceAnswers { get; set; }  
                    public DbSet<MultipleChoiceAnswer> MultipleChoiceAnswers { get; set; }
                    public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
                #endregion

                #region Question
                    public DbSet<Choice> Choices { get; set; } 
                    public DbSet<MultipleChoiceQuestion> MultipleChoiceQuestions { get; set; }  
                    public DbSet<Question> Questions { get; set; } 
                #endregion
                
                public DbSet<Survey> Surveys { get; set; }
                
            #endregion
            
        public DbSet<Project> Projects { get; set; }
 
        #endregion

        #region User
            public new DbSet<User> Users { get; set; }
            public new DbSet<Role> Roles { get; set; }  
        #endregion

        #region Vote
            public DbSet<VoteIdeation> VoteIdeations { get; set; }
            public DbSet<VoteProject> VoteProjects { get; set; }
            public DbSet<Vote> Votes { get; set; }
        #endregion          
    }
}