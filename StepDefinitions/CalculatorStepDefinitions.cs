using System.ComponentModel;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int a)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            Console.WriteLine("The first number is :" + a);
            throw new PendingStepException();
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int b)
        {
            //TODO: implement arrange (precondition) logic
            Console.WriteLine("The second number is :"+b);

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            Console.WriteLine("Adding two numbers");

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int c)
        {
            //TODO: implement assert (verification) logic
            Console.WriteLine("The result number is :" + c);


            throw new PendingStepException();
        }
    }
}
