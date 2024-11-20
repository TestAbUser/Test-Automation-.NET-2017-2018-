using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class WiniumDriverSingleton
    {
        public static string GetLocalhost()
        {
            string localhost = ConfigurationManager.AppSettings["localhost"];
            return localhost;
        }
    }
}

