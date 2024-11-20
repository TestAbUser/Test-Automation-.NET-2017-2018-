using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace GenerationCheck
{


    public class SeleniumExtensionMethods : WebDriverWait
    {
        // public void WebDriverWait(IWebDriver driver, TimeSpan timeout)
        //  {

        //    }
        /*
        public SeleniumExtensionMethods() : base(TestGeneration.driver, TestGeneration.timeout)
        {

        }*/

  
        public SeleniumExtensionMethods(RemoteWebDriver driver, TimeSpan timeout) : base(driver, timeout)
        {
            Timeout = TimeSpan.FromSeconds(10);
            PollingInterval = TimeSpan.FromMilliseconds(250);
            Message = "Time ended";
            //  System.Threading.Thread.Sleep(5000);
        }
        
        public bool Until<IWebElement>(Func<RemoteWebDriver, IWebElement> condition)
        {
            Timeout = TimeSpan.FromSeconds(10);
            PollingInterval = TimeSpan.FromMilliseconds(250);
            System.Threading.Thread.Sleep(5000);
            // var p = (IWebElement)TestGeneration.driver.FindElement(By.Name("OK"));
            condition = delegate (RemoteWebDriver p)
              {
                  System.Threading.Thread.Sleep(5000);
               //   p = TestGeneration.driver;
                  //  TestGeneration.driver.FindElement(By.Name("OK"));
                  var n = p.FindElement(By.Name("OK"));

                  // var n = TestGeneration.driver.FindElement(By.Name("OK"));
 
                  return (IWebElement)n;//(IWebElement)n.FindElement(By.Name("OK"));
              };
            var okButton = TestGeneration.driver.FindElement(By.Name("OK"));
            okButton.Click();
            return true;


        }

    }
    /*     public  RemoteWebDriver driver;
         public  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
         public  bool SafeClick(this IWebElement webElement, string locatorAttribute)
         {
             bool truth= false;
             //try
             //{
             if (webElement.GetAttribute("OK") == locatorAttribute)
             {
                 truth = true;
             }
             return truth;
             //}
            // catch (TargetInvocationException ex)
            // {
             //    Console.WriteLine(ex.InnerException);
            // }

         }
     }*/
}
