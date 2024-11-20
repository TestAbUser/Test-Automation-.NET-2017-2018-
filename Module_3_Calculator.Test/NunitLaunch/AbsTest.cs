using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Abs' method of Calculator")]

    public class AbsTest : BaseTest
    {
        [Test]
        public void TestAbs1()
        {
            Assert.That(myCalculator.Abs(-10), Is.EqualTo(10));
        }

        [Test]
        public void TestAbs2()
        {
            Assert.That(myCalculator.Abs("-10"), Is.EqualTo(10));
        }

    }
}
