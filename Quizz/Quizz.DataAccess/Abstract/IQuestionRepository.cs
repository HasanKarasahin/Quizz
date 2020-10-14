using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.DataAccess.Abstract
{
    public interface IQuestionRepository
    {
        List<Question> GetAllQuestions();
        int CreateQuestion(Question question);
    }
}
