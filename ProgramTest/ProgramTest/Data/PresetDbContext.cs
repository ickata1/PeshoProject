using Data.Entities;
using System;
using System.Data.Entity;

namespace Data
{
    public class PresetDbContext : DbContext
    {
        public PresetDbContext() : base("name=PresetsDb")
        {

        }
        public virtual DbSet<Preset> Presets { get; set; }
        public virtual DbSet<PresetSetting> PresetSettings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Preset>().HasMany<PresetSetting>(preset => preset.PresetSettings); //Probably doe
            base.OnModelCreating(modelBuilder);
        }
    }
}
