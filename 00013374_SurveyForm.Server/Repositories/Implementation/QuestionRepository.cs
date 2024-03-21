using _00013374_SurveyForm.Server.Data;
using _00013374_SurveyForm.Server.Models;
using _00013374_SurveyForm.Server.Repositories.Interface;

namespace _00013374_SurveyForm.Server.Repositories.Implementation
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext dbContext;
        public QuestionRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Question> CreateAsync(Question question)
        {
            await dbContext.Questions.AddAsync(question);
            await dbContext.SaveChangesAsync();

            return question;
        }
    }
}
