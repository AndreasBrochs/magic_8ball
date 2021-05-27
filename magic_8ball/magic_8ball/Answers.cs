using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_8ball
{
    class Answers
    {
        public static string RandomAnswers()
        {
            string[] allAnswers =
           {
                //positiveAnswers
                "It is Certain,",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                //nonCommitAnswers
                "Reply hazy, try again.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                //negativeAnswers
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful."
            };

            Random random = new Random();
            string answer = allAnswers[random.Next(allAnswers.Length)];
            Loading.LoadingScreen();
            return answer;
        }
    }
}
