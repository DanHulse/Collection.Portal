using Collections.Portal.Infrastructure;
using Collections.Portal.Services.Interfaces;
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

        public CollectionService(IOptions<AppSettings> config)
        {
            this.config = config.Value;
        }

        public bool PostAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.config.ApiUri;
            }

            return true;
        }
    }
}
