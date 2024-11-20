using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using GenerationCheck.BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenerationCheck.Driver
{
    public class ECEInitializer
    {
        private static DesiredCapabilities dc;
        private static IWebDriver driver;

        public  IWebDriver GetDriver()
        {
            return driver;
        }

        [TestInitialize]
        public void Initialize()
        {
            Application app = new Application();
            dc = new DesiredCapabilities();
            dc.SetCapability("app", app.GetLocation());
            driver = new RemoteWebDriver(new Uri(WiniumDriverSingleton.GetLocalhost()), dc);
        }
    }
}



