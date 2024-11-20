using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerationCheck.Driver;
using GenerationCheck.TestSteps.Decorator;
using GenerationCheck.Tests;
using GenerationCheck.BusinessObjects;

namespace GenerationCheck.TestSteps.Builder
{
    public class User2Steps : BuilderInterface
    {
        public void RunUserSteps()
        {
            User2 user = new User2();
            ECEInitializer init = new ECEInitializer();
            init.Initialize();
            ConfigureTabSteps configureTabSteps = new ConfigureTabSteps(init.GetDriver());
            GenerateTabSteps generateTabSteps = new GenerateTabSteps(init.GetDriver());
            AbstractTestSteps newConfigureTabSteps = new ConfigureTabSteps(init.GetDriver());
            newConfigureTabSteps = new ActionsStepsDecorator(configureTabSteps, newConfigureTabSteps, init.GetDriver());
            newConfigureTabSteps.ClickMethod(configureTabSteps.GetTextBox(), user.GetSessionUserName());
            newConfigureTabSteps = new GoingToAnotherTabDecorator(newConfigureTabSteps, init.GetDriver());
            newConfigureTabSteps.ClickMethod(configureTabSteps.GetTextBlocks(), configureTabSteps.GetGenerateTab());
            generateTabSteps.ClickMethod(generateTabSteps.GetCheckBox());
            generateTabSteps.ClickMethod(generateTabSteps.GetGenerateAndCreateButton());
            generateTabSteps.UncheckLogLevelsExceptError();
            Assert.IsFalse(generateTabSteps.CheckIfRowsDisplayed());
            init.GetDriver().Quit();
        }
    }
}