namespace GenerationCheck.TestSteps.Builder
{
    public class PageFactoryTestSteps
    {
        public void Construct(BuilderInterface userBuilder)
        {
            userBuilder.RunUserSteps();
        }
    }
}