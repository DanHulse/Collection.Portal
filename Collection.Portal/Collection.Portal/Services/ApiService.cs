using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Collection.Portal.Services
{
    /// <summary>
    /// Api service calls
    /// </summary>
    public class ApiService
    {
        /// <summary>
        /// The collection API URL
        /// </summary>
        private readonly string collectionApiUrl;

        public ApiService()
        {
            this.collectionApiUrl = "http://collections-api.azurewebsites.net/api/v1";
        }

        /// <summary>
        /// Gets records the asynchronously.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<List<T>> GetAsync<T>()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync($"{this.collectionApiUrl}/Movies");

                var results = JsonConvert.DeserializeObject<List<T>>(response);

                return results;
            }
        }
    }
}