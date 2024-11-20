using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GenerationCheck.PageFactoryPattern;
using OpenQA.Selenium.Support.UI;
using GenerationCheck.Tests;
using System.Collections.Generic;

namespace GenerationCheck.TestSteps
{
    public class GenerateTabSteps: GenerateTab, AbstractTestSteps
    {
        private IWebDriver driver;

        public GenerateTabSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// This method is a part of FactoryMethod Pattern realization
        /// </summary>
        /// <returns></returns>
      public override IWebElement WaitFactoryMethod(IWebElement element)
        {
            System.Threading.Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element.GetAttribute("Name"))));
            return element;
        }

        public void WaitMethod()
        { 
           wait.Until(ExpectedConditions.ElementToBeClickable(generateAndCreateButton));
        }

        public IWebElement GetCheckBox()
        {
            return checkBox;
        }

        public IWebElement GetGenerateAndCreateButton()
        {
            return generateAndCreateButton;
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

        /// <summary>
        /// unchecking unnecessary logging levels so that only error messages are displayed
        /// </summary>
        /// <returns></returns>
        public GenerateTabSteps UncheckLogLevelsExceptError()
        {
            WaitMethod();
            foreach (var button in buttons)
            {
                if (button.GetAttribute("HelpText") != "Error")
                {
                    button.Click();
                }
            }
            return new GenerateTabSteps(driver);
        }

        /// <summary>
        ///checking that there are no error messages in the Generation log
        /// </summary>
        /// <returns></returns>
        public bool CheckIfRowsDisplayed()
        {
            try
            {
                return dataGridRow.Displayed;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }


    }
}
