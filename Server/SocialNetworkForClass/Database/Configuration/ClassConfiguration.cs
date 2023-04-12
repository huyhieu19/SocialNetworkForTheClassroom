using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Database.Configuration
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).UseIdentityColumn();


            builder.HasOne(x => x.teacher).WithMany(x => x.classes).HasForeignKey(x => x.teacherId);

        }
    }
}
