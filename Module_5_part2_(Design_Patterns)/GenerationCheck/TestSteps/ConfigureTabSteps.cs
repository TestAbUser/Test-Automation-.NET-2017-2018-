using OpenQA.Selenium;
using GenerationCheck.PageFactoryPattern;
using OpenQA.Selenium.Support.PageObjects;
using GenerationCheck.Tests;
using System.Collections.Generic;

namespace GenerationCheck.TestSteps
{
    public class ConfigureTabSteps : ConfigureTab, AbstractTestSteps
    {
        private IWebDriver driver;

        public ConfigureTabSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement GetTextBox()
        {
            return textBox;
        }

        public IWebElement GetOKButton()
        {
            return okButton;
        }

        public IList<IWebElement> GetTextBlocks()
        {
            return textBlocks;
        }

        public IWebElement GetGenerateTab()
        {
            return generateTab;
        }

        public GenerateTabSteps ClickMethod(IList<IWebElement> arrayOfElements, IWebElement element)
        {
            WaitFactoryMethod(element).Click();
            return new GenerateTabSteps(driver);
        }

        public GenerateTabSteps ClickMethod(IWebElement element, string userName)
        {
            WaitFactoryMethod(element).Click();
            return new GenerateTabSteps(driver);
        }

        public GenerateTabSteps ClickMethod(IWebElement element)
        {
            WaitFactoryMethod(element).Click();
            return new GenerateTabSteps(driver);
        }
    }
}
