using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsBGChanger
{
    public static class FileAndUrlPathManager
    {
        #region USELESS

        #region Properties
        public static List<string> FilePaths { get; set; } = new List<string>();

        public static List<string> Urls { get; set; } = new List<string>();
        #endregion

        public static void AddFilePath(string filePath)
        {
            FilePaths.Add(filePath);
        }

        public static void AddUrl(string url)
        {
            Urls.Add(url);
        }

        private static string ConvertFromStringToJSON(List<string> paths)
        {
            string json = JsonConvert.SerializeObject(FilePaths);

            return json;
        }

        //TODO:
        public static bool UploadSavedPathsToDatabase()
        {
            string filesJson = "";
            string urlsJson = "";

            if (FilePaths.Count > 0)
            {
                filesJson = ConvertFromStringToJSON(FilePaths);
            }

            if (Urls.Count > 0)
            {
                urlsJson = ConvertFromStringToJSON(Urls);
            }

            //Uploads JSONs to Database
            if (filesJson != "" && urlsJson != "")
            {
                //TODO: Upload To Database
                return true;
            }

            return false;
        }
        #endregion
    }
}
