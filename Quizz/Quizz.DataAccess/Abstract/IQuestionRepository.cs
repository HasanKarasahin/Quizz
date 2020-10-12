using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz.DataAccess.Abstract
{
    public interface IQuestionRepository
    {
        List<Answer> GetAllQuestion();
    }
}
