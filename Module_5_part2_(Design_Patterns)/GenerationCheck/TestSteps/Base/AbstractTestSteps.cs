using GenerationCheck.TestSteps;
using OpenQA.Selenium;
using System.Collections.Generic;
using GenerationCheck.BusinessObjects;

namespace GenerationCheck.Tests
{
    public interface AbstractTestSteps
    {
        GenerateTabSteps ClickMethod(IList<IWebElement> arrayOfElements, IWebElement element);
        GenerateTabSteps ClickMethod(IWebElement element, string userName);
        GenerateTabSteps ClickMethod(IWebElement element);
    }
}
