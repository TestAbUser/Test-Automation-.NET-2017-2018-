using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using GenerationCheck.BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenerationCheck.Utils
{
    /// <summary>
    /// This class initializes ECE
    /// </summary>
    /// <returns></returns>
    public class ECEInitializer
    {
        public static DesiredCapabilities dc;
        public static IWebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            Application app = new Application();
            dc = new DesiredCapabilities();
            dc.SetCapability("app", app.GetLocation());
            driver = new RemoteWebDriver(new Uri(WiniumDesktopDriver.GetLocalhost()), dc);
        }
    }
}



