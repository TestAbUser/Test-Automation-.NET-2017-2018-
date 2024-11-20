using GenerationCheck.Driver;

namespace GenerationCheck.TestSteps
{
    public class RemoteWDTestSteps : RemoteBrowsersInitializerSingleton
    {
        protected void TestGrid()
        {
            JSExecutorTestSteps.JSClickWeb(RemoteBrowsersInitializerSingleton.GetChromeInitializer());
            JSExecutorTestSteps.JSClickWeb(RemoteBrowsersInitializerSingleton.GetFirefoxInitializer());
        }
    }
}
