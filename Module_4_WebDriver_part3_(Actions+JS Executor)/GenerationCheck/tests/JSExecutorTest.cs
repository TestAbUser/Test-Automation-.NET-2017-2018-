using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace GenerationCheck.tests
{
    [TestClass]
    public class JSExecutorTest
    {
        //checking that JS click works
        [TestMethod]
        public void TestJSClickWeb()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yandex.ru/");
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("document.querySelector('a.link.teaser__link').click()");
        }

        //checking that JS highlighting works
        [TestMethod]
        public void TestJSHighlighter()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yandex.ru/");
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            var element = driver.FindElement(By.Id("wd-wrapper-_weather"));
            js.ExecuteScript("arguments[0].style.backgroundColor = 'red'", element);
        }
    }
}
