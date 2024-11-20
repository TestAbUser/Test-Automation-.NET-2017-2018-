using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class Browser
    {
        public string GetURL()
        {
            string value = ConfigurationManager.AppSettings["URL"];
            return value;
        }
    }
}
