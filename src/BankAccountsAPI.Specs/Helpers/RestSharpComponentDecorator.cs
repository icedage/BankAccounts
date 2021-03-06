﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Specs.Helpers
{
    public class RestSharpComponentDecorator : RestSharpComponent
    {
        protected RestSharpComponent component;

        public RestSharpComponentDecorator(RestSharpComponent component)
        {
            this.component = component;
        }
    }
}
