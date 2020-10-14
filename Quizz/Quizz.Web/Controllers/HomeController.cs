using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quizz.Business;
using Quizz.DataAccess.Concrete;
using Quizz.Entities;
using Quizz.Web.Models;

namespace Quizz.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAnswerService _answerService;
        private IQuestionService _questionService;
        private IExamService _examService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //TO-DO bagımlıgıgı kaldır.
            _answerService = new AnswerManager(new AnswerRepository());
            _questionService = new QuestionManager(new QuestionRepository());
            _examService = new ExamManager(new ExamRepository());
        }

        public IActionResult Index()
        {
            return View(_examService.GetAllExam());
        }


        [HttpGet]
        public IActionResult AddExamPage()
        {
            return View();
        }


        [HttpPost]
        public int AddExam()
        {
            // Exam Add Start
            Exam exam = new Exam();
            exam.exam_name = Request.Form["exam_name"];
            exam.exam_status = 1;
            int exam_id = _examService.CreateExam(exam);
            // Exam Add End

            // Question Add Start
            String[] questionNames = { "soru1_soru", "soru2_soru", "soru3_soru", "soru4_soru", "soru5_soru" };
            List<int> questionNamesIds = new List<int>();

            for (int i = 0; i < questionNames.Length; i++)
            {
                Question question = new Question();
                question.exam_id = exam_id;
                question.question_name = Request.Form[questionNames[i]];
                int soru_id = _questionService.CreateQuestion(question);
                questionNamesIds.Add(soru_id);
            }
            // Question Add End


            // Answer Add Start
            int count = 1;
            foreach (var questionId in questionNamesIds)
            {
                string[,] answerNames = new string[,]{
                {"soru"+count+"_cevap_a", "A"},
                {"soru"+count+"_cevap_b", "B"},
                {"soru"+count+"_cevap_c", "C"},
                {"soru"+count+"_cevap_d", "D"},
                {"soru"+count+"_cevap_e", "E"},};

                for (int i = 0; i < answerNames.Length / 2; i++)
                {
                    Answer answer = new Answer();
                    answer.question_id = questionId;
                    answer.answer_name = Request.Form[answerNames[i, 0]];
                    answer.answer_title = answerNames[i, 1];
                    _answerService.CreateAnswer(answer);
                }
                count++;
            }
            // Answer Add End


            return exam_id;
        }

        [HttpGet("{id}")]
        [Route("EditExam")]
        public IActionResult EditExam(int id)
        {

            return RedirectToAction("AddExamPage");
        }

        [HttpGet("{id}")]
        public IActionResult DeleteExam(int id)
        {
            int exam_id = id;
            _examService.DeleteExam(exam_id);
            //TO-DO Sorular ve Cevaplarıda sil.

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
