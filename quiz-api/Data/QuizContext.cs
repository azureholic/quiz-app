using Microsoft.EntityFrameworkCore;
using Quiz.Api.Models;

namespace Quiz.Api.Data
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) {}

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().ToTable("Questions");
            modelBuilder.Entity<Answer>().ToTable("Answers");
            
        }

    }
}
