using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class PresetRepository : CrudRepository<Preset>
    {
        public PresetRepository(PresetDbContext dbContext) : base(dbContext,dbContext.Presets)
        {

        }

        
    }
}
