using System;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Console;

namespace CoolNewFeatureCSharp6
{
    public class AwaitWithCatchBlock
    {
        public AwaitWithCatchBlock()
        {
            Task.Factory.StartNew(() => GetWebSiteContent());
            ReadLine();
        }
        private async static Task GetWebSiteContent()
        {
            HttpClient client = new HttpClient();
            try
            {
                var result = await client.GetStringAsync("http://www.firstcrazydeveloper.com");
                WriteLine(result);
            }
            catch (Exception exception)
            {
                try
                {
                    //This asynchronous request will run if the first request failed. 
                    var result = await client.GetStringAsync("http://www.codingalmanac.com");
                    WriteLine(result);
                }
                catch
                {
                    WriteLine("Entered Catch Block");
                }
                finally
                {
                    WriteLine("Entered Finally Block");
                }
            }
        }
    }
    
}
