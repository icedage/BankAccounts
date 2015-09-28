using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatewayAPI.Entities;

namespace GatewayAPI
{
    public class HttpRequestAuthenticator : RestSharpComponent
    {
        private IRestRequest _restRequest;

        public HttpRequestAuthenticator()
        {
            _restRequest = new RestRequest("oauth/token", Method.POST);
        }

        public void TokenizeRequest(User user)
        {
            var token = GetToken(user);
            Request.AddHeader("Accept", "application/json");
            Request.AddHeader("Content-Type", "application/json");
            Request.AddHeader("Authorization", string.Format("Bearer {0}", token));
        }

        private string GetToken(User user)
        {
            //_restRequest.AddParameter("Accept", "application/json");
            string encodedBody = string.Format("grant_type={0}&username={1}&password={2}", "password", "SuperUser", "P@ssword123");
            _restRequest.AddParameter("application/x-www-form-urlencoded", encodedBody, ParameterType.RequestBody);
            _restRequest.AddParameter("Content-Type", "application/x-www-form-urlencoded", ParameterType.HttpHeader);

            var jsonDeserializer = new JsonDeserializer();
            var response = Client.Execute<User>(_restRequest);
            var userResponse = jsonDeserializer.Deserialize<User>(response);
            return userResponse.access_token;
        }

    }
}
