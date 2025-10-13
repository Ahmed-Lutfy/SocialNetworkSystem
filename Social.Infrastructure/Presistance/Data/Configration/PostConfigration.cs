using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Social.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Infrastructure.Presistance.Data.Configration
{
    public class PostConfigration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.Property(m => m.content)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.Property(m => m.isActive)
                   .HasDefaultValue(true);

            //builder.HasOne(m => m.media_url)
            //       .WithMany(c => c.Movies)
            //       .HasForeignKey(m => m.CategoryId)
            //       .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
