using OpenQA.Selenium;


namespace BDDTesting.PageObjects
{
    /// <summary>
    /// this is a page that opens first after tests start
    /// </summary>
    /// <remarks>
    /// this class contains all the elements from HomePage necessary for testing
    /// </remarks>
    public class HomePage : AbstractPage
    {
        private const string searchField = "gh-ac-box";
        private const string findButton = "gh-btn";
        private const string addCartButton = "gh-cart-i";

        private IWebDriver chromeDriver;

        /// <summary>
        /// constructor that inherits driver from AbstractPage class
        /// </summary>
        public HomePage(IWebDriver driver) : base(driver)
        {
            chromeDriver = driver;
        }

        /// <summary>
        /// this is the search field from HomePage
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindSearchField
        {
            get { return chromeDriver.FindElement(By.Id(searchField)); }
        }

        /// <summary>
        /// this is a method used for accessing search field from HomePage
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetSearchField()
        {
            return FindSearchField;
        }

        /// <summary>
        /// this is "Find" button from HomePage used for searching necessary information on goods
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindFindButton
        {
            get { return chromeDriver.FindElement(By.Id(findButton)); }
        }

        /// <summary>
        /// this is a method used for accessing "Find" button from HomePage 
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetFindButton()
        {
            return FindFindButton;
        }

        /// <summary>
        /// this is the icon used for opening CartPage from HomePage
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement FindOpenCartButton
        {
            get { return chromeDriver.FindElement(By.Id(addCartButton)); }
        }

        /// <summary>
        /// this is a method used for accessing the icon opening CartPage from HomePage
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetAddCartButton()
        {
            return FindOpenCartButton;
        }

    }
}
