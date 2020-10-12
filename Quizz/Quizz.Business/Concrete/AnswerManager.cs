using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.Business
{
    public class AnswerManager : IAnswerService
    {
        private IAnswerRepository _answerRepository;

        public AnswerManager(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public List<Answer> GetAllAnswers()
        {
            return _answerRepository.GetAllAnswers();
        }
    }
}
