using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BDDTesting.PageObjects
{
    /// <summary>
    /// this is a page that contains results of the search
    /// </summary>
    /// <remarks>
    /// this class contains all the elements from SearchResultsPage necessary for testing
    /// </remarks>
    public class SearchResultsPage : AbstractPage
    {
        private const string firstElement = "srp-river-results-listing1";
        private const string firstElementsImage = "s-item__image";
        private IWebDriver chromeDriver;

        /// <summary>
        /// constructor that inherits driver from AbstractPage class
        /// </summary>
        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
            chromeDriver = driver;
        }

        /// <summary>
        /// this is the first item in the search results list
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindFirstElement
        {
            get
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.Id(firstElement)));
                return chromeDriver.FindElement(By.Id(firstElement));
            }
        }

        /// <summary>
        /// this is a method accessing the first item in the search results list
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetFirstElement()
        {
            return FindFirstElement;
        }

        /// <summary>
        /// this is the image of the first item in the search results list
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindFirstElementsImage
        {
            get
            {
                return FindFirstElement.FindElement(By.ClassName(firstElementsImage));
            }
        }

        /// <summary>
        /// this is a method accessing the image of the first item in the search results list
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetFirstElementsImage()
        {
            return FindFirstElementsImage;
        }
    }
}
