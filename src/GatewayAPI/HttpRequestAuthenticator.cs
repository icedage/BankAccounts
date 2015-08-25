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
            _restRequest.AddHeader("Accept", "application/json");
            _restRequest.AddHeader("Content-Type", "application/json");
            _restRequest.AddHeader("username", user.Username);
            _restRequest.AddHeader("password", user.Password);
            _restRequest.AddHeader("grant_type", user.grant_type);

            var jsonDeserializer = new JsonDeserializer();
            var response = Client.Execute<User>(_restRequest);
            var userResponse = jsonDeserializer.Deserialize<User>(response);
            return userResponse.access_token;
        }

    }
}
