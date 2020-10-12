using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quizz.Business;
using Quizz.DataAccess.Concrete;
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
