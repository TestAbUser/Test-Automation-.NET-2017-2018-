using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using GenerationCheck.Tests;

namespace GenerationCheck.TestSteps.Decorator
{
    [TestClass]
    public class ActionsStepsDecorator : TabStepsDecorator
    {
        private IWebDriver driver;
        private IWebElement okButton;

        public ActionsStepsDecorator(ConfigureTabSteps configureTabSteps, AbstractTestSteps test, IWebDriver driver) : base(test, driver)
        {
            this.driver = driver;
            okButton = configureTabSteps.GetOKButton();
        }

        /// <summary>
        ///checking that actions 'SendKeys' work
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public override GenerateTabSteps ClickMethod(IWebElement element, string userName )
        {
            WaitFactoryMethod(element);
            element.Clear();
            Actions action = new Actions(driver);
            action.SendKeys(element, userName).Build().Perform();
            base.ClickMethod(okButton);
            return new GenerateTabSteps(driver);

        }
    }
}