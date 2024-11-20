using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerationCheck.TestSteps;
using GenerationCheck.Driver;

namespace GenerationCheck.Tests
{
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
