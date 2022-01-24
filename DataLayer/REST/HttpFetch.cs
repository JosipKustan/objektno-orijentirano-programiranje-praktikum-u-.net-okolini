using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer.REST
{
    public class HttpFetch
    {

        public static async Task<T> FetchDataFromUrlAsync<T>(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            var response = await client.ExecuteAsync(request);

            return JsonConvert.DeserializeObject<T>(response.Content);
            
        }

        
    }
}
