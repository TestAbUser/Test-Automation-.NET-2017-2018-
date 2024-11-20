using System;
//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using JDI_Commons;
using System.Timers;
//using OpenQA.Selenium.Remote.DriverCommand.SetTimeout;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace GenerationCheck
{
   [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;
        [TestInitialize]
        public void Setup()
        {
            //LocalInitialize();
            BasicInitialize();
        }

        private void BasicInitialize()
        {
            //  var ffBinary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");
            // var firefoxProfile = new FirefoxProfile(@"C:\Users\Rashid_Isayev\AppData\Roaming\Mozilla\Firefox\Profiles\f9zr5z1j.default");
            //  firefoxProfile.EnableNativeEvents = true;
            _driver = new ChromeDriver();

          //  System.Threading.Thread.Sleep(5000);
           // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          //  _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");
            

        }

        [TestCleanup]
        public void Teardown()
        {
       //     _driver.Close();
      //      _driver.Quit();
        }

        [TestMethod]
        public void DynamicallyLoadingElementsTestFailure()
        {
         
            //go to a url that contains a dynamically loading page element
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");
            _driver.Manage().Window.Maximize();
           // string PageSource = _driver.PageSource;
            //click the start button
         
           var start = _driver.FindElement(By.XPath(".//*[contains(text(),'Start')]"));//(By.Id("start"));
            start.Click();
            //  System.Threading.Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));//, new TimeSpan(0, 0, 5));
         
        //  Assert.IsTrue(_driver.FindElement(By.XPath(".//*[contains(text(),'Hello World!')]")).Displayed);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[contains(text(),'Hello World!')]")));

      
            //find the element that has the text Hello World
            var text = _driver.FindElement(By.XPath(".//*[contains(text(),'Hello World!')]"));
            //click on the text
             text.Click();
        }
    }
}