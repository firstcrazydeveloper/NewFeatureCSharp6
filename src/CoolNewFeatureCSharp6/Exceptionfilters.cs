using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CoolNewFeatureCSharp6
{
    public class Exceptionfilters
    {
        public Exceptionfilters()
        {
            var httpStatusCode = 404;
            Write("HTTP Error: ");

            try
            {
                throw new Exception(httpStatusCode.ToString());
            }
            catch (Exception ex) when (ex.Message.Equals("400"))
            {
                Write("Bad Request");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                Write("Unauthorized");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                Write("Payment Required");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("403"))
            {
                Write("Forbidden");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("404"))
            {
                Write("Not Found");
                ReadLine();
            }

            ReadLine();
        }
    }
}
