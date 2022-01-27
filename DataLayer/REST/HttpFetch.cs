using DataLayer.Constants;
using DataLayer.Model;
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

            if (!response.IsSuccessful)
            {
                throw new Exception("Http request not successful");
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
            
        }

        public static async Task<IList<Match>> GetMatchesFromHTTPAsync(String fifaCode, String URL_BASE)
        {
            IList<Match> matches = new List<Match>();
            try
            {
                matches = await HttpFetch.FetchDataFromUrlAsync<IList<Match>>(URL_BASE + UrlConstants.MATCH_BY_FIFA_CODE + fifaCode);
            }
            catch (Exception)
            {
                throw new Exception("Could not fetch data from the interwebs");
            }
            return matches;

        }
    }
}
