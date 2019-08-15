using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CallHelloAPI
{
    public class Helper
    {
        string apiUrl = "http://localhost:50530/";
        public HttpClient InitializeClient()
        {
            var client = new HttpClient();
          
            client.BaseAddress = new Uri(apiUrl);

            client.DefaultRequestHeaders.Clear();
            
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
