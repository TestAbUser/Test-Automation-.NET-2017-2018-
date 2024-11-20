using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GenerationCheck.Driver
{
   public class ChromeInitializer
    {
        public static IWebDriver chromeDriver = new ChromeDriver();
    }
}