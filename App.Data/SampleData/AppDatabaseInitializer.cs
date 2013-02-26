using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using App.Model;

namespace App.Data.SampleData
{
    public class AppDatabaseInitializer :
        //CreateDatabaseIfNotExists<CodeCamperDbContext>      // when model is stable
        DropCreateDatabaseIfModelChanges<AppDbContext> // when iterating
    {

        protected override void Seed(AppDbContext context)
        {
            addSampleModels(context);
        }

        protected Random Rand = new Random();

        private void addSampleModels(AppDbContext context)
        {
            context.SampleModels.Add(new SampleModel { Id = 1, Title = "This is a sample model added during seeding." });

            context.SaveChanges();
        }
    }
}