using _00013374_SurveyForm.Server.Models;

namespace _00013374_SurveyForm.Server.Repositories.Interface
{
    public interface IQuestionRepository
    {
        Task<Question> CreateAsync(Question question);
    }
}
