using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI
{
    public class HttpRequestWrapper : HttpRequestDecorator
    {
        public HttpRequestWrapper(string url, Method method)
        {
            if (component == null)
            {
                component.Client = new RestClient("http://localhost/BankAccountsAPI/");
            }

            component.Request = new RestRequest(url, method);
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

        public T Execute<T>() where T : class
        {
            var jsonDeserializer = new JsonDeserializer();
            var response = component.Client.Execute(component.Request);
            return jsonDeserializer.Deserialize<T>(response);
        }
    }
}
