using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class WiniumDesktopDriver
    {
        public static string GetLocalhost()
        {
            string value = ConfigurationManager.AppSettings["localhost"];
            return value;
        }
    }
}

