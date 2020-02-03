using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetDevTaskPuppies.Model;
using GetDevTaskPuppies.Shared;
using Refit;

namespace GetDevTaskPuppies.Services
{
    [Headers("x-api-key: d2a9f1fe-2de6-4a2a-baa7-083dd9358984")]
    public interface IDogApi
    {
        [Get("/search")]
        Task<List<DogResponse>> Search();
    }
}
