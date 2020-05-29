using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsBGChanger;

namespace PresetterTests
{
    [TestClass]
    public class WindowsWallpaperTests
    {
        [TestMethod]
        public void GetCurrentStyle_ReturnsStringWithStyle()
        {
            //Act
            string result = WindowsWallpaper.GetCurrentStyle();

            //Assert
            Assert.IsTrue(result == "Fill");
        }

        [TestMethod]
        public void SetWallpaper_PassValidFilePath_ChangesWallpaper()
        {
            //Arrange
            MethodInfo getWallpaperPathMethod = typeof(WindowsWallpaper)
                .GetMethod("GetWallpaperPath",
                BindingFlags.NonPublic | BindingFlags.Static);

            getWallpaperPathMethod.Invoke(null, null);
            string filePathBefore = WindowsWallpaper.WallpaperPath;

            //Act
            WindowsWallpaper.SetWallpaper(@"D:\Image.jpg");

            getWallpaperPathMethod.Invoke(null, null);
            string filePathAfter = WindowsWallpaper.WallpaperPath;

            //Assert
            Assert.AreNotEqual(filePathBefore, filePathAfter);
        }

        [TestMethod]
        public void SetWallpaper_PassNonExistingFile_ThrowsArgException()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(
                () => WindowsWallpaper.SetWallpaper(@"D:\Does not exist.jpg"),
                "No such file exists!");
        }

        [TestMethod]
        public void SetWallpaper_PassFileWithUnsuitableExtension_ThrowsArgException()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(
                () => WindowsWallpaper.SetWallpaper(@"D:\AAADeleteMe.txt"),
                "Invalid file format!");
        }


    }
}
