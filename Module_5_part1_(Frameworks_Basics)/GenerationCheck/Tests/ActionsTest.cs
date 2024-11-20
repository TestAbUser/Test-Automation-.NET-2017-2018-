using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfigureTabSteps = GenerationCheck.TestSteps.ConfigureTabSteps;
using GenerationCheck.Utils;

namespace GenerationCheck.tests
{
    /// <summary>
    ///checking that actions 'SendKeys' and 'Click' work
    /// </summary>
    /// <returns></returns>
    [TestClass]
    public class ActionsTest : ECEInitializer
    {
        [TestMethod]
        public void TestActions()
        {
            ConfigureTabSteps configureTab = new ConfigureTabSteps(driver);
            configureTab.ChangeUserName().EnterCredentials();
        }
    }
}