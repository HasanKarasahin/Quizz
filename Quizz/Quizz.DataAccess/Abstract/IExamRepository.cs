using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.DataAccess.Abstract
{
    public interface IExamRepository
    {
        List<Exam> GetAllExams();

        Exam GetExamById(int id);

        int CreateExam(Exam exam);
        void DeleteExam(int id);

    }
}
