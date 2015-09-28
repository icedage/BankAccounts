using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI
{
    public abstract class HttpRequestDecorator : RestSharpComponent
    {
        protected RestSharpComponent component;

        public HttpRequestDecorator(RestSharpComponent component)
        {
            this.component = component;
        }
    }
}
