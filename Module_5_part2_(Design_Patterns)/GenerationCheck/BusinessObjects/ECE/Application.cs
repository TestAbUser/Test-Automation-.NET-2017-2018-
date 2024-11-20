using System.Configuration;

namespace GenerationCheck.BusinessObjects
{

   public class Application
    {
        public string GetLocation()
        {
            string location = ConfigurationManager.AppSettings["location"];
            return location;
        }
    }
}
