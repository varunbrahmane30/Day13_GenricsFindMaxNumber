using System;

namespace Day13_FindMaximumNumber_Generics_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Number");
            #region  Using normal method 
            //int intMaxNumber = CheckMaximum.MaximumIntegerNumber(55, 24, 100);
            //Console.WriteLine("Maximum number of INT : "+ intMaxNumber);

            //float floatMaxNumber = CheckMaximum.MaximumFloatNumber(5.5f, 2.4f, 1.0f);
            //Console.WriteLine("Maximum number of Float : " + floatMaxNumber);

            //string stringMaxNumber = CheckMaximum.MaximumStringNumber("Apple", "Peach", "Banana");
            //Console.WriteLine("Maximum number of String : " + stringMaxNumber);
            #endregion

            #region   Using Generics 
            int[] intArray = { 11, 3442, 4032, 55, 68 };
            UsingGenericsMaxCount<int> intMaxNumber = new UsingGenericsMaxCount<int>(intArray);
            intMaxNumber.PrintMaxValue();

            float[] floatArray = { 1.2f, 340.4f, 44.36f, 51.55f, 67.78f };
            UsingGenericsMaxCount<float> floatMaxNumber = new UsingGenericsMaxCount<float>(floatArray);
            floatMaxNumber.PrintMaxValue();

            string[] stringArray = { "Apple", "Mango", "Grapes", "Banana", "Pineapple" };
            UsingGenericsMaxCount<string> stringMax = new UsingGenericsMaxCount<string>(stringArray);
            stringMax.PrintMaxValue();
            #endregion
        }
    }
}
