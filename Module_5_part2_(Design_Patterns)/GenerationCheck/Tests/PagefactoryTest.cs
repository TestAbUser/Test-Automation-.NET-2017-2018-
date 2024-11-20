using GenerationCheck.TestSteps.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenerationCheck.Tests
{
    [TestClass]
    public class PagefactoryTest
    {
        [TestMethod]
        public void TestBuilder()
        {
            PageFactoryTestSteps steps = new PageFactoryTestSteps();
            BuilderInterface builderOne = new User1Steps();
            steps.Construct(builderOne);
            BuilderInterface builderTwo = new User2Steps();
            steps.Construct(builderTwo);
        }

    }
}
