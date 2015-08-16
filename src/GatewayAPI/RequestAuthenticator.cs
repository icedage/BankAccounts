using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI
{
    public class RequestAuthenticator : RestSharpComponent
    {
        public void AddBearerToken()
        {
            //var bearerToken = Execute<User>();
            
            Request.AddHeader("Accept", "application/json");
            Request.AddHeader("Content-Type", "application/json");
            Request.AddHeader("Bearer-Token", "");
            //Execute();
        }

        //private T Execute<T>() where T : new()
        //{
        //    var jsonDeserializer = new JsonDeserializer();
        //    //var response = Request.
        //   // return jsonDeserializer.Deserialize<T>(response);
        //   // return null;
        //}
    }
}
