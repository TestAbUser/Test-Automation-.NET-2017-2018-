using OpenQA.Selenium;

namespace GenerationCheck.Utils
{
    /// <summary>
    /// This class contains a method for highlighting web elements
    /// </summary>
    /// <returns></returns>
    public class Highlighter
    {
        public void JSHighlighter(IJavaScriptExecutor js, IWebElement element)
        {
            js.ExecuteScript("arguments[0].style.backgroundColor = 'red'", element);
        }
    }
}
