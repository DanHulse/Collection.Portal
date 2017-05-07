using Collections.Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Portal.Services.Interfaces
{
    public interface ICollectionService
    {
        bool PostAsync<T>(IEnumerable<T> model);
    }
}
