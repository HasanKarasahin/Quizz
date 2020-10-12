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
            optionsBuilder.UseSqlite("Filename=./QuizzDb.sqlite");
        }

        public DbSet<Answer> Answers { get; set; }
    }
}
