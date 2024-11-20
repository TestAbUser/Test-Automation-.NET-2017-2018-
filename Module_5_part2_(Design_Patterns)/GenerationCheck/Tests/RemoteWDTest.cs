using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerationCheck.TestSteps;

namespace GenerationCheck.Tests
{
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
