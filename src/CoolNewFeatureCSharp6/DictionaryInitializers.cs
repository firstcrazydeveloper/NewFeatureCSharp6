using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoolNewFeatureCSharp6
{
    public class DictionaryInitializers
    {
        public DictionaryInitializers()
        {
            var sampleData = new Dictionary<string, string>()
            {
                ["First Crazy Developer"] = "My Blog",
                ["Coding Almanac"] = "Developer Wall",
                ["Full Stack Developer"] = "Abhishek Kumar"
            };

            foreach (KeyValuePair<string, string> keyValuePair in sampleData)
            {
                WriteLine(keyValuePair.Key + ": " +
                keyValuePair.Value + "\n");
            }

            ReadLine();
        }
    }
}
