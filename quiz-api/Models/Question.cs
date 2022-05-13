using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Api.Models
{
    public class Question
    {
        
        public Guid Id { get; set; } = Guid.NewGuid();
        public String Text { get; set; }
        public ICollection<Answer> Answers { get; set; } 
    }
}
