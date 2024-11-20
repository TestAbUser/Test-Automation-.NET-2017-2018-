using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using GenerationCheck.PageFactoryPattern;

namespace GenerationCheck.TestSteps
{
    /// <summary>
    /// This class defines steps necessary for running Generation with Creating and checks that there are no errors in the log
    /// </summary>
    /// <returns></returns>
    public class GenerateTabSteps : GenerateTab
    {
        private IWebDriver driver;

        public GenerateTabSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Checking "Select All" checkbox to select all items for generation
        /// </summary>
        /// <returns></returns>
        public GenerateTabSteps SelectAllItemsForGeneration()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(checkBox));
            checkBox.Click();
            return new GenerateTabSteps(driver);
        }

        public GenerateTabSteps RunGenerationWithCreating()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(generateAndCreateButton));
            generateAndCreateButton.Click();
            return new GenerateTabSteps(driver);
        }

        public GenerateTabSteps WaitUntilGenerationEnds()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("No background processes are running now.")));
            return new GenerateTabSteps(driver);
        }

        /// <summary>
        /// Unchecking unnecessary logging levels so that only error messages are displayed
        /// </summary>
        /// <returns></returns>
        public GenerateTabSteps UncheckLogLevelsExceptError()
        {
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
        /// Checking that there are no error messages in the Generation log
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
