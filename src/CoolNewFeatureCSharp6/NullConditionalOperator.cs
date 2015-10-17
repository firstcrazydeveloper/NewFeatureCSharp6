using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoolNewFeatureCSharp6
{
    public class NullConditionalOperator
    {
        public NullConditionalOperator()
        {
            SampleData sData = new SampleData();
            if (sData.MyName == String.Empty)
            {
                sData = null;
            }

            WriteLine(sData != null ? sData.MyName : "Field is null.");

            ReadLine();
        }
    }
    public class SampleData
    {
        public string MyName { get; set; } = "";
    }
}
