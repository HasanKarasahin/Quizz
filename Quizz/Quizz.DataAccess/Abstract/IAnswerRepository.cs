using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.DataAccess.Abstract
{
    public interface IAnswerRepository
    {
        List<Answer> GetAllAnswers();
        int CreateAnswer(Answer answer);
    }
}
