using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GenerationCheck.Utils
{
    /// <summary>
    /// This class initializes Chrome browser
    /// </summary>
    /// <returns></returns>
    public class ChromeInitializer
    {
        public static IWebDriver chromeDriver = new ChromeDriver();
    }
}