using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerationCheck.TestSteps;

namespace GenerationCheck.tests
{
    /// <summary>
    /// This test uses Selenium Grid 
    /// </summary>
    /// <returns></returns>
    [TestClass]
    public class RemoteWDTest : RemoteWDTestSteps
    {
        [TestMethod]
        public void TestRemoteConnection()
        {
            TestGrid();
        }
    }
}
