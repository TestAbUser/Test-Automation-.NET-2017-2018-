using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace GenerationCheck.PageFactoryPattern
{
	public class ConfigureTab : Tab
	{
		[FindsBy(How = How.Name, Using = "OK")]
		private IWebElement okButton;

		[FindsBy(How = How.Name, Using = "Generate")]
		private IWebElement generateTab;

		[FindsBy(How = How.ClassName, Using = "TabControl")]
		[FindsBy(How = How.ClassName, Using = "TextBlock")]
		private IList<IWebElement> textBlocks;

		private IWebDriver driver;

		public ConfigureTab(IWebDriver driver) : base(driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

		public void EnterCredentials()
		{
            System.Threading.Thread.Sleep(10000);
           // wait.Until(ExpectedConditions.ElementIsVisible(By.Name("OK")));
			okButton.Click();
		}

		public GenerateTab GoToGenerateTab()
		{
			foreach (var textBlock in textBlocks)
			{
				if (textBlock.GetAttribute("Name") == "Generate")
				{
                    wait.Until(ExpectedConditions.ElementToBeClickable(generateTab));
                    textBlock.Click();
				}
			}
			return new GenerateTab(driver);
		}
	}
}
