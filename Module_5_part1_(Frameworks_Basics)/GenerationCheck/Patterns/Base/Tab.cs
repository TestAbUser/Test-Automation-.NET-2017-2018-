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
    }
}
