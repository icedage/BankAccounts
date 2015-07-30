using System;
using TechTalk.SpecFlow;

namespace BankAccountsAPI.Specs
{
    [Binding]
    public class BankAccountsSteps
    {
        [Given(@"the user is authenticated")]
        public void GivenTheUserIsAuthenticated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"he posts to the following inputs to the bank end system")]
        public void WhenHePostsToTheFollowingInputsToTheBankEndSystem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user requests an account with (.*)")]
        public void WhenUserRequestsAnAccountWith(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the account exists")]
        public void WhenTheAccountExists()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user posts to create an account with invalid data")]
        public void WhenUserPostsToCreateAnAccountWithInvalidData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user updates an account")]
        public void WhenUserUpdatesAnAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user makes a request to the same account")]
        public void WhenUserMakesARequestToTheSameAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user makes a request to get all the accounts")]
        public void WhenUserMakesARequestToGetAllTheAccounts()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system should return that account")]
        public void ThenTheSystemShouldReturnThatAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system should return a Bad Request Status Code")]
        public void ThenTheSystemShouldReturnABadRequestStatusCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should be able to retrieve the updated account")]
        public void ThenUserShouldBeAbleToRetrieveTheUpdatedAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"system should return a list of all the accounts")]
        public void ThenSystemShouldReturnAListOfAllTheAccounts()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
