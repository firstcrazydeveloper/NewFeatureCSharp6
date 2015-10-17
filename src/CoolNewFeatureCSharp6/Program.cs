using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using static CoolNewFeatureCSharp6.SampleStatic;


namespace CoolNewFeatureCSharp6
{
    public class Program
    {
        public void Main(string[] args)
        {
            WriteLine("Hello World!");
            CallCoolFeature();

            AutoPropertyInitializers autoProperty = new AutoPropertyInitializers();
            WriteLine(autoProperty.myID);
            ReadLine();
        }
    }
}
