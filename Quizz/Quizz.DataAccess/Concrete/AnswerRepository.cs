using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizz.DataAccess.ConCrete
{
    public class AnswerRepository : IAnswerRepository
    {
        public List<Answer> GetAllAnswers()
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                return quizzDbContext.Answers.ToList();
            }
        }
    }
}
