using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class PresetSettingRepository : CrudRepository<PresetSetting>
    {
        public PresetSettingRepository(PresetDbContext dbContext) : base(dbContext, dbContext.PresetSettings)
        {

        }

        public IQueryable<PresetSetting> GetPresetSettings(int presetSettingId)
        {
            return this.GetAll(item => item.PresetId == presetSettingId);      //Returns all PresetSetting entities with this id
        }
    }
}
