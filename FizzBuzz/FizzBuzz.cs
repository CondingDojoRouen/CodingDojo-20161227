using System;

namespace Econocom.CodingDojo
{
    public class FizzBuzz
    {
        private static bool IsMultipleOf(int num,int divisor)
        {

            return num % divisor == 0;
        }
        public static string[] Generate()
        {
            string[] result = new string[100];
            result[0] = "1";
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = (i + 1).ToString();
                if (IsMultipleOf(i + 1, 3))
                    result[i] = "Fizz";
                if (IsMultipleOf(i + 1, 5))
                    result[i] = "Buzz";
                if (IsMultipleOf(i + 1, 15))
                    result[i] = "FizzBuzz";
                
                
            }
            return result;
        }
    }
}
