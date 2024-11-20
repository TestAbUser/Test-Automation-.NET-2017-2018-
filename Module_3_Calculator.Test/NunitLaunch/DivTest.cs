using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Divide' method of Calculator")]

    public class DivTest : BaseTest
    {
        [Test]
        public void TestDivide1()
        {
            Assert.That(myCalculator.Divide(4, 2), Is.EqualTo(2));
        }

        // The use of string numbers isn't tested, as only numbers of type "double" can be used for the method: Divide(double, double)
    }
}
