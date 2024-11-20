using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Multiply' method of Calculator")]

    public class MultiplyTest : BaseTest
    {
        [Test]
        public void TestMultiply()
        {
            Assert.That(myCalculator.Multiply(2, 2), Is.EqualTo(4));
        }
        // The use of string numbers isn't tested, as only numbers of type "double" can be used for the method: Multiply(double, double)
    }
}