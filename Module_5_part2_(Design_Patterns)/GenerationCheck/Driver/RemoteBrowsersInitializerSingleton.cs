using System;
using System.Configuration;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace GenerationCheck.Driver
{
    public class RemoteBrowsersInitializerSingleton
    {
        public static string GetHub()
        {
            string hub = ConfigurationManager.AppSettings["Hub"];
            return hub;
        }

        protected RemoteBrowsersInitializerSingleton()
        {

        }
        
        private static ChromeOptions chromeOptions = new ChromeOptions();
        private static FirefoxOptions firefoxOptions = new FirefoxOptions();

        private static DesiredCapabilities chromeСapability = chromeOptions.ToCapabilities() as DesiredCapabilities;
        private static DesiredCapabilities firefoxCapability = firefoxOptions.ToCapabilities() as DesiredCapabilities;

        private static RemoteWebDriver driverChrome;
        private static RemoteWebDriver driverFirefox;

        public static RemoteWebDriver GetChromeInitializer()
        {
            if (driverChrome == null)
            {
                driverChrome = new RemoteWebDriver(new Uri(GetHub()), chromeСapability);
            }
            return driverChrome;
        }

        public static RemoteWebDriver GetFirefoxInitializer()
        {
            if (driverFirefox == null)
            {
                driverFirefox = new RemoteWebDriver(new Uri(GetHub()), firefoxCapability);

            }
            return driverFirefox;
        }
    }
}
