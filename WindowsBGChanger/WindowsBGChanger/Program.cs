using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AudioSwitcher.AudioApi.CoreAudio;

namespace WindowsBGChanger
{
    class Program
    {
        //[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        //private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        [STAThread]
        static void Main(string[] args)
        {

            //MessageBox(IntPtr.Zero, "Command-line message box", "Attention!", 0);
            //string wp = @"D:\Image.jpg";
            //WindowsWallpaper.SetWallpaper(wp, "Center");


            //string imagePath = FileBrowserDialogue.CallFileBrowserDialogue();
            //WindowsWallpaper.SetWallpaper(imagePath, "Stretch");
            ////Console.WriteLine(WindowsWallpaper.GetWallpaperPath());


            //string fileName = FileBrowserDialogue.CallFileBrowserDialogue();
            //string pageUrl = @"https://www.youtube.com/watch?v=vabV6aPw1B4&list=LLSGr8e4Sa1Es79Fw3xF-B9A&index=7&t=0s";
            //AppManager.OpenExe(fileName);
            //AppManager.OpenLink(pageUrl);
            //FileAndUrlPathManager.AddFilePath(fileName);


            //List<string> urls = new List<string>();
            //string input;

            //do
            //{
            //    input = Console.ReadLine();
            //    urls.Add(input);
            //}
            //while (input.ToUpper() != "END");

            //foreach (var url in urls)
            //{
            //    AppManager.OpenLink(url);
            //}


            //string fileName = FileBrowserDialogue.GetFriendlyFileNameFromeDialogue();
            //Console.WriteLine(fileName);
            //AppManager.CloseTest("");

            //Closing tests
            //string fileName = FileBrowserDialogue.CallFileBrowserDialogue();
            //AppManager.OpenExe(fileName);
            //AppManager.processIds.ForEach(item => Console.WriteLine(item));
            //string a;
            //a = Console.ReadLine();
            //AppManager.CloseTest(AppManager.processIds.First());
            //AppManager.CloseProcessById(AppManager.processIds.First());

            //AppManager.CloseProcessByName("notepad");
            //AppManager.ShowAllRunningProcesses();



        }
    }
}
