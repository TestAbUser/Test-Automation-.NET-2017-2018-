using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerationCheck.TestSteps;
using GenerationCheck.Utils;

namespace GenerationCheck.tests
{
    /// <summary>
    ///checking clicking with JS
    /// </summary>
    /// <returns></returns>
    [TestClass]
    public class JSExecutorTest : JSExecutorTestSteps
    {
        [TestMethod]
        public void TestJS()
        {
            JSClickWeb(ChromeInitializer.chromeDriver);
        }
    }
}
