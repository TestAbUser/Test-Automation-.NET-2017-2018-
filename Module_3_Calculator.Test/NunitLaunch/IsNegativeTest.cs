using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'isNegative' method of Calculator")]

    public class IsNegativeTest : BaseTest
    {
        [Test]
        public void TestIsNegative1()
        {
            Assert.That(myCalculator.isNegative(-4), Is.EqualTo(true));
        }

        [Test]
        public void TestIsNegative2()
        {
            Assert.That(myCalculator.isNegative("-4"), Is.EqualTo(true));
        }
    }
}
