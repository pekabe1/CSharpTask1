using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings inputString;

            DateTime inputTime;
            var choseOption = Console.Read();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();




            Console.WriteLine("Type string ");
            var a = Console.ReadLine();
            inputTime = DateTime.Now;
            inputString = new Strings(a);







            Console.WriteLine(inputString.Text.FlipCase());
            Console.WriteLine(inputString.GetValidLength());
            inputString.GetStringInfo();




            Console.WriteLine("Eplased time: " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Input time: " + inputTime);








            stopwatch.Stop();
            Console.Read();
        }
    }
}


