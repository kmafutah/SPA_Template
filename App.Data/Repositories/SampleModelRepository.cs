using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using App.Data.Contracts;
using App.Model;

namespace App.Data
{
    public class SampleModelRepository : EFRepository<SampleModel>, ISampleModelRepository
    {
        public SampleModelRepository(DbContext context) : base(context) { }

        public IQueryable<SampleModel> GetSampleModels()
        {
            return DbSet.Select(s => new SampleModel
            {
                Title = s.Title
            });
        }

    }
}
