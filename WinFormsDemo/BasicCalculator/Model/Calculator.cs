using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Model
{
    public static class Calculator
    {
        private static float Result;
        private static List<float> Results = new List<float>();
        public static float Sum(float num1, float num2)
        { 
            Result = (num1 + num2);
            Results.Add(Result);
            return Result;
        }

        public static float Difference(float num1, float num2)
        {
            Result = (num2 - num1);
            Results.Add(Result);
            return Result;
        }

        public static float Product(float num1, float num2)
        {
            Result = (num1 * num2);
            Results.Add(Result);
            return Result;
        }

        public static float Divide(float num1, float num2)
        {
            try
            {
                if (num2==0)
                {
                    throw new DivideByZeroException();
                }
                Result = (num1 / num2);
            }
            catch (Exception)
            {
                throw;
            }

            Results.Add(Result);
            return Result;
        }

        public static float GetResult()
        {
            return Result;
        }

        public static List<float> ResultHistory()
        {
            return Results;
        }

        public static string ResultHistories()
        {
            StringBuilder strResult = new StringBuilder();

            foreach(float resValue in Results)
            {
                strResult.Append(resValue.ToString());
                strResult.Append(Environment.NewLine);
            }
            return strResult.ToString(); 
        }
    }
}
