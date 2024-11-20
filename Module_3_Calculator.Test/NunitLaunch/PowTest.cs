using System;
using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Pow' method of Calculator")]

    public class PowTest : BaseTest
    {
        [Test]
        public void TestPow1()
        {
            Assert.That(myCalculator.Pow(2, 2), Is.EqualTo(Math.Pow(2, 2)));
        }

        [Test]
        public void TestPow2()
        {
            Assert.That(myCalculator.Pow("2", "2"), Is.EqualTo(Math.Pow(2, 2)));
        }
    }
}