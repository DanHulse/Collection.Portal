using Collection.Portal.Infrastructure;
using Collection.Portal.Services.Interfaces;
using Collection.Portal.ViewModels;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Portal.Services
{
    public class CollectionService : ICollectionService
    {
        private readonly AppSettings config;

        private readonly IRestSharpService restService;

        public CollectionService(AppSettings config, IRestSharpService restService)
        {
            this.config = config;
            this.restService = restService;
        }

        public IEnumerable<T> Get<T>() where T : new()
        {
            this.restService.Url = $"{this.config.ApiUrl}/Movies";
            this.restService.RequestMethod = HttpMethod.Get;

            var result = this.restService.Execute<T>();

            var deserialisedResults = JsonConvert.DeserializeObject<List<T>>(result.Content);

            return deserialisedResults;
        }

        public bool PostAsync<T>(IEnumerable<T> model)
        {
            this.restService.Url = $"{this.config.ApiUrl}/Movies";
            this.restService.Body = model;
            this.restService.RequestMethod = HttpMethod.Post;

            var result = this.restService.Execute();

            return true;
        }
    }
}
