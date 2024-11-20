using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfigureTab = GenerationCheck.PageFactoryPattern.ConfigureTab;

namespace GenerationCheck.tests
{
    [TestClass]
    public class ActionsTest
    {
        public static DesiredCapabilities dc;
        public static IWebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:\Users\...\ECE.exe");
            driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
        }

        //checking that actions 'SendKeys' and 'Click' work
        [TestMethod]
        public void TestActions()
        {
            ConfigureTab configureTab = new ConfigureTab(driver);
            configureTab.TestSendKeys().TestClickButton();
        }
    }
}
