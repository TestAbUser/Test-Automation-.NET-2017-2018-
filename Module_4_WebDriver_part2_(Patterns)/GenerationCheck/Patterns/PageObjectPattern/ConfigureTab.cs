using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GenerationCheck.PageObjectPattern
{
	public class ConfigureTab : Tab
	{
		private const string okButton = "OK";
		private const string tabControl = "TabControl";
		private const string textBlocks = "TextBlock";
		private const string generateTab = "Generate";
		private const string attributeName = "Name";

		private IWebDriver driver;

		public ConfigureTab(IWebDriver driver) : base(driver)
		{
			this.driver = driver;
		}

		private IWebElement FindOkButton
		{
			get { return driver.FindElement(By.Name(okButton)); }
		}

        private IWebElement FindGenerateTab
		{
			get { return driver.FindElement(By.Name(generateTab)); }
		}

        private IWebElement FindTabControl
		{
			get { return driver.FindElement(By.ClassName(tabControl)); }
		}

        private IList<IWebElement> FindTextBlocks
		{
			get { return FindTabControl.FindElements(By.ClassName(textBlocks)); }
		}

		public void EnterCredentials()
		{
			wait.Until(ExpectedConditions.ElementIsVisible(By.Name(okButton)));
			FindOkButton.Click();
		}

		public GenerateTab GoToGenerateTab()
		{
			foreach (var textBlock in FindTextBlocks)
			{
				if (textBlock.GetAttribute(attributeName) == "Generate")
				{
					wait.Until(ExpectedConditions.ElementToBeClickable(FindGenerateTab));
					textBlock.Click();
				}
			}
			return new GenerateTab(driver);
		}
	}
}
