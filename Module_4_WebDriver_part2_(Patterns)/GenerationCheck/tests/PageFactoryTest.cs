using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerateTab = GenerationCheck.PageFactoryPattern.GenerateTab;
using ConfigureTab = GenerationCheck.PageFactoryPattern.ConfigureTab;

namespace GenerationCheck.tests
{
    [TestClass]
    public class PageFactoryTest
    {
        public static DesiredCapabilities dc;
        public static IWebDriver driver;

        [TestInitialize]
        public void RunECE()
        {
            dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:\Users\...\ECE.exe");
            driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
        }

        [TestMethod]
        public void TestPageFactory()
        {
            ConfigureTab configureTab = new ConfigureTab(driver);
            configureTab.EnterCredentials();
            GenerateTab generateTab = configureTab.GoToGenerateTab();
            generateTab.SelectAllItemsForGeneration().RunGenerationWithCreating().WaitUntilGenerationEnds().UncheckLogLevelsExceptError();
            Assert.IsFalse(generateTab.CheckIfRowsDisplayed());
            driver.Quit();
        }
    }
}
