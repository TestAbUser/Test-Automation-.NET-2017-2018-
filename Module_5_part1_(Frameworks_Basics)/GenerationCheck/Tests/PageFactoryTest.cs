using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfigureTabSteps = GenerationCheck.TestSteps.ConfigureTabSteps;
using GenerateTabSteps = GenerationCheck.TestSteps.GenerateTabSteps;
using GenerationCheck.Utils;

namespace GenerationCheck.tests
{
    /// <summary>
    /// This test checks that Generation with Creating passes without errors
    /// </summary>
    /// <returns></returns>
    [TestClass]
    public class PageFactoryTest : ECEInitializer
    {
        [TestMethod]
        public void TestPageFactory()
        {
            ConfigureTabSteps configureTab = new ConfigureTabSteps(driver);
            configureTab.ChangeUserName().EnterCredentials();
            GenerateTabSteps generateTab = configureTab.GoToGenerateTab();
            generateTab.SelectAllItemsForGeneration().RunGenerationWithCreating().WaitUntilGenerationEnds().UncheckLogLevelsExceptError();
            Assert.IsFalse(generateTab.CheckIfRowsDisplayed());
            driver.Quit();
        }
    }
}
