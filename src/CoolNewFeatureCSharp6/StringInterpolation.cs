using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoolNewFeatureCSharp6
{
    public class StringInterpolation
    {
        public StringInterpolation()
        {
            string firstName = "Abhishek";
            string lastName = "Kumar";

            WriteLine($"{firstName} {lastName} is my name!");

            ReadLine();
        }
    }
}
