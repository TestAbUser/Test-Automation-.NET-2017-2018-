using GenerationCheck.Utils;

namespace GenerationCheck.TestSteps
{
    /// <summary>
    /// This class defines steps for testing click using JS and Selenium Grid
    /// </summary>
    /// <returns></returns>
    public class RemoteWDTestSteps : BrowsersInitializer
    {
        protected void TestGrid()
        {
            JSExecutorTestSteps.JSClickWeb(driverChrome);
            JSExecutorTestSteps.JSClickWeb(driverFirefox);
        }
    }
}
