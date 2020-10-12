using Quizz.Entities;
using System.Collections.Generic;

namespace Quizz.DataAccess.Abstract
{
    public interface IExamRepository
    {
        List<Exam> GetAllExams();
    }
}
