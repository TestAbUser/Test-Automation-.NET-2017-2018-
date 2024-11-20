using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using CartPage = BDDTesting.PageObjects.CartPage;
using HomePage = BDDTesting.PageObjects.HomePage;
using ItemPage = BDDTesting.PageObjects.ItemPage;
using SearchResultsPage = BDDTesting.PageObjects.SearchResultsPage;
using NUnit.Framework;

namespace BDDTesting
{
    /// <summary>
    /// this class contains steps for CheckThatCartHasItem.feature
    /// </summary>
    /// <remarks>
    /// each of the methods corresponds to a line from the feature
    /// </remarks>
    [Binding]
    public class CheckThatCartHasItemSteps
    {
        private readonly IWebDriver chromeDriver;

        /// <summary>
        /// getting initialized driver from CheckClickSteps class
        /// </summary>
        public CheckThatCartHasItemSteps(CheckClickSteps driver)
        {
            chromeDriver = driver.GetDriver();
        }

        public IWebDriver GetDriver()
        {
            return chromeDriver;
        }

        /// <summary>
        /// setting cursor in the Search field on Home Page
        /// </summary>
        [When(@"User clicks on Search field")]
        public void WhenUserClicksOnSearchField()
        {
            HomePage homePage = new HomePage(chromeDriver);
            homePage.GetSearchField().Click();
        }

        /// <summary>
        /// entering the name of the necessary item into the Search field
        /// </summary>
        /// <remarks>
        /// using actions for the purpose
        /// </remarks>
        [When(@"types word brush")]
        public void WhenTypesWordBrush()
        {
            HomePage homePage = new HomePage(chromeDriver);
            Actions action = new Actions(chromeDriver);
            action.SendKeys(homePage.GetSearchField(), "brush").Build().Perform();
        }

        /// <summary>
        /// clicking "Find" button
        /// </summary>
        [When(@"clicks Find button")]
        public void WhenClicksFindButton()
        {
            HomePage homePage = new HomePage(chromeDriver);
            homePage.GetFindButton().Click();
        }

        /// <summary>
        /// selecting the first item in the list that appears
        /// </summary>
        /// <remarks>
        /// using the image of the item for that purpose
        /// </remarks>
        [When(@"selects the first item in the list")]
        public void WhenSelectsTheFirstItemInTheList()
        {
            SearchResultsPage searchResultsPage = new SearchResultsPage(chromeDriver);
            searchResultsPage.GetFirstElementsImage().Click();
        }

        /// <summary>
        /// clicking "Add to Cart" button on the Item Page
        /// </summary>
        /// <remarks>
        /// first we wait to make sure the element is clickable
        /// </remarks>
        [When(@"clicks on Add to cart button")]
        public void WhenClicksOnAddToCartButton()
        {
            ItemPage itemPage = new ItemPage(chromeDriver);
            ItemPage.GetWaiter().Until(ExpectedConditions.ElementToBeClickable(itemPage.GetAddToCartButton()));
            itemPage.GetAddToCartButton().Click();
        }

        /// <summary>
        /// checking that there is an icon showing the number of the added items
        /// </summary>
        /// <returns>
        /// returns either True or False
        /// </returns>
        [Then(@"the item appears in the cart")]
        public void ThenTheItemAppearsInTheCart()
        {
            CartPage cartPage = new CartPage(chromeDriver);
            Assert.IsTrue(cartPage.CheckIfElementIsDisplayed(cartPage.GetNumberOfItemsIcon()));
        }
    }
}



