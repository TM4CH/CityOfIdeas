using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Project;
using Domain.Project.Answer;
using Domain.Project.Phase;
using Domain.User;
using Domain.Vote;
using Microsoft.AspNetCore.Identity;
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

        public new DbSet<User> Users { get; set; }
        public new DbSet<Role> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }       
        public DbSet<Idea> Ideas { get; set; }       
        public DbSet<Ideation> Ideations { get; set; }       
        public DbSet<Answer> Answers { get; set; }       
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }       
        public DbSet<MultipleChoiceAnswer> MultipleChoiceAnswers { get; set; }       
        public DbSet<Question> Questions { get; set; }       
        public DbSet<MultipleChoiceQuestion> MultipleChoiceQuestions { get; set; }       
        public DbSet<Survey> Surveys { get; set; }       
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<VoteIdeation> VoteIdeations { get; set; }
        public DbSet<VoteProject> VoteProjects { get; set; }
    }
}
