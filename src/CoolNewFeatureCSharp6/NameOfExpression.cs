using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolNewFeatureCSharp6
{
    public class NameOfExpression
    {
        public NameOfExpression()
        {
            SampleMethod("First Crazy Developer");
        }
        public static void SampleMethod(string newParameter)
        {
            if (newParameter == null) throw new Exception(nameof(newParameter) + " is null");
        }
    }
}
