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
            var wrapper = new HttpRequestWrapper(string.Empty, Method.POST);

            //With Authorization
            var authorizewrapper = new HttpRequestAuthenticator();
            authorizewrapper.TokenizeRequest(new Entities.User());

            wrapper.SetComponent(authorizewrapper);
            
           // wrapper.AddHeader1();

        }
    }
}
