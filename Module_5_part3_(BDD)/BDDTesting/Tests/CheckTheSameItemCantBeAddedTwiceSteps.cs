using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using CartPage = BDDTesting.PageObjects.CartPage;
using NUnit.Framework;

namespace BDDTesting
{
    /// <summary>
    /// this class contains steps for CheckTheSameItemCantBeAddedTwice.feature
    /// </summary>
    /// <remarks>
    /// only new steps are generated. The rest of the steps are taken from CheckThatCartHasItem.feature
    /// </remarks>
    [Binding]
    public class CheckTheSameItemCantBeAddedTwiceSteps
    {
        private IWebDriver chromeDriver;

        /// <summary>
        /// getting initialized driver from CheckIfCartHasItemSteps class
        /// </summary>
        public CheckTheSameItemCantBeAddedTwiceSteps(CheckThatCartHasItemSteps driver)
        {
            this.chromeDriver = driver.GetDriver();
        }

        /// <summary>
        /// after checking that the item has been added to the cart we go to the previous page
        /// </summary>
        [When(@"User goes to the previous page")]
        public void WhenUserGoesToThePreviousPage()
        {
            chromeDriver.Navigate().Back();
        }

        /// <summary>
        /// checking that the number of items in the cart stayed the same
        /// </summary>
        /// <returns>
        /// returns either True or False
        /// </returns>
        [Then(@"the number of items in the cart doesn't change")]
        public void ThenTheNumberOfItemsInTheCartDoesnTChange()
        {
            var expectedNumber = 1;
            CartPage cartPage = new CartPage(chromeDriver);
            Assert.That(Convert.ToInt16(cartPage.GetNumberOfItemsTextBox().GetAttribute("Value")), Is.EqualTo(expectedNumber));
        }
    }
}
