using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_22._10._2023.Helpers.Extentions
{
    public static class BaseExtentions
    {
        public static void ShowNum(this int num, int num2)
        {
            Console.WriteLine(num + num2);
        }

        public static int SumOfNums(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static string ShowText(this string text, string str )
        {
            return text + str;
        }

        public static bool CheckStr(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        public static int FindFactorial(this int num)
        {
            var factorial = 1;
            for ( int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static bool CheckEmailAndPassword(this string str, string pattern)
        {
            return Regex.IsMatch(str,pattern);
        }

        public static double PowOfNum(this int num, int pow)
        {
            return Math.Pow(num, pow);
        }

        public static bool IsConvertStringToNumber(this string str)
        {
            return int.TryParse(str, out int result);
        }
    }
}
