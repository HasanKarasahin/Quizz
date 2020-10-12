using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Quizz.DataAccess.Concrete
{
    public class ExamRepository : IExamRepository
    {
        public List<Exam> GetAllExams()
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                return quizzDbContext.Exams.ToList();
            }
        }
    }
}
