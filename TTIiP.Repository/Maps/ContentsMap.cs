using Alina.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TTIiP.Repository.Maps;

public class ContentsMap
{
    public ContentsMap(EntityTypeBuilder<Content> builder)
    {
        builder.HasKey(t => t.Id);
        builder
            .HasOne(x => x.SectionItem)
            .WithMany(x => x.Contents)
            .OnDelete(DeleteBehavior.Cascade);
        
    }
}