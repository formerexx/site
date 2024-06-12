using System.Collections.Specialized;
using Alina.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TTIiP.Repository.Maps;

namespace TTIiP.Repository;

public class ApplicationContext:DbContext
{
    public DbSet<Section> Sections { get; set; }
    public DbSet<SectionItem> SectionItems { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<Heading> Headings { get; set; }
    public DbSet<ContentsOfTables> ContentsOfTablesEnumerable { get; set; }
    public DbSet<CardNews> CardsNews { get; set; }
    public DbSet<News> ManyNews { get; set; }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new NewsMap(modelBuilder.Entity<News>());
        new ContentsMap(modelBuilder.Entity<Content>());

    }
}
