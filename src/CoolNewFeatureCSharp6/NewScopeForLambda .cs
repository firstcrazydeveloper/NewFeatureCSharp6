using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoolNewFeatureCSharp6
{
    public class NewScopeForLambda
    {
        public NewScopeForLambda()
        {
            double num1 = 5;
            double num2 = 10;

            WriteLine(MultiplyNumbers(num1, num2));
            ReadLine();
        }
        private static double MultiplyNumbers(double num1, double num2) => num1 * num2;
    }
}
