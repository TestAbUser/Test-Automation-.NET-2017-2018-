using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpCalculator;


namespace NunitLaunch
{
    [SetUpFixture]
    public class BaseTest
    {
       public Calculator myCalculator;

        [OneTimeSetUp]
        public void InitializeTest()
        {
            Console.WriteLine("BaseTest initialization");
            myCalculator = new Calculator();
           
        }

        [OneTimeTearDown]
        public void CleanUpTest ()
        {
            Console.WriteLine("BaseTest cleaning up");
            myCalculator = null;
            
        }

        
    }
}
