using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiAutomationFramework.Utils
{
    public class RestClientUtil
    {
        static RestClient restClient;
        static RestRequest restRequest;
        static DataFormat dataFormat;


        public RestClient RestClient
        {
            get
            {
                if (restClient == null)
                {
                    return new RestClient(ConfigurationManager.AppSettings["BaseUrl"].ToString());
                }
                else { return restClient; }
            }

        }

        public static RestRequest createRequest(string resource, Method method)
        {
            if (restRequest == null)
            {
                return new RestRequest(resource, Method.Post);
            }
            else { return restRequest; }
        }
        //POST
        public static T Post<T>(string resource, string payload)
        {
            //RestRequest request = createRequest(resource, Method.Post);
            //request.RequestFormat = DataFormat.Json;
            return JsonConvert.DeserializeObject<T>(restClient.Execute(createRequest(resource, Method.Post).AddBody(payload)).Content);
        }
        //GET
        //DELETE
    }
}
