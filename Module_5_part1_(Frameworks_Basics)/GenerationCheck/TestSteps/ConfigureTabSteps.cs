using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using GenerationCheck.PageFactoryPattern;
using OpenQA.Selenium.Support.PageObjects;

namespace GenerationCheck.TestSteps
{
    /// <summary>
    /// This class defines steps necessary for going from Configure Tab to Generate Tab
    /// </summary>
    /// <returns></returns>
    public class ConfigureTabSteps : ConfigureTab
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

        public ConfigureTabSteps ChangeUserName()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name(sessionCredentials)));
            Actions action = new Actions(driver);
            action.SendKeys(textBox, "Example").Build().Perform();
            return new ConfigureTabSteps(driver);
        }

        public ConfigureTabSteps EnterCredentials()
        {
            Actions action = new Actions(driver);
            action.Click(okButton).Build().Perform();
            return new ConfigureTabSteps(driver);
        }

        public GenerateTabSteps GoToGenerateTab()
        {
            foreach (var textBlock in textBlocks)
            {
                if (textBlock.GetAttribute("Name") == "Generate")
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(generateTab));
                    textBlock.Click();
                }
            }
            return new GenerateTabSteps(driver);
        }
    }
}
