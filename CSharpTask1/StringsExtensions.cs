using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1
{
    public static class StringsExtensions
    {
        //public static int GetStringLenght(this string val)
        //{
        //    return val.ToCharArray().GetLength(0);
        //}

        public static string FlipCase(this string val)
        {
            List<int> flipCase = new List<int>();
            string result = "";

            foreach (char c in val)
            {
                if (c >= 65 & c <= 90)
                {
                    flipCase.Add(c + 32);
                }
                else if (c >= 97 & c <= 122)
                {
                    flipCase.Add(c - 32);
                }
                else
                    flipCase.Add(c);

            }
            foreach (char c in flipCase)
            {
                result += c;
            }
            return result;
        }

    }
}
