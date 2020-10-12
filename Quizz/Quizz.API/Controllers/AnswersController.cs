using Microsoft.AspNetCore.Mvc;
using Quizz.Business;
using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {

        private IAnswerService _answerService;

        public AnswersController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpGet]
        public List<Answer> Get()
        {   
            return _answerService.GetAllAnswers();
        }
    }
}
