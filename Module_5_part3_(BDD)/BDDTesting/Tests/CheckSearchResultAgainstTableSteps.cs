using TechTalk.SpecFlow;
using OpenQA.Selenium;
using CartPage = BDDTesting.PageObjects.CartPage;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using BDDTesting.BusinessObjects;

namespace BDDTesting
{
    [Binding]
    public class CheckSearchResultAgainstTable
    {
        private readonly IWebDriver chromeDriver;

        /// <summary>
        /// creating an instance of a class that will contain required parameters
        /// </summary>
        RequiredParameters parameters = new RequiredParameters();

        /// <summary>
        /// getting initialized driver from CheckThatCartHasItemSteps class
        /// </summary>
        public CheckSearchResultAgainstTable(CheckThatCartHasItemSteps driver)
        {
            chromeDriver = driver.GetDriver();
        }

        /// <summary>
        /// populating the parameters table with the data from CheckSearchResultAgainstTable.feature
        /// </summary>
        [Given(@"User has to acquire a certain item:")]
        public void GivenUserHasToAcquireACertainItem(Table table)
        {
            parameters = table.CreateInstance<RequiredParameters>();
        }

        /// <summary>
        /// asserting that the search result product matches the required parameters
        /// </summary>
        [Then(@"User can assert that the required item is present")]
        public void ThenUserCanAssertThatTheRequiredItemIsPresent()
        {
            CartPage cartPage = new CartPage(chromeDriver);
            Assert.That(cartPage.GetSellerName().Text, Is.EqualTo(parameters.SellerName));
            Assert.That(cartPage.GetItemNameText().Text, Is.EqualTo(parameters.ProductName));
            Assert.That(cartPage.GetPrice().Text, Is.EqualTo(parameters.Price));
        }
    }
}
