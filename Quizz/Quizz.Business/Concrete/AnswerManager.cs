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

        public int CreateAnswer(Answer answer)
        {
            return _answerRepository.CreateAnswer(answer);
        }

        public List<Answer> GetAllAnswers()
        {
            return _answerRepository.GetAllAnswers();
        }
    }
}
