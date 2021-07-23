using System;

namespace Day13_FindMaximumNumber_Generics_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Number");
            int intMaxNumber = CheckMaximum.MaximumIntegerNumber(55, 24, 100);
            Console.WriteLine("Maximum number of INT : "+ intMaxNumber);

            float floatMaxNumber = CheckMaximum.MaximumFloatNumber(5.5f, 2.4f, 1.0f);
            Console.WriteLine("Maximum number of INT : " + floatMaxNumber);
        }
    }
}
