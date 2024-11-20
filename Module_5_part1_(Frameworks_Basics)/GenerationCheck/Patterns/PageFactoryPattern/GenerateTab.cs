using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GenerationCheck.PageFactoryPattern
{
    /// <summary>
    /// This class finds and initializes elements on Generate Tab
    /// </summary>
    /// <returns></returns>
    public class GenerateTab : Tab
    {
        [FindsBy(How = How.ClassName, Using = "DataGridColumnHeader")]
        protected IWebElement header;

        [FindsBy(How = How.ClassName, Using = "CheckBox")]
        protected IWebElement checkBox;

        [FindsBy(How = How.ClassName, Using = "GenerationView")]
        protected IWebElement generationView;

        [FindsBy(How = How.Id, Using = "GenerateAndCreateButton")]
        protected IWebElement generateAndCreateButton;

        [FindsBy(How = How.ClassName, Using = "ProcessInfoView")]
        protected IWebElement processInfoView;

        [FindsBy(How = How.ClassName, Using = "InformationStatusBar")]
        protected IWebElement informationStatusBar;

        [FindsBy(How = How.Name, Using = "No background processes are running now.")]
        protected IWebElement backgroundProcess;

        [FindsBySequence]
        [FindsBy(How = How.ClassName, Using = "LogLevelButtonsView")]
        [FindsBy(How = How.ClassName, Using = "Button")]
        protected IList<IWebElement> buttons;

        [FindsBySequence]
        [FindsBy(How = How.ClassName, Using = "GenerationLogView")]
        [FindsBy(How = How.ClassName, Using = "DataGrid")]
        [FindsBy(How = How.ClassName, Using = "DataGridRow")]
        protected IWebElement dataGridRow;

        private IWebDriver driver;

        public GenerateTab(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }



    }
}
