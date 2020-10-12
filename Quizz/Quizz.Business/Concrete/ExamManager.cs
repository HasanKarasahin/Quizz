using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.Business
{
    public class ExamManager : IExamService
    {
        private IExamRepository _examRepository;

        public ExamManager(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public List<Exam> GetAllExam()
        {
            return _examRepository.GetAllExams();
        }
    }
}
