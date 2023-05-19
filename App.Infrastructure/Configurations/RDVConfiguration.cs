using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ApplicationCore.Domain;

namespace App.Infrastructure.Configurations
{
    public class RDVConfiguration : IEntityTypeConfiguration<RDV>
    {

        //Table porteuse de donnés config
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            builder.HasKey(t => new
            {
                t.ClientFK,
                t.PrestationFK,
                t.DateRDV
                
            });

            builder.HasOne(rdv => rdv.Client)
                .WithMany(client => client.RDVs)
                .HasForeignKey(rdv => rdv.ClientFK);

            builder.HasOne(rdv => rdv.Prestation)
               .WithMany(prestation => prestation.RDVs)
               .HasForeignKey(rdv => rdv.PrestationFK);
        }
    }
}
