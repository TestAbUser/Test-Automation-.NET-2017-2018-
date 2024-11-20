using Appium.Samples.Helpers;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects;
using APIDemosRashidIsayev = AppiumDotNetSample.PageObjects.APIDemosRashidIsayev;


namespace AppiumDotNetSample.Android
{

    /// <summary>
    /// the class contains setup and methods and a test method
    /// </summary>
    [TestFixture]
    public class ButtonEnabledTest_RashidIsayev
    {
        private AndroidDriver<AppiumWebElement> driver;
        private bool allPassed = true;
        APIDemosRashidIsayev pageObject;

        /// <summary>
        /// capabilities are defined, driver and page objects are initialized.
        /// </summary>
        /// <remarks>
        /// BeforeAll() setup method was copied from existing classes
        /// </remarks>
        [SetUp]
        public void BeforeAll()
        {
            DesiredCapabilities capabilities = Env.isSauce() ?
                 Caps.getAndroid501Caps(Apps.get("androidApiDemos")) :
                 Caps.getAndroid19Caps(Apps.get("androidApiDemos"));
            if (Env.isSauce())
            {
                capabilities.SetCapability("username", Env.getEnvVar("SAUCE_USERNAME"));
                capabilities.SetCapability("accessKey", Env.getEnvVar("SAUCE_ACCESS_KEY"));
                capabilities.SetCapability("name", "android - simple");
                capabilities.SetCapability("tags", new string[] { "sample" });
            }
            Uri serverUri = Env.isSauce() ? AppiumServers.sauceURI : AppiumServers.LocalServiceURIAndroid;
            driver = new AndroidDriver<AppiumWebElement>(serverUri, capabilities, Env.INIT_TIMEOUT_SEC);
             TimeOutDuration timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 5, 0));
            driver.Manage().Timeouts().ImplicitWait = (Env.IMPLICIT_TIMEOUT_SEC);
            pageObject = new APIDemosRashidIsayev(driver);
        }

        /// <summary>
        /// checks the correctness of the test status and quits driver
        /// </summary>
        /// <remarks>
        /// the method is borrowed from the existing tests
        /// </remarks>
        [TearDown]
        public void AfterEach()
        {
            allPassed = allPassed && (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed);
            if (Env.isSauce())
                ((IJavaScriptExecutor)driver).ExecuteScript("sauce:job-result=" + (allPassed ? "passed" : "failed"));
            driver.Quit();
        }

        /// <summary>
        /// contains test steps
        /// </summary>
        /// <remarks>
        /// page objects are taken from APIDemosRashidIsayev class
        /// </remarks>
        [SetUp]
        public void SetUp()
        {
            pageObject.ClickApp();
            pageObject.ClickAlarm();
            pageObject.ClickAlarmService();
        }

        /// <summary>
        /// asserts that "Start Alarm Service" button is enabled
        /// </summary>
        [Test]
        public void AssertButtonIsEnabled()
        {
            Assert.That(pageObject.GetStartAlarmService().Enabled);
        }
    }
}
