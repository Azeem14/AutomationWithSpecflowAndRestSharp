using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitality_Project_Learnings.Requests
{
   class RequestHandlers
    {
      public static RestClient restclient;

      public static RestRequest restRequest;

      public static RestResponse restResponse;

        public static RestClient setUpBaseURI(string url)
        {
            restclient = new RestClient(url);
            return restclient;
        }

        public static RestRequest PerformGetRequest(string endpoint, string contentType, string param)
        {
            if (param.Equals("NA")) { 
            restRequest = new RestRequest(endpoint, Method.Get);
            restRequest.AddHeader("Content-Type", contentType);
            restRequest.RequestFormat = DataFormat.Json;
            }
            else
            {
                string pathParamVariable = endpoint.Split("{")[1].Replace("}", "");
                restRequest = new RestRequest(endpoint, Method.Get);
                restRequest.AddHeader("Accept", contentType);
                restRequest.AddParameter(pathParamVariable, param.Split(":")[1], ParameterType.UrlSegment);
                restRequest.RequestFormat = DataFormat.Json;
            }
            return restRequest;
        }

        public void validateStatusCode(int statusCode)
        {
            restResponse = restclient.Execute(restRequest);
            Assert.AreEqual((int)restResponse.StatusCode, statusCode);

        }


    }

}
