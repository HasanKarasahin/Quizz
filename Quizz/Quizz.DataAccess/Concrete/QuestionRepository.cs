using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Quizz.DataAccess.Concrete
{
    public class QuestionRepository : IQuestionRepository
    {
        public List<Question> GetAllQuestions()
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                return quizzDbContext.Questions.ToList();
            }
        }
    }
}
