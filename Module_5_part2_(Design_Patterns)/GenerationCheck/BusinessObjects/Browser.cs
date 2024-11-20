using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class Browser
    {
        public string GetURL()
        {
            string URL = ConfigurationManager.AppSettings["URL"];
            return URL;
        }
    }
}
