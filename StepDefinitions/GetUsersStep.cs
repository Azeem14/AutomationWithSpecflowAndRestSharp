using System.Net;
using System.Security.Cryptography;
using Vitality_Project_Learnings.API_Test;
using Vitality_Project_Learnings.Requests;

namespace Vitality_Project_Learnings.StepDefinitions
{

    [Binding]
    class GetUsersStep
    {
        GetListOfUsers getListOfUsers;

        public GetUsersStep()
        {
            getListOfUsers = new GetListOfUsers();
        }

        [Given(@"the API endpoint for get list users is available")]
        public void GivenTheAPIEndpointForGetListUsersIsAvailable()
        {
            getListOfUsers.setupBaseURI();
        }

        [When(@"I make a ""([^""]*)"" with ""([^""]*)"" to the endpoint ""([^""]*)"" with ""([^""]*)""")]
        public void WhenIMakeAWithToTheEndpointWith(string method, string contentType, string endpoint, string param)
        {
            getListOfUsers.PerformRequest(method, contentType, endpoint,param);
        }



        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int statusCode)
        {
            getListOfUsers.validateStatusCode(statusCode);
        }

        [Then(@"the response should contain a list of users")]
        public void ThenTheResponseShouldContainAListOfUsers()
        {
            getListOfUsers.validateListOfUsers();
        }

        [Then(@"the response body should contain ""([^""]*)"" and ""([^""]*)""")]
        public void ThenTheResponseBodyShouldContainAnd(string key, string value)
        {
            getListOfUsers.validateResponseBody(key,value);
        }




    }
}
