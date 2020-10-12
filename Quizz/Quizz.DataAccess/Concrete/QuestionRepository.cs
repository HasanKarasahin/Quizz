using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz.DataAccess.ConCrete
{
    public class QuestionRepository : IQuestionRepository
    {
        public List<Answer> GetAllQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
