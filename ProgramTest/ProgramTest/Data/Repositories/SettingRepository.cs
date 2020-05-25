using Data;
using Data.Repositories;
using ProgramTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest.Data.Repositories
{
    class SettingRepository : CrudRepository<Setting>
    {
        public SettingRepository(PresetDbContext dbContext) : base(dbContext, dbContext.Settings)
        {
        
        }

        public Setting GetSettingByName(string name)
        {
            return this.GetOne(s => s.Name == name);
        }
    }
}
