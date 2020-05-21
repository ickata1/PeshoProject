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
            //One-to-Many Relationship
            modelBuilder.Entity<Preset>()
                .HasMany<PresetSetting>(preset => preset.PresetSettings)
                .WithRequired(presetSetting => presetSetting.Preset)
                .HasForeignKey<int>(presetSetting => presetSetting.PresetId)
                .WillCascadeOnDelete();
            base.OnModelCreating(modelBuilder);
        }
    }
}
