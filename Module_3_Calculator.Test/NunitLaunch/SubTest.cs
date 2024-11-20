using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Sub' method of Calculator")]

    public class SubTest : BaseTest
    {
        [Test]
        public void TestSub1()
        {
            Assert.That(myCalculator.Sub(10, 10), Is.EqualTo(0));
        }

        [TestCase("6", "2", ExpectedResult = 4)]
        public double TestSub2(string a, string b)
        {
            return myCalculator.Sub(a, b);
        }
    }
}