using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest.Local_Data.Repo
{
    public class PresetRepository : CrudRepository<Preset>
    {
        public PresetRepository(LocalPresetDbContext dbContext) : base(dbContext, dbContext.Presets)
        {

        }
    }
}
