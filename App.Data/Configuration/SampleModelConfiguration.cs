using System.Data.Entity.ModelConfiguration;
using App.Model;

namespace App.Data
{
    public class SampleModelConfiguration : EntityTypeConfiguration<SampleModel>
    {
        public SampleModelConfiguration()
        {
            // Session has 1 Speaker, Speaker has many Session records

            //HasRequired(s => s.Speaker)
            //   .WithMany(p => p.SpeakerSessions)
            //   .HasForeignKey(s => s.SpeakerId);
        }
    }
}