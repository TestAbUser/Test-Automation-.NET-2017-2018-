using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GenerationCheck.PageObjectPattern
{
    public class GenerateTab : Tab
    {
        private const string header = "DataGridColumnHeader";
        private const string checkBox = "CheckBox";
        private const string generationView = "GenerationView";
        private const string generateAndCreateButton = "GenerateAndCreateButton";
        private const string processInfoView = "ProcessInfoView";
        private const string informationStatusBar = "InformationStatusBar";
        private const string backgroundProcess = "No background processes are running now.";
        private const string logLevelButtonsView = "LogLevelButtonsView";
        private const string buttons = "Button";
        private const string generationLogView = "GenerationLogView";
        private const string dataGrid = "DataGrid";
        private const string dataGridRow = "DataGridRow";
        private const string item = "Item: ECE.Infrastructure.Logging.GenerationLogRecord, Column Display Index: 6";
        private const string errorImage = "Image";
        public const string attributeHelpText = "HelpText";


        private IWebElement FindHeader
        {
            get { return driver.FindElement(By.ClassName(header)); }
        }

        private IWebElement FindCheckBox
        {
            get { return driver.FindElement(By.ClassName(checkBox)); }
        }

        private IWebElement FindGenerationView
        {
            get { return driver.FindElement(By.ClassName(generationView)); }
        }

        private IWebElement FindGenerateAndCreateButton
        {
            get { return driver.FindElement(By.Id(generateAndCreateButton)); }
        }
        private IWebElement FindProcessInfoView
        {
            get { return driver.FindElement(By.ClassName(processInfoView)); }
        }

        private IWebElement FindInformationStatusBar
        {
            get { return driver.FindElement(By.ClassName(informationStatusBar)); }
        }

        private IWebElement FindBackgroundProcess
        {
            get { return driver.FindElement(By.Name(backgroundProcess)); }
        }

        private IWebElement FindLogLevelButtonsView
        {
            get { return driver.FindElement(By.ClassName(logLevelButtonsView)); }
        }

        private IList<IWebElement> FindButtons
        {
            get { return FindLogLevelButtonsView.FindElements(By.ClassName(buttons)); }
        }

        private IWebElement FindGenerationLogView
        {
            get { return driver.FindElement(By.ClassName(generationLogView)); }
        }

        private IWebElement FindDataGrid
        {
            get { return FindGenerationLogView.FindElement(By.ClassName(dataGrid)); }
        }

        private IWebElement FindDataGridRow
        {
            get { return FindDataGrid.FindElement(By.ClassName(dataGridRow)); }
        }

        private IWebDriver driver;

        public GenerateTab(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        // Checking "Select All" checkbox to select all items for generation
        public GenerateTab SelectAllItemsForGeneration()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name(backgroundProcess)));
            FindCheckBox.Click();
            return new GenerateTab(driver);
        }

        // Running Generation with creating tables for the selected items
        public GenerateTab RunGenerationWithCreating()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FindGenerateAndCreateButton));
            FindGenerateAndCreateButton.Click();
            return new GenerateTab(driver);
        }

        public GenerateTab WaitUntilGenerationEnds()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name(backgroundProcess)));
            return new GenerateTab(driver);
        }

        // unchecking unnecessary logging levels so that only error messages are displayed
        public GenerateTab UncheckLogLevelsExceptError()
        {
            foreach (var button in FindButtons)
            {
                if (button.GetAttribute(attributeHelpText) != "Error")
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
                return FindDataGridRow.Displayed;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }
    }
}


