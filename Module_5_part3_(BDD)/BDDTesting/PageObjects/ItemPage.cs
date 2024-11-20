using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BDDTesting.PageObjects
{
    /// <summary>
    /// this is a page that opens after the image of a selected product is clicked on 
    /// </summary>
    /// <remarks>
    /// this class contains all the elements from ItemPage necessary for testing
    /// </remarks>
    public class ItemPage : AbstractPage
    {
        private const string addToCartButton = "isCartBtn_btn";
        private const string numberOfItemsInputArea = "qtyTextBox";
        private IWebDriver chromeDriver;

        /// <summary>
        /// constructor that inherits driver from AbstractPage class
        /// </summary>
        public ItemPage(IWebDriver driver) : base(driver)
        {
            chromeDriver = driver;
        }

        /// <summary>
        /// this is a textbox where one can choose the number of the items one wants to add to the cart
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindNumberOfItemsInputArea
        {
            get
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.Id(numberOfItemsInputArea)));
                return chromeDriver.FindElement(By.Id(numberOfItemsInputArea));
            }
        }

        /// <summary>
        /// this is a method used for accessing the textbox where one can choose the number of the items one wants to add to the cart
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetNumberOfItemsInputArea()
        {
            return FindNumberOfItemsInputArea;
        }

        /// <summary>
        /// this is a button used for adding items to the cart 
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindAddToCartButton
        {
            get { return chromeDriver.FindElement(By.Id(addToCartButton)); }
        }

        /// <summary>
        /// this is a method used for accessing button that adds items to the cart 
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetAddToCartButton()
        {
            return FindAddToCartButton;
        }
    }
}
