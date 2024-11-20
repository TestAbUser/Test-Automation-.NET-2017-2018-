using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GenerationCheck
{
    public abstract class Tab
    {
        public static WebDriverWait wait;

        public Tab(IWebDriver driver)
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        public virtual IWebElement WaitFactoryMethod(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            return element;
        }
    }
}
