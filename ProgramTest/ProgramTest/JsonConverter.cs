using Data.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace ProgramTest
{
    public class JsonConverter
    {
        public static string ConvertToJson(Preset preset)
        {
            string output = "";

            JavaScriptSerializer jss = new JavaScriptSerializer();

            output += "[";
            output += "\"Id\":" + jss.Serialize(preset.Id);
            output += ",\"Name\":" + jss.Serialize(preset.Name);
            output += ",\"Description\":" + jss.Serialize(preset.Description);
            List<PresetSetting> presetSettings = preset.PresetSettings.ToList();
            output += ",\"PresetSettings\":";
            foreach (PresetSetting presetSetting in presetSettings)
            {
                output += "{";
                output += "\"Id\":" + jss.Serialize(presetSetting.Id);
                output += ",\"Name\":" + jss.Serialize(presetSetting.Name);
                output += ",\"PresetSettingType\":" + jss.Serialize(presetSetting.PresetSettingType);
                output += ",\"Value\":" + jss.Serialize(presetSetting.Value);
                output += ",\"PresetId\":" + jss.Serialize(presetSetting.PresetId);
                output += ",\"isActive\":" + jss.Serialize(presetSetting.isActive);
                output += "}\"";
            }
            output += ",\"isActive\":" + jss.Serialize(preset.isActive);
            output += "]";
            output += "\n";
            return output;
        }


        public static Preset ConvertFromJson(string filePath)
        {
            PresetRepository presetRepository = new PresetRepository(Program.DbContext);

            using (StreamReader r = new StreamReader(filePath))
            {
                #region Gets Json file and spits into PresetInfo and PresetSettingsInfo
                string json = r.ReadToEnd();
                char currentChar = new char();
                int index = 0;
                string presetInfo = "";
                string presetSettingsInfo = "";
                while (currentChar != '{')
                {
                    currentChar = json[index];
                    presetInfo += json[index]; //Export the Preset Info from Json
                    index++;
                }
                while (currentChar != ']')
                {
                    currentChar = json[index];
                    presetSettingsInfo += json[index];  //Gets the PresetSettingInfo form Json
                    index++;
                }
                #endregion

                #region Creates Preset from the PresetInfo
                List<string> presetCollums = presetInfo.Split(',').ToList();
                string nameInfo = presetCollums[1];
                string descInfo = presetCollums[2];
                nameInfo = nameInfo.Remove(0, 8);
                nameInfo = nameInfo.Remove(nameInfo.Length - 1);
                descInfo = descInfo.Remove(0, 15);
                descInfo = descInfo.Remove(descInfo.Length - 1);
                string presetName = nameInfo;
                string presetDesc = descInfo;
                Preset preset = new Preset();
                preset.Name = presetName;
                preset.Description = presetDesc;
                int createdPresetId = preset.Id;
                presetRepository.Add(preset);
                #endregion

                #region Creates Preset Settings from the PresetSettingsInfo
                presetSettingsInfo = presetSettingsInfo.Remove(presetSettingsInfo.Length - 18, 18);
                List<string> presetSettingsInfoSplit = presetSettingsInfo.Split('{').ToList();
                foreach (string presetSettingInfo in presetSettingsInfoSplit)
                {
                    List<string> psInfo = presetSettingInfo.Split(',').ToList();
                    string psNameInfo = psInfo[1];
                    string psTypeInfo = psInfo[2];
                    string psValueInfo = psInfo[3];
                    psNameInfo = psNameInfo.Remove(0, 8);
                    psNameInfo = psNameInfo.Remove(psNameInfo.Length - 1);
                    psTypeInfo = psTypeInfo.Remove(0, 21);
                    psTypeInfo = psTypeInfo.Remove(psTypeInfo.Length - 1);
                    psValueInfo = psValueInfo.Remove(0, 9);
                    psValueInfo = psValueInfo.Remove(psValueInfo.Length - 1);
                    string presetSettingName = psNameInfo;
                    string presetSettingType = psTypeInfo;
                    string presetSettingValue = psValueInfo;
                    PresetSettingRepository presetSettingRepository = new PresetSettingRepository(Program.DbContext);
                    PresetSetting presetSetting = new PresetSetting();
                    presetSetting.Name = presetSettingName;
                    presetSetting.PresetSettingType = presetSettingType;
                    presetSetting.Value = presetSettingValue;
                    presetSetting.Preset = preset;
                    presetSetting.PresetId = createdPresetId;
                    presetSettingRepository.Add(presetSetting);
                }
                #endregion

                return preset;
            }
        }
    }
}
