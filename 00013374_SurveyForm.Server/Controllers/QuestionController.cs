using _00013374_SurveyForm.Server.Models;
using _00013374_SurveyForm.Server.Models.DTO;
using _00013374_SurveyForm.Server.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace _00013374_SurveyForm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository questionRepository;
        public QuestionController(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionRequestDto request)
        {
            var question = new Question
            {
                QuestionText = request.QuestionText
            };
            await questionRepository.CreateAsync(question);

            var response = new QuestionDto
            {
                Id = question.Id,
                QuestionText = question.QuestionText
            };

            return Ok(response);
        }
    }
}
