using GenerationCheck.Driver;

namespace GenerationCheck.TestSteps.Builder
{
    public class User1Steps : BuilderInterface
    {
        public void RunUserSteps()
        {
            ECEInitializer init1 = new ECEInitializer();
            init1.Initialize();
            ConfigureTabSteps user1ConfigureTabSteps = new ConfigureTabSteps(init1.GetDriver());
            GenerateTabSteps user1GenerateTabSteps = new GenerateTabSteps(init1.GetDriver());
            user1ConfigureTabSteps.ClickMethod(user1ConfigureTabSteps.GetOKButton());
        }
    }
}
