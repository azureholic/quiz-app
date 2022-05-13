using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Api.Models
{
    public class Answer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public String Text { get; set; }
        public Boolean IsCorrectAnswer { get; set; }
        public Guid QuestionId { get; set; }
    }
}
