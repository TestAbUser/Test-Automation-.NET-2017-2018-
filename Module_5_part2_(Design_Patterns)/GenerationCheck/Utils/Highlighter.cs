using OpenQA.Selenium;

namespace GenerationCheck.Utils
{
    public class Highlighter
    {
        public void JSHighlighter(IJavaScriptExecutor js, IWebElement element)
        {
            js.ExecuteScript("arguments[0].style.backgroundColor = 'red'", element);
        }
    }
}
