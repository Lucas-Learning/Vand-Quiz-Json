using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vand_Quiz_Json
{
    public class QuizManager
    {
        public int result = 0;
        public bool Check(Quizzen deserialized, int svarInt)
        {
            while (true)
            {
                if (svarInt != 1 && svarInt != 2 && svarInt != 3)
                {
                    Console.WriteLine("Du kan kun skrive 1,2 eller 3");
                    return false;
                }
                else if (deserialized.Svar == svarInt)
                {
                    Console.WriteLine("Det rigtig");
                    result++;
                    Console.WriteLine("Points= " + result);
                    return true;
                }
                else
                {
                    Console.WriteLine("Det forkert");
                    Console.WriteLine("Points= " + result);
                    return true;
                }
            }
        }
    }
}
