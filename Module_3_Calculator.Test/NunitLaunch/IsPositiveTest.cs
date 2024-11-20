using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'isPositive' method of Calculator")]

    public class IsPositiveTest : BaseTest
    {
        [Test]
        public void TestIsPositive1()
        {
            Assert.That(myCalculator.isPositive(4), Is.EqualTo(true));
        }

        [Test]
        public void TestIsPositive2()
        {
            Assert.That(myCalculator.isPositive("4"), Is.EqualTo(true));
        }
    }
}