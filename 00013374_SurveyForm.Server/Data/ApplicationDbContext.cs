using _00013374_SurveyForm.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace _00013374_SurveyForm.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }
    }
}
