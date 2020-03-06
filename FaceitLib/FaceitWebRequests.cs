using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FaceitLib
{
    class FaceitWebRequests<T>
    {
        public static HttpStatusCode statuscode { get; set; }

        public async Task<T> GetRequest(string uri, string apikey)
        {
            using (var client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apikey);
                var response = await client.GetAsync(uri);
                
                statuscode = response.StatusCode;
                if (!response.IsSuccessStatusCode)
                {
                    return default;
                }

                string responsebody = await response.Content.ReadAsStringAsync();

                T result = JsonConvert.DeserializeObject<T>(responsebody);
                return result;
            }
        }
    }
}
