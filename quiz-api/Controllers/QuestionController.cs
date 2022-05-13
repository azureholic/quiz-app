using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz.Api.Data;
using Quiz.Api.Models;

namespace Quiz.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        private readonly QuizContext _context;

        public QuestionController(QuizContext context)
        {
            _context = context;
           
        }

        [HttpGet]
        public async Task<List<Question>> GetQuestionsAsync()
        {
            var questions = _context.Questions.Include(q => q.Answers);
            //get 5 questions random 
            return await questions.OrderBy(r => Guid.NewGuid()).Take(5).ToListAsync();
           

            
        }
    }
}
