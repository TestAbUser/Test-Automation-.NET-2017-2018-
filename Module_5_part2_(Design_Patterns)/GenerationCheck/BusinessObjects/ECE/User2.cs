using System.Configuration;

namespace GenerationCheck.BusinessObjects
{
    public class User2
    {
        public string GetSessionUserName()
        {
            string sessionUserName = ConfigurationManager.AppSettings["sessionUserName2"];
            return sessionUserName;
        }
    }
}
