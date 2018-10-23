using System;
using TechTalk.SpecFlow;

namespace BasicAtmMachine.Specs
{
    [Binding]
    public class GetMoneySteps
    {
        [Given(@"I have inserted my card into the ATM machine")]
        public void GivenIHaveInsertedMyCardIntoTheATMMachine()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"my card is valid")]
        public void GivenMyCardIsValid()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I ask for (.*) bucks")]
        public void WhenIAskForBucks(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the machine should give me (.*) bucks")]
        public void ThenTheMachineShouldGiveMeBucks(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should give me my card back")]
        public void ThenItShouldGiveMeMyCardBack()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
