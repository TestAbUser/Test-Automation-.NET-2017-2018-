using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDDTesting.Driver
{
    /// <summary>
    /// this class is use for driver initialization
    /// </summary>
    /// <remarks>
    /// contains a method returning IWebDriver
    /// </remarks>
    public class DriverInitialization
    {
        private readonly IWebDriver chromeDriver = new ChromeDriver();
        public IWebDriver GetDriver()
        {
            return chromeDriver;
        }
    }
}
