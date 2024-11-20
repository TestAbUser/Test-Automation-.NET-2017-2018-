
using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class Application
    {
        public string GetLocation()
        {
            string value = ConfigurationManager.AppSettings["location"];
            return value;
        }
    }
}
