using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.Business
{
    public class QuestionManager : IQuestionService
    {
        private IQuestionRepository _questionRepository;

        public QuestionManager(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public List<Question> GetAllQuestions()
        {
            return _questionRepository.GetAllQuestions();
        }
    }
}
