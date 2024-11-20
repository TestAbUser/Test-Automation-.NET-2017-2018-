using System;
using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Sin' method of Calculator")]

    public class SinTest : BaseTest
    {
        [Test]
        public void TestSin1()
        {
            Assert.That(myCalculator.Sin(0), Is.EqualTo(Math.Sin(0)));
        }

        [Test]
        public void TestSin2()
        {
            Assert.That(myCalculator.Sin("0"), Is.EqualTo(Math.Sin(0)));
        }
    }
}