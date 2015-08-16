using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI
{
    class Program
    {
        public static void Main(string[] args)
        { 
            // Without Authorization
            var wrapper = new RestSharpWrapper();

            //With Authorization
            var authorizewrapper = new RequestAuthenticator();
            authorizewrapper.AddBearerToken();

            wrapper.SetComponent(authorizewrapper);
            wrapper.Test("http://www.google.com", Method.POST);
           // wrapper.AddHeader1();

        }
    }
}
