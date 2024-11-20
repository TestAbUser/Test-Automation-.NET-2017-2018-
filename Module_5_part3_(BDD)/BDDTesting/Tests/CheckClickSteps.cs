using TechTalk.SpecFlow;
using OpenQA.Selenium;
using HomePage = BDDTesting.PageObjects.HomePage;
using CartPage = BDDTesting.PageObjects.CartPage;
using NUnit.Framework;
using BDDTesting.BusinessObjects;
using BDDTesting.Driver;


namespace BDDTesting
{
    /// <summary>
    /// this class contains steps for CheckClick.feature
    /// </summary>
    /// <remarks>
    /// each of the methods corresponds to a line from the feature
    /// </remarks>
    [Binding]
    public class CheckClickSteps
    {
        private readonly  IWebDriver chromeDriver;

        /// <summary>
        /// getting initialized driver from DriverInitialization class
        /// </summary>
        public CheckClickSteps(DriverInitialization driver)
        {
            chromeDriver = driver.GetDriver();
        }

        public IWebDriver GetDriver()
        {
            return chromeDriver;
        }

        /// <summary>
        /// going to the Home Page
        /// </summary>
        /// <remarks>
        /// the Home page is located at the following address: https://www.ebay.com/
        /// </remarks>
        [Given(@"User is on homepage")]
        public void GivenUserIsOnHomepage()
        {
            Browser browser = new Browser();
            chromeDriver.Url = browser.GetHomePageURL();
        }

        /// <summary>
        /// User clicks on Cart icon on Home page
        /// </summary>
        [When(@"User clicks add cart button")]
        public void WhenUserClicksAddCartButton()
        {
            HomePage homePage = new HomePage(chromeDriver);
            homePage.FindOpenCartButton.Click();
        }

        /// <summary>
        /// Checking that there is "Your Cart" text on the page
        /// </summary>
        /// <returns>
        /// returns either True or False
        /// </returns>
        [Then(@"The content of the cart is displayed on the screenn")]
        public void ThenTheContentOfTheCartIsDisplayedOnTheScreenn()
        {
            CartPage cartPage = new CartPage(chromeDriver);
            Assert.IsTrue(cartPage.CheckIfElementIsDisplayed(cartPage.GetYourCartText()));
        }
    }
}
