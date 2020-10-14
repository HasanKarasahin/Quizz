using Quizz.DataAccess.Abstract;
using Quizz.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Quizz.DataAccess.Concrete
{
    public class ExamRepository : IExamRepository
    {
        public int CreateExam(Exam exam)
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                quizzDbContext.Exams.Add(exam);
                quizzDbContext.SaveChanges();
                return exam.id;
            }
        }

        public void DeleteExam(int id)
        {
            using (var quizzDbContext = new QuizzDbContext())
            {

                quizzDbContext.Exams.Remove(GetExamById(id));
                quizzDbContext.SaveChanges();
            }
        }

        public List<Exam> GetAllExams()
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                return quizzDbContext.Exams.ToList();
            }
        }

        public Exam GetExamById(int id)
        {
            using (var quizzDbContext = new QuizzDbContext())
            {
                return quizzDbContext.Exams.Find(id);
            }
        }
    }
}
