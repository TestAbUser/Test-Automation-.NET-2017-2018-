using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace GenerationCheck.PageFactoryPattern
{
    public class ConfigureTab
    {
        private const string sessionCredentials = "Session Credentials";
        public static WebDriverWait wait;

        [FindsBy(How = How.Name, Using = "OK")]
        private IWebElement okButton;

        [FindsBySequence]
        [FindsBy(How = How.Name, Using = sessionCredentials)]
        [FindsBy(How = How.ClassName, Using = "TextBox")]
        private IWebElement textBox;

        private IWebDriver driver;

        public ConfigureTab(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public ConfigureTab TestClickButton()
        {
            Actions action = new Actions(driver);
            action.Click(okButton).Build().Perform();
            return new ConfigureTab(driver);
        }

        public ConfigureTab TestSendKeys()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name(sessionCredentials)));
            Actions action = new Actions(driver);
            action.SendKeys(textBox, "Example").Build().Perform();
            return new ConfigureTab(driver);
        }
    }
}