using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.Business
{
    public interface IExamService
    {
        List<Exam> GetAllExam();
    }
}
