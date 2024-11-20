using OpenQA.Selenium;
using GenerationCheck.BusinessObjects;

namespace GenerationCheck.TestSteps
{
    /// <summary>
    /// This class defines steps for testing click using JS
    /// </summary>
    /// <returns></returns>
    public class JSExecutorTestSteps
    {
        public static void JSClickWeb(IWebDriver driver)
        {
            Browser browser = new Browser();
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            driver.Navigate().GoToUrl(browser.GetURL());
            js.ExecuteScript("document.querySelector('a.link.teaser__link').click()");
        }
    }
}
