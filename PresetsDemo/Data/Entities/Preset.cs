using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Preset
    {
        public Preset()
        {
            this.PresetSettings = new HashSet<PresetSetting>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<PresetSetting> PresetSettings { get; set; } = new HashSet<PresetSetting>();
        //optional
        public bool isActive { get; set; }
    }
}
