using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI
{
    public class RestSharpWrapper<T>: RestSharpComponentDecorator
    {
        public RestSharpWrapper(string url, Method method)
        {
            if (component == null)
            {
                component.Request = new RestRequest(url,method);
                component.Client = new RestClient("http://localhost/BankAccountsAPI/");
            }
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

        //public T Execute<T>(string url, Method method) where T : class, new()
        //{
        //    component.Request.Resource = url;
        //    component.Request.Method = method;
        //    var jsonDeserializer = new JsonDeserializer();
        //    var response = component.Request.Execute<T>(component.Request);
        //    return jsonDeserializer.Deserialize<T>(response);
        //}
    }
}
