using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz.Business
{
    public interface IQuestionService
    {
        List<Answer> GetAllAnswers();
    }
}
