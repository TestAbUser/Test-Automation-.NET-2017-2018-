using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GenerationCheck.PageFactoryPattern
{
    /// <summary>
    /// This class finds and initializes elements on Configure Tab
    /// </summary>
    /// <returns></returns>
    public class ConfigureTab : Tab
    {
        protected const string sessionCredentials = "Session Credentials";
        [FindsBy(How = How.Name, Using = "OK")]
        protected IWebElement okButton;

        [FindsBySequence]
        [FindsBy(How = How.Name, Using = sessionCredentials)]
        [FindsBy(How = How.ClassName, Using = "TextBox")]
        protected IWebElement textBox;

        [FindsBy(How = How.Name, Using = "Generate")]
        protected IWebElement generateTab;

        [FindsBy(How = How.ClassName, Using = "TabControl")]
        [FindsBy(How = How.ClassName, Using = "TextBlock")]
        protected IList<IWebElement> textBlocks;

        private IWebDriver driver;

        public ConfigureTab(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
