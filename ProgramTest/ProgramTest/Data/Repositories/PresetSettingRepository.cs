using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PresetSettingRepository : CrudRepository<PresetSetting>
    {
        public PresetSettingRepository(PresetDbContext dbContext) : base(dbContext, dbContext.PresetSettings)
        {

        }
        /// <summary>
        /// Returns all preset settings that belong to a preset found by Id
        /// </summary>
        /// <param name="presetId"></param>
        /// <returns></returns>
        public IQueryable<PresetSetting> GetPresetSettings(int presetId)
        {
            return this.GetAll(item => item.PresetId == presetId);     
        }

        public void Add(PresetSetting presetSetting, Preset preset)
        {



        }
    }
}
