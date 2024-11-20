using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace GenerationCheck.tests
{
    [TestClass]
    public class RemoteWDTest
    {
        private const string Yandex = "https://yandex.ru/";
        private const string Hub = "http://10.19.11.82:4444/wd/hub";


        [TestMethod]
        public void TestRemoteConnection()
        {
            var chromeOptions = new ChromeOptions();
            var firefoxOptions = new FirefoxOptions();

            var chromeСapability = chromeOptions.ToCapabilities() as DesiredCapabilities;
            var firefoxCapability = firefoxOptions.ToCapabilities() as DesiredCapabilities;

            RemoteWebDriver driverChrome = null;
            RemoteWebDriver driverFirefox = null;

            TestGrid(driverChrome, chromeСapability);
            TestGrid(driverFirefox, firefoxCapability);
        }
        private void TestGrid(RemoteWebDriver driver, DesiredCapabilities capability)
        {
            driver = new RemoteWebDriver(new Uri(Hub), capability);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Yandex);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("document.querySelector('a.link.teaser__link').click()");
        }
    }
}
