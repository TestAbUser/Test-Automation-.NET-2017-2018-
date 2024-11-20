using System;
using NUnit.Framework;


namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Sqrt' method of Calculator")]

    public class SqrtTest : BaseTest
    {
        [Test]
        public void TestSqrt1()
        {
            Assert.That(myCalculator.Sqrt(4), Is.EqualTo(Math.Sqrt(4)));
        }

        [Test]
        public void TestSqrt2()
        {
            Assert.That(myCalculator.Sqrt("4"), Is.EqualTo(Math.Sqrt(4)));
        }
    }
}
