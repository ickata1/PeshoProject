using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace WindowsBGChanger
{
    
    public class WindowsWallpaper
    {
        #region Dclarations For P/Invoke
        /// <summary>
        /// Allows the manipulation of System Params
        /// </summary>
        /// <param name="uAction"> Action code to set the desktop wallpaper </param>
        /// <param name="uiParam"> Ignore </param>
        /// <param name="pvParam"> File path of the wanted background, example: @"D:\Image.jpg" </param>
        /// <param name="fuWinIni"> Determines whether or not to save the changes after restart / reboot.
        /// Can be 0, SPIF_UPDATEINIFILE, SPIF_SENDCHANGE (Check SystemParametersInfo documentation for more info) </param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(uint uAction, int uiParam, string pvParam, uint fuWinIni);
        #endregion

        private static RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

        #region Properties
        public static string DefaultStyle { get; private set; }

        public static string WallpaperPath { get; private set; }

        public static string CurrentWallpaperStyle { get; private set; }
        #endregion

        #region Set/Change Style Of Wallpaper
        public static void SetStyle(int style, int tile)
        {

            string styleArgs = ConvertStyleFromIntToString(style, tile);

            if (WallpaperPath == "" || WallpaperPath == null)
            {
                GetWallpaperPath();
            }

            SetWallpaper(WallpaperPath, styleArgs);
            
        }

        public static void SetStyle(List<int> values)
        {

            string styleArgs = ConvertStyleFromIntToString(values[0], values[1]);

            if (WallpaperPath == "" || WallpaperPath == null)
            {
                GetWallpaperPath();
            }

            SetWallpaper(WallpaperPath, styleArgs);

        }
        #endregion

        //Get Current Wallpaper Path
        private static void GetWallpaperPath()
        {
            WallpaperPath = regKey.GetValue(@"WallPaper").ToString();
        }

        //Get Current Wallpaper Style
        public static string GetCurrentStyle()
        {
            string wpStyle = regKey.GetValue(@"WallpaperStyle").ToString();
            string wpTile = regKey.GetValue(@"TileWallpaper").ToString();

            CurrentWallpaperStyle = ConvertStyleFromIntToString(int.Parse(wpStyle), int.Parse(wpTile));

            return CurrentWallpaperStyle;
        }
        
        //Sets the windows desktop wallpaper/background
        public static void SetWallpaper(string fullWallpaperPath, string style = null)
        {
            //This has to be before updating the ini file in SystemParametersInfo() so that it updates on the current run of the program
            if (style != null)
            {
                switch (style)
                {
                    case "Center":
                        regKey.SetValue(@"WallpaperStyle", 0.ToString());
                        regKey.SetValue(@"TileWallPaper", 0.ToString());
                        CurrentWallpaperStyle = "Center";
                        break;

                    case "Fill":
                        regKey.SetValue(@"WallpaperStyle", 10.ToString());
                        regKey.SetValue(@"TileWallPaper", 0.ToString());
                        CurrentWallpaperStyle = "Fill";
                        break;

                    case "Fit":
                        regKey.SetValue(@"WallpaperStyle", 6.ToString());
                        regKey.SetValue(@"TileWallPaper", 0.ToString());
                        CurrentWallpaperStyle = "Fit";
                        break;

                    case "Span":
                        regKey.SetValue(@"WallpaperStyle", 22.ToString());
                        regKey.SetValue(@"TileWallPaper", 0.ToString());
                        CurrentWallpaperStyle = "Span";
                        break;

                    case "Stretch":
                        regKey.SetValue(@"WallpaperStyle", 2.ToString());
                        regKey.SetValue(@"TileWallPaper", 0.ToString());
                        CurrentWallpaperStyle = "Stretch";
                        break;

                    case "Tile":
                        regKey.SetValue(@"WallpaperStyle", 0.ToString());
                        regKey.SetValue(@"TileWallPaper", 1.ToString());
                        CurrentWallpaperStyle = "Tile";
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            

            uint SPI_SETDESKWALLPAPER = 20;
            uint SPIF_UPDATEINIFILE = 0x1;
            uint SPIF_SENDWININICHANGE = 0x2;

            string fileExtension = fullWallpaperPath.Substring(fullWallpaperPath.IndexOf('.'));
            List<string> acceptableFileExtensions = new List<string>() { ".png", ".jpg", ".jpeg", ".gif", ".bmp" };

            //Checks if the file exists and is in suitable format
            if (!System.IO.File.Exists(fullWallpaperPath))
            {
                throw new ArgumentException("No such file exists!");
            }
            else if (!acceptableFileExtensions.Contains(fileExtension))
            {
                throw new ArgumentException("Invalid file format!");
            }

            WallpaperPath = fullWallpaperPath;

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, fullWallpaperPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);   //Put 0 instead of SPIF_UPDATEINIFILE to not save the changes after a restart/reboot

            //SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, fullWallpaperPath, SPIF_UPDATEINIFILE);   //Put 0 instead of SPIF_UPDATEINIFILE to not save the changes after a restart/reboot

        }

        private static string ConvertStyleFromIntToString(int style, int tile)
        {

            if (style == 0 && tile == 0)
            {
                return "Center";
            }
            else if (style == 10 && tile == 0)
            {
                return "Fill";
            }
            else if (style == 6 && tile == 0)
            {
                return "Fit";
            }
            else if (style == 22 && tile == 0)
            {
                return "Span";
            }
            else if (style == 2 && tile == 0)
            {
                return "Stretch";
            }
            else if (style == 0 && tile == 1)
            {
                return "Tile";
            }
            else
            {
                throw new ArgumentException("Invalid Style Argument(s)");
            }

        }

        #region Wallpaper Styles
        //WALLPAPER STYLES:
        //Center	0   AND TileWallpaper = 0
        //Fill	    10
        //Fit	    6
        //Span	    22
        //Stretch	2
        //Tile	    0   AND TileWallpaper = 1
        #endregion
        

    }
}
