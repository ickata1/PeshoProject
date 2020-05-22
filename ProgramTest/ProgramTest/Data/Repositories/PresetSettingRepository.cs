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

        //Returns all PresetSetting entities with the given id
        public IQueryable<PresetSetting> GetPresetSettings(int presetSettingId)
        {
            return this.GetAll(item => item.PresetId == presetSettingId);      
        }
    }
}
