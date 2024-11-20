using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;


namespace GenerationCheck
{
	[TestClass]
	public class TestGeneration
	{
		public static DesiredCapabilities dc;
		public static IWebDriver driver;


		[TestInitialize]
		public void RunECE()
		{
			dc = new DesiredCapabilities();
			dc.SetCapability("app", @"C:\Users\...\ECE.exe");
			driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
		}

		public void EnterCredentials()
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			wait.Until(ExpectedConditions.ElementIsVisible(By.Name("OK")));
			var okButton = driver.FindElement(By.Name("OK"));
			okButton.Click();
		}

		public void GoToGenerateTab()
		{
			var tabControl = driver.FindElement(By.ClassName("TabControl"));
			var tabItems = tabControl.FindElements(By.ClassName("TextBlock"));
			foreach (var textBlock in tabItems)
			{
				if (textBlock.GetAttribute("Name") == "Generate")
				{
					IWebElement generate = textBlock;
					WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
					wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("Generate")));
					generate.Click();
				}
			}
		}

		// Checking "Select All" checkbox to select all items for generation
		public void SelectAllItemsForGeneration()
		{
			var header = driver.FindElement(By.ClassName("DataGridColumnHeader"));
			var checkBox = driver.FindElement(By.ClassName("CheckBox"));
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("CheckBox")));
			checkBox.Click();
		}

		// Running Generation with creating tables for the selected items
		public void RunGenerationWithCreating()
		{
			var generationView = driver.FindElement(By.ClassName("GenerationView"));
			var generateAndCreateButton = generationView.FindElement(By.Id("GenerateAndCreateButton"));
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("GenerateAndCreateButton")));
			generateAndCreateButton.Click();
		}

		public void WaitUntilGenerationEnds()
		{
			var processInfoView = driver.FindElement(By.ClassName("ProcessInfoView"));
			var informationStatusBar = processInfoView.FindElement(By.ClassName("InformationStatusBar"));
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			wait.Until(ExpectedConditions.ElementIsVisible(By.Name("No background processes are running now.")));
		}

		// unchecking unnecessary logging levels so that only error messages are displayed
		public void UncheckLogLevelsExceptError()
		{
		//	var generationView = driver.FindElement(By.ClassName("GenerationView"));
			var logLevelButtonsView = driver.FindElement(By.ClassName("LogLevelButtonsView"));
			var buttons = logLevelButtonsView.FindElements(By.ClassName("Button"));
			foreach (var button in buttons)
			{
				if (button.GetAttribute("HelpText") != "Error")
				{
					button.Click();
				}
			}
		}

		// Checking that there are no error messages in the log area
		[TestMethod]
		public void FindErrorMessagesInLog()
		{
			EnterCredentials();
			GoToGenerateTab();
			SelectAllItemsForGeneration();
			RunGenerationWithCreating();
			WaitUntilGenerationEnds();
			UncheckLogLevelsExceptError();
			var generationLogView = driver.FindElement(By.ClassName("GenerationLogView"));
			var dataGrid = generationLogView.FindElement(By.ClassName("DataGrid"));
			var dataGridRows = dataGrid.FindElements(By.ClassName("DataGridRow"));
			foreach (var row in dataGridRows)
			{
				var dateOfGeneration = row.FindElement(By.ClassName("DataGridCell"));
				var logCell = row.FindElement(By.Name("Item: ECE.Infrastructure.Logging.GenerationLogRecord, Column Display Index: 6"));
				var errorImage = logCell.FindElement(By.ClassName("Image"));
				errorImage.GetAttribute("HelpText");
				Assert.AreNotEqual(errorImage.GetAttribute("HelpText"), "Error");
			}
		}
	}
}



