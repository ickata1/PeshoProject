﻿using Data;
using Data.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;


namespace ExtensionMethods
{
    public static class IQueryableExtension
    {
        public static DataTable ToDataTable<T>(this IQueryable<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}

namespace ProgramTest
{
    using ExtensionMethods;
    using System.IO;
    using System.Web.Script.Serialization;

    static class Program
    {
        private static PresetDbContext dbContext;

        public static PresetDbContext DbContext
        {
            get 
            {
                if(dbContext == null)
                {
                    dbContext = new PresetDbContext();
                }
                return dbContext; 
            }
            
        }

        /*public static string ConvertToJson(IQueryable<Preset> presets) 
        {
            DataTable table = new DataTable();
            table = presets.ToDataTable();
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }

        public static string ConvertToJson(IQueryable<PresetSetting> presets)
        {
            DataTable table = new DataTable();
            table = presets.ToDataTable();
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }*/

        public static string ConvertToJson(Preset preset)
        {
            string output = "";

            JavaScriptSerializer jss = new JavaScriptSerializer();


            output += "[";
            output += "\"Id\":"+ jss.Serialize(preset.Id);
            output += ",\"Name\":" + jss.Serialize(preset.Name);
            output += ",\"Description\":" + jss.Serialize(preset.Description);
            List<PresetSetting>presetSettings = preset.PresetSettings.ToList();
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
        

        public static void ConvertFromJson(string filePath)
        {
            PresetRepository presetRepository = new PresetRepository(DbContext);
            
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
                nameInfo = nameInfo.Remove(nameInfo.Length-1);
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
                    psValueInfo = psValueInfo.Remove(0, 10);
                    psValueInfo = psValueInfo.Remove(psValueInfo.Length - 1);
                    string presetSettingName = psNameInfo;
                    string presetSettingType = psTypeInfo;
                    string presetSettingValue = psValueInfo;
                    PresetSettingRepository presetSettingRepository = new PresetSettingRepository(DbContext);
                    PresetSetting presetSetting = new PresetSetting();
                    presetSetting.Name = presetSettingName;
                    presetSetting.PresetSettingType = presetSettingType;
                    presetSetting.Value = presetSettingValue;
                    presetSetting.Preset = preset;
                    presetSetting.PresetId = createdPresetId;
                    presetSettingRepository.Add(presetSetting);
                }    
                #endregion
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
