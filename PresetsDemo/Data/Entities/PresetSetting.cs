using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class PresetSetting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }     //Optional: make it set a default value if left empty
        public string PresetSettingType { get; set; } //Background change or Open file,etc.
        public string Value { get; set; }
        public int PresetId { get; set; }
        public virtual Preset Presets { get; set; }
        //optional
        public bool isActive { get; set; }
    }
}
