using System;
using System.Configuration;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace GenerationCheck.Utils
{
    /// <summary>
    /// This class defines some properties necessary for launching test on different browsers and initializes the browsers on two separate machines
    /// </summary>
    /// <returns></returns>
    public class BrowsersInitializer
    {
        public static string GetHub()
        {
            string value = ConfigurationManager.AppSettings["Hub"];
            return value;
        }

        static ChromeOptions chromeOptions = new ChromeOptions();
        static FirefoxOptions firefoxOptions = new FirefoxOptions();

        public static DesiredCapabilities chromeСapability = chromeOptions.ToCapabilities() as DesiredCapabilities;
        public static DesiredCapabilities firefoxCapability = firefoxOptions.ToCapabilities() as DesiredCapabilities;

        public static RemoteWebDriver driverChrome = new RemoteWebDriver(new Uri(GetHub()), chromeСapability);
        public static RemoteWebDriver driverFirefox = new RemoteWebDriver(new Uri(GetHub()), firefoxCapability);
    }
}
