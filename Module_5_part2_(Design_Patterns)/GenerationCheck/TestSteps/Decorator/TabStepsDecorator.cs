using GenerationCheck.Tests;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace GenerationCheck.TestSteps.Decorator
{
    public abstract class TabStepsDecorator : Tab, AbstractTestSteps
    {
        private IWebDriver driver;
        private AbstractTestSteps test;

        public TabStepsDecorator(AbstractTestSteps test, IWebDriver driver) : base(driver)
        {
            this.test = test;
            this.driver = driver;
        }

        public virtual GenerateTabSteps GoToAnotherTab(IWebElement element)
        {
            return new GenerateTabSteps(driver);
        }

        public virtual GenerateTabSteps ClickMethod(IList<IWebElement> arrayOfElements, IWebElement element)
        {
            return new GenerateTabSteps(driver);
        }

        public virtual GenerateTabSteps ClickMethod(IWebElement element, string userName)
        {
            WaitFactoryMethod(element).Click();
            return new GenerateTabSteps(driver);
        }

        public virtual GenerateTabSteps ClickMethod(IWebElement element)
        {
            WaitFactoryMethod(element).Click();
            return new GenerateTabSteps(driver);
        }
    }
}
