using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.Business
{
    public interface IExamService
    {
        List<Exam> GetAllExam();

        int CreateExam(Exam exam);
        void DeleteExam(int exam_id);
    }
}
