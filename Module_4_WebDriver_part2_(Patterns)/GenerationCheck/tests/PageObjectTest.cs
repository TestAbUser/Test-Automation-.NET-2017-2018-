using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerateTab = GenerationCheck.PageObjectPattern.GenerateTab;
using ConfigureTab = GenerationCheck.PageObjectPattern.ConfigureTab;

namespace GenerationCheck.tests
{
    [TestClass]
    public class PageObjectTest
    {
        private const string attributeHelpText = "HelpText";
        DesiredCapabilities dc;
        IWebDriver driver;

        [TestInitialize]
        public void RunECE()
        {
            dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:\Users\...\ECE.exe");
            driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
        }

        [TestMethod]
        public void TestPageObject()
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

