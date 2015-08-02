using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            // print my age
            int age = 22;

            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine();

            // output percent score
            const int MAX_SCORE = 100;
            int score = 95;

            float percent = (float)score / MAX_SCORE;

            Console.WriteLine("Percent score is " + percent + ".");
            Console.WriteLine();
        }
    }
}
