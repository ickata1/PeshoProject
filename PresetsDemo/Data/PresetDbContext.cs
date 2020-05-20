using Data.Entities;
using System;
using System.Data.Entity;

namespace Data
{
    public class PresetDbContext : DbContext
    {
        public virtual DbSet<Preset> Presets { get; set; }
        public virtual DbSet<PresetSetting> PresetSettings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=PresetDemo;Integrated Security=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Preset>().HasMany(preset => preset.PresetSettings).WithOne(presetSetting => presetSetting.Presets).OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
    }
}
