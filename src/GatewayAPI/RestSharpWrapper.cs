using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI
{
    public class RestSharpWrapper: RestSharpComponentDecorator
    {
        public void Test(string url, Method method)
        {
            component.Request.Resource = url;
            component.Request.Method = method;
        }
        
        public void AddHeader(IDictionary<string,string> headers)
        {
            foreach (KeyValuePair<string, string> header in headers)
            {
                component.Request.AddHeader(header.Key, header.Value);
            }
        }

        public void AddJsonBody(object entity)
        {
            component.Request.AddJsonBody(entity);
        }

        public void AddBody(object entity)
        {
            component.Request.AddBody(entity);
        }

        public T Execute<T>() where T : class, new()
        {
            var jsonDeserializer = new JsonDeserializer();
            var response = Client.Execute<T>(Request);
            return jsonDeserializer.Deserialize<T>(response);
        }
    }
}
