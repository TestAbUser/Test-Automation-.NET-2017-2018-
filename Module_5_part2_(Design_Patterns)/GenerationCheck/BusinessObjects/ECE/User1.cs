using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class User1
    {
        public string GetSessionUserName()
        {
            string sessionUserName = ConfigurationManager.AppSettings["sessionUserName"];
            return sessionUserName;
        }
    }
}
