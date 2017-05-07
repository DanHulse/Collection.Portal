using Collections.Portal.Infrastructure;
using Collections.Portal.Services.Interfaces;
using Collections.Portal.ViewModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Portal.Services
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
