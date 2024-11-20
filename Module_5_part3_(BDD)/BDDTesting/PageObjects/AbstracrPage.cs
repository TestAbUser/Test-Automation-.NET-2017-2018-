using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BDDTesting.PageObjects
{
    /// <summary>
    /// the base class from which the rest of the pages are inherited 
    /// </summary>
    /// <remarks>
    /// this class contains a wait object that can be used for locating necessary elements
    /// </remarks>
    public abstract class AbstractPage
    {
        private static WebDriverWait wait;

        public AbstractPage(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public static WebDriverWait GetWaiter()
        {
            return wait;
        }
    }
}
