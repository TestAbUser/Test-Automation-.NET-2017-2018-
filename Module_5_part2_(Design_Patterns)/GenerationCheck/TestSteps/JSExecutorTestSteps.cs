using OpenQA.Selenium;
using GenerationCheck.BusinessObjects;

namespace GenerationCheck.TestSteps
{
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
