using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest.Local_Data
{
    public class LocalPresetDbContext : DbContext
    {
        public LocalPresetDbContext() : base("name=LocalPresetDb")
        {

        }

        public virtual DbSet<Preset> Presets { get; set; }
        public virtual DbSet<PresetSetting> PresetSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions
            .Remove<PluralizingTableNameConvention>();

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
