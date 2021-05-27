using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace magic_8ball
{
    class Loading
    {
        public static void LoadingScreen()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rThinking: {i}%");
                Thread.Sleep(20);
            }
            Console.Write("\rDone!           ");
        }

    }
}
