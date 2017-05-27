using Collection.Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Portal.Services.Interfaces
{
    public interface ICollectionService
    {
        IEnumerable<T> Get<T>() where T : new();

        bool PostAsync<T>(IEnumerable<T> model);
    }
}
