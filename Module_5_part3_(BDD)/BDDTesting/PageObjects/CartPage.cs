using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BDDTesting.PageObjects
{
    /// <summary>
    /// this is a page that opens when the Cart icon is clicked
    /// </summary>
    /// <remarks>
    /// this class contains all the elements from CartPage necessary for testing
    /// </remarks>
    public class CartPage : AbstractPage
    {
        private const string numberOfItemsIcon = "gh-cart-n";
        private const string numberOfItemsTextBox = "qty_1789988239";
        private const string yourCartText = "PageTitle";
        private const string itemNameText = "372012214012_title";
        private const string sellerNameText = "//*[@class='mbg-id']";
        private const string productPrice = "//*[@class='fw-b clr-sr']";
        private bool elementIs;

        private IWebDriver chromeDriver;

        /// <summary>
        /// constructor that inherits driver from AbstractPage class
        /// </summary>
        public CartPage(IWebDriver driver) : base(driver)
        {
            chromeDriver = driver;
        }

        /// <summary>
        /// text indicating the price of the product
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindPrice
        {
            get { return chromeDriver.FindElement(By.XPath(productPrice)); }
        }

        /// <summary>
        /// text indicating seller's name
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindSellerName
        {
            get { return chromeDriver.FindElement(By.XPath(sellerNameText)); }
        }

        /// <summary>
        /// text indicating the name of the product
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindItemNameText
        {
            get { return chromeDriver.FindElement(By.Id(itemNameText)); }
        }

        /// <summary>
        /// text indicating that the user has opened the Cart
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindYourCartText
        {
            get { return chromeDriver.FindElement(By.Id(yourCartText)); }
        }

        /// <summary>
        /// a textbox containing the number of added items
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindNumberOfItemsTextBox
        {
            get { return chromeDriver.FindElement(By.Id(numberOfItemsTextBox)); }
        }

        /// <summary>
        /// an icon displaying the number of added items
        /// </summary>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        private IWebElement FindNumberOfItemsIcon
        {
            get { return chromeDriver.FindElement(By.Id(numberOfItemsIcon)); }
        }

        /// <summary>
        /// a method used for accessing text-element indicating the price of the product
        /// </summary>
        /// <remarks>
        /// additionally setting flag to true if element is found
        /// </remarks>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetPrice()
        {
            try
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.XPath(productPrice)));
                elementIs = true;
                return FindPrice;
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                elementIs = false;
                return null;
            }
        }

        /// <summary>
        /// a method used for accessing text-element indicating the indicating seller's name
        /// </summary>
        /// <remarks>
        /// additionally setting flag to true if element is found
        /// </remarks>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetSellerName()
        {
            try
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.XPath(sellerNameText)));
                elementIs = true;
                return FindSellerName;
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                elementIs = false;
                return null;
            }
        }

        /// <summary>
        /// a method used for accessing text-element indicating the name of the product
        /// </summary>
        /// <remarks>
        /// additionally setting flag to true if element is found
        /// </remarks>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetItemNameText()
        {
            try
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.Id(itemNameText)));
                elementIs = true;
                return FindItemNameText;
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                elementIs = false;
                return null;
            }
        }

        /// <summary>
        /// a method used for accessing text indicating that the user has opened the Cart
        /// </summary>
        /// <remarks>
        /// additionally setting flag to true if element is found
        /// </remarks>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetYourCartText()
        {
            try
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.Id(yourCartText)));
                elementIs = true;
                return FindYourCartText;
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                elementIs = false;
                return null;
            }
        }

        /// <summary>
        /// a method used for accessing a private element displaying the number of added items
        /// </summary>
        /// <remarks>
        /// additionally setting flag to true if element is found
        /// </remarks>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetNumberOfItemsIcon()
        {
            try
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.Id(numberOfItemsIcon)));
                elementIs = true;
                return FindNumberOfItemsIcon;
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                elementIs = false;
                return null;
            }
        }

        /// <summary>
        /// a method used for accessing textbox containing the number of added items
        /// </summary>
        /// <remarks>
        /// additionally setting flag to true if element is found
        /// </remarks>
        /// <returns>
        /// returns IWebElement
        /// </returns>
        public IWebElement GetNumberOfItemsTextBox()
        {
            try
            {
                GetWaiter().Until(ExpectedConditions.ElementToBeClickable(By.Id(numberOfItemsTextBox)));
                elementIs = true;
                return FindNumberOfItemsTextBox;
            }
            catch (Exception ex) when (ex is WebDriverTimeoutException || ex is NoSuchElementException)
            {
                elementIs = false;
                return null;
            }
        }

        /// <summary>
        /// checks that an element is either displayed or not
        /// </summary>
        /// <returns>
        /// returns True or False
        /// </returns>
        public bool CheckIfElementIsDisplayed(IWebElement element)
        {
            return elementIs;
        }
    }
}