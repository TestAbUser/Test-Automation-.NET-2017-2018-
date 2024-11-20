using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GenerationCheck.PageFactoryPattern
{
    /// <summary>
    /// This class finds elements on Configure Tab
    /// </summary>
    /// <returns></returns>
    public class ConfigureTab : Tab
    {
        [FindsBy(How = How.Name, Using = "OK")]
        protected IWebElement okButton;

        [FindsBy(How = How.Name, Using = "Session Credentials")]
        protected IWebElement sessionCredentials;

        [FindsBySequence]
        [FindsBy(How = How.Name, Using = "Session Credentials")]
        [FindsBy(How = How.ClassName, Using = "TextBox")]
        protected IWebElement textBox;

        [FindsBy(How = How.Name, Using = "Generate")]
        protected IWebElement generateTab;

        [FindsBy(How = How.ClassName, Using = "TabControl")]
        [FindsBy(How = How.ClassName, Using = "TextBlock")]
        protected IList<IWebElement> textBlocks;

        public ConfigureTab(IWebDriver driver) : base(driver)
        {

        }
    }
}
