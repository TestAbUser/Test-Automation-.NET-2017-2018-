using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
namespace GenerationCheck.PageFactoryPattern
{
    public class GenerateTab : Tab
    {
        [FindsBy(How = How.ClassName, Using = "DataGridColumnHeader")]
        private IWebElement header;

        [FindsBy(How = How.ClassName, Using = "CheckBox")]
        private IWebElement checkBox;

        [FindsBy(How = How.ClassName, Using = "GenerationView")]
        private IWebElement generationView;

        [FindsBy(How = How.Id, Using = "GenerateAndCreateButton")]
        private IWebElement generateAndCreateButton;

        [FindsBy(How = How.ClassName, Using = "ProcessInfoView")]
        private IWebElement processInfoView;

        [FindsBy(How = How.ClassName, Using = "InformationStatusBar")]
        private IWebElement informationStatusBar;

        [FindsBy(How = How.Name, Using = "No background processes are running now.")]
        private IWebElement backgroundProcess;

        [FindsBySequence]
        [FindsBy(How = How.ClassName, Using = "LogLevelButtonsView")]
        [FindsBy(How = How.ClassName, Using = "Button")]
        private IList<IWebElement> buttons;

        [FindsBySequence]
        [FindsBy(How = How.ClassName, Using = "GenerationLogView")]
        [FindsBy(How = How.ClassName, Using = "DataGrid")]
        [FindsBy(How = How.ClassName, Using = "DataGridRow")]
        private IWebElement dataGridRow;

        private IWebDriver driver;

        public GenerateTab(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // Checking "Select All" checkbox to select all items for generation
        public GenerateTab SelectAllItemsForGeneration()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(checkBox));
            checkBox.Click();
            return new GenerateTab(driver);
        }

        public GenerateTab RunGenerationWithCreating()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(generateAndCreateButton));
            generateAndCreateButton.Click();
            return new GenerateTab(driver);
        }

        public GenerateTab WaitUntilGenerationEnds()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("No background processes are running now.")));
            return new GenerateTab(driver);
        }

        // unchecking unnecessary logging levels so that only error messages are displayed
        public GenerateTab UncheckLogLevelsExceptError()
        {
            foreach (var button in buttons)
            {
                if (button.GetAttribute("HelpText") != "Error")
                {
                    button.Click();
                }
            }
            return new GenerateTab(driver);
        }

        //checking that there are no error messages in the Generation log
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
