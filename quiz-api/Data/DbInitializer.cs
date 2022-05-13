using Quiz.Api.Models;

namespace Quiz.Api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(QuizContext context)
        {
            context.Database.EnsureCreated();

            if (context.Questions.Any())
            {
                return;   // DB has been seeded
            }

            Question q;
            Answer[] answers;


            var guid = Guid.NewGuid();
            q = new Question { Text = "In an Orchestra, which is the largest brass section instrument?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "Trumpet", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Tenor", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "French Horns", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Tuba", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();


            guid = Guid.NewGuid();
            q = new Question { Text = "Who recorded “Groove is in the Heart“?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "Q-Tip", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Deee-Lite", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Technotronic", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "The B-52’s", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();


            guid = Guid.NewGuid();
            q = new Question { Text = "The lead singer of Evanescence is?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "Jen Majura", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Lzzy Hale", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Ben Moody", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Amy Lee", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();


            guid = Guid.NewGuid();
            q = new Question { Text = "What's a plectrum?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "A drum stick", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "A brass instrument", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "A guitar pick", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "A device of glass that breaks light into colors", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();

            guid = Guid.NewGuid();
            q = new Question { Text = "The oldest member of the Spice Girls is?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "Geri Halliwell", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Mel B", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Victoria Beckham", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Emma Bunton", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();


            guid = Guid.NewGuid();
            q = new Question { Text = "The number of strings on a Ukulele is?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "3", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "4", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "6", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "8", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();

            guid = Guid.NewGuid();
            q = new Question { Text = "“My Sharona” was recorded by which band?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "Ramones", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "AC/DC", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Judas Priest", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "The Knack", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();

            guid = Guid.NewGuid();
            q = new Question { Text = "Name the lead singer born Farrokh Bulsara?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "Fred Durst", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Boy George", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Freddie Mercury", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Simon Le Bon", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();


            guid = Guid.NewGuid();
            q = new Question { Text = "The guitarist known as Slowhand is?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "Brian May", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Eric Clapton", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Jeff Beck", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "B.B King", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();


            guid = Guid.NewGuid();
            q = new Question { Text = "Name the band which released the single “Eternal Flame”?", Id = guid };
            context.Questions.Add(q);
            answers = new Answer[] {
                new Answer { Text = "The Bangles", IsCorrectAnswer = true, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Bananarama", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "The Spice Girls", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid },
                new Answer { Text = "Atomic Kitten", IsCorrectAnswer = false, Id = Guid.NewGuid(), QuestionId = guid }
            };
            foreach (Answer a in answers)
            {
                context.Answers.Add(a);
            }
            context.SaveChanges();


        }
    }
}
