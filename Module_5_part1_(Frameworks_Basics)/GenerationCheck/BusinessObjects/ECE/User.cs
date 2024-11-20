using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class User
    {
        public string GetSessionUserName()
        {
            string value = ConfigurationManager.AppSettings["sessionUserName"];
            return value;
        }
    }
}
