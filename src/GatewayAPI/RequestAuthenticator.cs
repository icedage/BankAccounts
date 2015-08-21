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
    public class RequestAuthenticator : RestSharpComponent
    {
        private IRestRequest _restRequest;

        public RequestAuthenticator()
        {
            _restRequest = new RestRequest();
        }

        public void TokenizeRequest(User user)
        {
            _restRequest.AddHeader("Accept", "application/json");
            _restRequest.AddHeader("Content-Type", "application/json");
            _restRequest.AddHeader("username", user.Username);
            _restRequest.AddHeader("password", user.Password);
            _restRequest.AddHeader("grant_type", user.grant_type);

            var jsonDeserializer = new JsonDeserializer();
            var response = Client.Execute<User>(Request);
            var token = jsonDeserializer.Deserialize<User>(response);
            Request.AddHeader("Authorization", string.Format("Bearer {0}", token));

        }

    }
}
