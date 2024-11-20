using OpenQA.Selenium;
using GenerationCheck.Tests;
using System.Collections.Generic;

namespace GenerationCheck.TestSteps.Decorator
{

    public class GoingToAnotherTabDecorator : TabStepsDecorator
    {
        private IWebDriver driver;

        public GoingToAnotherTabDecorator(AbstractTestSteps test, IWebDriver driver) : base(test, driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// This class can be used for going to different tabs
        /// </summary>
        /// <returns></returns>
        public override GenerateTabSteps ClickMethod(IList<IWebElement> arrayOfElements, IWebElement element)
        {
            foreach (var elementFromArray in arrayOfElements)
            {
                if (elementFromArray.GetAttribute("Name") == element.GetAttribute("Name"))
                {

                    base.ClickMethod(elementFromArray);
                    break;
                }
            }
            return new GenerateTabSteps(driver);
        }
    }
}



