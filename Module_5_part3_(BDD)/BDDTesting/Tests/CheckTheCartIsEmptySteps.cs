using TechTalk.SpecFlow;
using OpenQA.Selenium;
using ItemPage = BDDTesting.PageObjects.ItemPage;
using CartPage = BDDTesting.PageObjects.CartPage;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace BDDTesting
{
    /// <summary>
    /// this class contains steps for CheckTheCartIsEmpty.feature
    /// </summary>
    /// <remarks>
    /// only new steps are generated. The rest of the steps are taken from CheckThatCartHasItem.feature
    /// </remarks>
    [Binding]
    public class CheckTheCartIsEmptySteps
    {
        private readonly IWebDriver chromeDriver;

        /// <summary>
        /// getting initialized driver from CheckIfCartHasItemSteps class
        /// </summary>
        public CheckTheCartIsEmptySteps(CheckThatCartHasItemSteps driver)
        {
            this.chromeDriver = driver.GetDriver();
        }

        /// <summary>
        /// changing the number of the selected items
        /// </summary>
        /// <remarks>
        /// at first the input area is cleared, then new value is entered. The value is 0
        /// </remarks>
        [When(@"selects (.*) items")]
        public void WhenSelectsItems(string numberOfItems)
        {
            numberOfItems = "0";
            ItemPage itemPage = new ItemPage(chromeDriver);
            Actions action = new Actions(chromeDriver);
            itemPage.GetNumberOfItemsInputArea().Clear();
            action.SendKeys(itemPage.GetNumberOfItemsInputArea(), numberOfItems).Build().Perform();
        }

        /// <summary>
        /// checking that the cart is empty
        /// </summary>
        /// <remarks>
        /// making sure that there is no icon displaying the number of added items
        /// </remarks>
        /// <returns>
        /// returns either True or False
        /// </returns>
        [Then(@"the cart stays empty")]
        public void ThenTheCartStaysEmpty()
        {
            CartPage cartPage = new CartPage(chromeDriver);
            Assert.IsFalse(cartPage.CheckIfElementIsDisplayed((cartPage.GetNumberOfItemsIcon())));
        }
    }
}


