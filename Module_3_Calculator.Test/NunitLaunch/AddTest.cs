using NUnit.Framework;

namespace NunitLaunch
{
    [TestFixture]
    [Author("Rashid")]
    [Description("Testing 'Add' method of Calculator")]

    public class AddTest : BaseTest
    {

        [TestCase(2, 2, ExpectedResult = 4)]
        public double TestAdd1(double a, double b)
        {
            return myCalculator.Add(a, b);
        }

        [TestCase("2", "2", ExpectedResult = 4)]
        public double TestAdd2(string a, string b)
        {
            return myCalculator.Add(a, b);
        }
    }
}
