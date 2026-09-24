using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

    DbSet<Education> Educations { get; set; }
    DbSet<Experience> Experiences { get; set; }
    DbSet<Project> Projects { get; set; }
    DbSet<ProjectTranslation> ProjectTranslations { get; set; }
    DbSet<EducationTranslation> EducationTranslations { get; set; }
    DbSet<ExperienceTranslation> ExperienceTranslations { get; set; }
}
