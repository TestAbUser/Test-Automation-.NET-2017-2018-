using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using CartPage = BDDTesting.PageObjects.CartPage;
using ItemPage = BDDTesting.PageObjects.ItemPage;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BDDTesting.Tests
{
    /// <summary>
    /// this class contains steps for CheckThatSeveralItemsCanBeAdded.feature
    /// </summary>
    /// <remarks>
    /// only new steps are generated. The rest of the steps are taken from CheckThatCartHasItem.feature
    /// </remarks>
    [Binding]
    public class CheckThatSeveralItemsCanBeAddedSteps
    {
        private readonly IWebDriver chromeDriver;

        /// <summary>
        /// getting initialized driver from CheckIfCartHasItemSteps class
        /// </summary>
        public CheckThatSeveralItemsCanBeAddedSteps(CheckThatCartHasItemSteps driver)
        {
            chromeDriver = driver.GetDriver();
        }

        /// <summary>
        /// changing the number of the selected items
        /// </summary>
        /// <remarks>
        /// at first the input area is cleared, then new value is entered. Two different values are used
        /// </remarks>
        [When(@"puts number of the items as (.*)")]
        public void WhenPutsNumberOfTheItemsAs(int inputNumber)
        {
            ItemPage itemPage = new ItemPage(chromeDriver);
            Actions action = new Actions(chromeDriver);
            itemPage.GetNumberOfItemsInputArea().Clear();
            action.SendKeys(itemPage.GetNumberOfItemsInputArea(), inputNumber.ToString()).Build().Perform();
        }

        /// <summary>
        /// checking that the number of items added to the cart matches the number of items selected
        /// </summary>
        /// <returns>
        /// returns either True or False
        /// </returns>
        [Then(@"the number of items in the cart changes to (.*)")]
        public void ThenTheNumberOfItemsInTheCartChangesTo(int expectedNumber)
        {
            CartPage cartPage = new CartPage(chromeDriver);
            Assert.That(Convert.ToInt16(cartPage.GetNumberOfItemsTextBox().GetAttribute("Value")), Is.EqualTo(expectedNumber));

        }
    }
}







