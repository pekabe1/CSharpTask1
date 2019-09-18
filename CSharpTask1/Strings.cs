using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpTask1
{
    public class Strings : IStrings
    {
        public string Text { get; set; }

        public Strings(string str)
        {
            Text = str;
        }

        public void GetStringInfo()
        {
            int LowerCase = 0;
            int UperCase= 0;
            int TextLenght = 0;

            Console.WriteLine($"***"+ Text + "***");
            Console.WriteLine("White spaces in input string : " + Text.Count(Char.IsWhiteSpace));
            if (Text.Contains("Ok"))
            {
                Console.WriteLine("input string contains world ''Ok'' ");
            }
            else Console.WriteLine("input string doesn't contains world ''Ok''");

            foreach (char c in Text)
            {
                TextLenght++;
                if (c >= 65 & c <= 90)
                {
                    LowerCase++;
                }
                else if(c >= 97 & c <= 122)
                {
                    UperCase++;
                }
            }
            Console.WriteLine("input text have "+LowerCase+" lower case letters and "+UperCase+@" uper case letters");
            Console.WriteLine("input text lenght :"+ TextLenght);
        }

        public string GetValidLength()
        {
            if (Text.ToArray().GetLength(0) > 20)
            {
                return Text.Substring(0, 10) + "...";
            }
            else return Text;
        }



    }
}
