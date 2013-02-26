using System.Collections.Generic;
using System.Linq;
using App.Model;

namespace App.Data.Contracts
{
    public interface ISampleModelRepository : IRepository<SampleModel>
    {
        IQueryable<SampleModel> GetSampleModels();
    }
}
