using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            bool boolVal = true;

            Console.WriteLine("Variable Conversion Examples\n");

            doubleResult = floatVal * shortVal;
            Console.WriteLine("Implicit, -> double: {0} * {1} -> {2}", floatVal,
                shortVal, doubleResult);

            shortResult = (short)floatVal;
            Console.WriteLine("Explicit, -> short: {0} -> {1}", floatVal,
                shortResult);

            stringResult = Convert.ToString(boolVal) +
                Convert.ToString(doubleVal);
            Console.WriteLine("Explicit, -> short: {0} -> {1}" floatVal,
                shortResult);

            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine("Mixed,   -> long:  {0} + {1} -> {2}",
                integerVal, stringVal, longResult);
            Console.ReadKey();
        }
                  
    }
}
