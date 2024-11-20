using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;

using OpenQA.Selenium.Appium;

namespace AppiumDotNetSample.PageObjects
{
    /// <summary>
    /// contains page objects necessary for testing
    /// </summary>
    /// <remarks>
    /// Page Factory pattern doesn't work - elements can't be initialized, so I had to use Page Objects pattern
    /// </remarks>
    public class APIDemosRashidIsayev
    {
        private AndroidDriver<AppiumWebElement> driver;

        private const string byXPathForApp = "//android.widget.TextView[contains(@text, 'App')]";
        private const string byXPathForAlarm = "//android.widget.TextView[contains(@text, 'Alarm')]";
        private const string byXPathForAlarmService = "//android.widget.TextView[contains(@text, 'Alarm Service')]";
        private const string byXPathForButton = "//android.widget.Button[contains(@text, 'START ALARM SERVICE')]";

        public APIDemosRashidIsayev(AndroidDriver<AppiumWebElement> driver)
        {
            this.driver = driver;
        }

        private IMobileElement<AppiumWebElement> FindApp
        {
            get { return driver.FindElementByXPath(byXPathForApp); }
        }

        private IMobileElement<AppiumWebElement> FindAlarm
        {
            get { return driver.FindElementByXPath(byXPathForAlarm); }
        }

        private IMobileElement<AppiumWebElement> FindAlarmService
        {
            get { return driver.FindElementByXPath(byXPathForAlarmService); }
        }

        private IMobileElement<AppiumWebElement> FindStartAlarmService
        {
            get { return driver.FindElementByXPath(byXPathForButton); }
        }

        public IMobileElement<AppiumWebElement> GetApp()
        {
            return FindApp;
        }

        public IMobileElement<AppiumWebElement> GetAlarm()
        {
            return FindAlarm;
        }

        public IMobileElement<AppiumWebElement> GetAlarmService()
        {
            return FindAlarmService;
        }

        public IMobileElement<AppiumWebElement> GetStartAlarmService()
        {
            return FindStartAlarmService;
        }

        /// <summary>
        /// clicks on the line containing "App" value
        /// </summary>
        public void ClickApp()
        {
            GetApp().Click();
        }

        /// <summary>
        /// clicks on the line containing "Alarm" value
        /// </summary>
        /// <remarks>
        /// "Alarm" option appears after "App" is selected
        /// </remarks>
        public void ClickAlarm()
        {
            GetAlarm().Click();
        }

        /// <summary>
        /// clicks on the line containing "Alarm Service" value
        /// </summary>
        /// <remarks>
        /// "Alarm Service" option appears after "Alarm" is selected
        /// </remarks>
        public void ClickAlarmService()
        {
            GetAlarmService().Click();
        }
    }
}
