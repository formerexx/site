using Alina.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TTIiP.Repository.Maps;

public class NewsMap 
{
    public NewsMap(EntityTypeBuilder<News> builder)
    {
        builder.HasKey(t => t.Id);
        builder.HasOne(t => t.CardNews).
            WithOne(u => u.News).
            HasForeignKey<CardNews>(x => x.Id);
    }

  
}