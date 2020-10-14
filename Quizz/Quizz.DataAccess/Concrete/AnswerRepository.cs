using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Quizz.DataAccess.Concrete
{
    public class AnswerRepository : IAnswerRepository
    {
        public int CreateAnswer(Answer answer)
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                quizzDbContext.Answers.Add(answer);
                quizzDbContext.SaveChanges();
                return answer.id;
            }
        }

        public List<Answer> GetAllAnswers()
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                return quizzDbContext.Answers.ToList();
            }
        }
    }
}
