using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoolNewFeatureCSharp6
{
    public class InstanceNullCheck
    {
        public InstanceNullCheck()
        {
            SampleData sData = new SampleData();
            if (sData.MyName == String.Empty)
            {
                sData = null;
            }

            WriteLine(sData?.MyName ?? "Field is null.");

            ReadLine();
        }
    }
   
}
