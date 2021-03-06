﻿using AccountsAPI.Specs.Entities;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Specs.Helpers
{
    public class RequestAuthenticator : RestSharpComponentDecorator
    {
        private IRestRequest _restRequest;
        private IRestClient _restClient;
        private User _user;

        public RequestAuthenticator(User user, RestSharpComponent component) : base(component)
        {
            _user = user;
            _restClient = new RestClient("http://localhost/BankAccountsAPI/token");
            _restRequest = new RestRequest();
        }

        public void AddAuthorizationHeader()
        {
            var bearerToken = Execute<User>();
            Request.AddHeader("Bearer-Token",bearerToken.Token);
        }

        private T Execute<T>() where T : new()
        {
            _restRequest.AddHeader("Accept","application/json");
            _restRequest.AddHeader("Content-Type", "application/json");
            var jsonDeserializer = new JsonDeserializer();
            var response= _restClient.Execute<T>(_restRequest);
            return jsonDeserializer.Deserialize<T>(response);
        }
    }
}
