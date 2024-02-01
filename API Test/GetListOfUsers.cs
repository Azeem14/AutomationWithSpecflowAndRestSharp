using Json.Path;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using RestSharp;
using System.Text.Json;
using System.Text.Json.Nodes;
using TechTalk.SpecFlow.Assist.ValueComparers;
using Vitality_Project_Learnings.DTO;
using Vitality_Project_Learnings.Requests;

namespace Vitality_Project_Learnings.API_Test
{
    class GetListOfUsers
    {
        RestClient restclient;

        RestRequest restRequest;

        RestResponse restResponse;

        public void setupBaseURI()
        {
           restclient = RequestHandlers.setUpBaseURI("https://reqres.in/");
        }

        public void validateStatusCode(int statusCode)
        {
            restResponse = restclient.Execute(restRequest);
            Assert.AreEqual(statusCode,(int)restResponse.StatusCode);
        }
        public void validateListOfUsers()
        {
            // GetUsers  users = restclient.Get<GetUsers>(restRequest);
            // RestResponse<GetUsers> resp = restclient.Get<GetUsers>(restRequest);
            GetUsers users = JsonSerializer.Deserialize<GetUsers>(restResponse.Content);
            Assert.AreEqual(users.data.id, 2);
            Assert.AreEqual(users.support.url, "https://reqres.in/#support-heading");
            Assert.AreEqual(users.support.text, "To keep ReqRes free, contributions towards server costs are appreciated!");
        }

        public void PerformRequest(string method, string contentType, string endpoint, string param)
        {
            switch (method)
            {
                case "Get":
                  restRequest = RequestHandlers.PerformGetRequest(endpoint, contentType, param);
                   break;
            }
        }

        public void validateResponseBody(string key, string value)
        {
            JsonDocument doc = JsonDocument.Parse(restResponse.Content);

            JObject jobject = JObject.Parse(restResponse.Content);
            string actualvalue= jobject.SelectToken(key).ToString();
            Assert.AreEqual(value, actualvalue);





        }

    }
}
