using System;
using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Cos' method of Calculator")]

    public class CosTest : BaseTest
    {
        [Test]
        public void TestCos1()
        {
            Assert.That(myCalculator.Cos(0), Is.EqualTo(Math.Cos(0)));
        }

        [Test]
        public void TestCos2()
        {
            Assert.That(myCalculator.Cos("0"), Is.EqualTo(Math.Cos(0)));
        }
    }
}
