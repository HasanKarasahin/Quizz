using Microsoft.EntityFrameworkCore;
using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz.DataAccess
{
    public class QuizzDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Filename=../Quizz.DataAccess/QuizzDb.sqlite");
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
