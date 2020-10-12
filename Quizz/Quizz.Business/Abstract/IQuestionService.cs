using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.Business
{
    public interface IQuestionService
    {
        List<Question> GetAllQuestions();
    }
}
