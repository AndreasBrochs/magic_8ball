using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_8ball
{
    class Phrases
    {
        public static void WelcomePhrases()
        {
          
            string[] phrases =
             {
                "Hello and welcome to the magic 8ball",
                "Welcome, sit down and relax. Ask your questions to the 8ball"
            };
            Random random = new Random();
            Console.WriteLine(phrases[random.Next(phrases.Length)]); 

            Questions();
        }

       static void Questions()
        {
            string[] phrases =
             {
                "What do you want to know?",
                "What do you want to ask?",
                "Please ask your question..."
            };
            Random random = new Random();
            Console.WriteLine(phrases[random.Next(phrases.Length)]);
            string userQuestion = Console.ReadLine();
            string eightBallAnswer = Answers.RandomAnswers();
            string composedAsnwer = $"you asked \"{userQuestion}\" and the 8ball answer \"{eightBallAnswer}\" ";
            Console.WriteLine();
            Console.WriteLine(composedAsnwer);


        }
    }
}
