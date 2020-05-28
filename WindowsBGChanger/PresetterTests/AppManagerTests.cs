using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsBGChanger;

namespace PresetterTests
{
    [TestClass]
    public class AppManagerTests
    {
        [TestMethod]
        public void OpenExe_PassValidFilePath_ReturnsId()
        {
            //Act
            int result = AppManager.OpenExe(@"D:\AAADeleteMe.txt");

            //Assert
            Assert.AreNotEqual(-1, result);
        }

        [TestMethod]
        public void OpenExe_PassInvalidFilePath_ReturnsMinusOne()
        {
            //Act
            int result = AppManager.OpenExe(@"D:\I Dont exist.txt");

            //Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void OpenLink_PassValidUrl_ReturnsTrue()
        {
            //Arrange
            string link = @"https://www.google.bg/?gws_rd=cr&ei=9So7UubvI4XbswacoICgAg";

            //Act
            bool result = AppManager.OpenLink(link);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OpenLink_PassUnsafeUrl_ThrowsArgumentException()
        {
            //Arrange
            string link = @"totalySafeWebsite.com";

            //Assert
            Assert.ThrowsException<ArgumentException>(() => AppManager.OpenLink(link),
                "Website address may not be safe. Ensure it starts with 'http'!");
        }

        [TestMethod]
        public void CloseBrowserByName_PassValidName_ReturnsTrue()
        {
            //Act
            bool result = AppManager.CloseBrowserByName("microsoftedge");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CloseBrowserByName_PassIncorrectName_ThrowArgException()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => AppManager.CloseBrowserByName("myBrowser"),
                "Incorrect browser name!");
        }

        [TestMethod]
        public void CloseAllBrowsers_ReturnsTrue()
        {
            //Act
            bool result = AppManager.CloseAllBrowsers();

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CloseEverythingById_PassValidId_ReturnsTrue()
        {
            //Arrange
            List<int> testIds = new List<int>();
            testIds.Add(AppManager.OpenExe(@"D:\AAADeleteMe.txt"));
            testIds.Add(AppManager.OpenExe(@"D:\AAADeleteMe.txt"));

            //Act
            bool result = AppManager.CloseEverythingById(testIds);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CloseEverythingById_PassInvalidId_ThrowsException()
        {
            //Arrange
            List<int> testIds = new List<int>();
            testIds.Add(-1);
            testIds.Add(-2);

            //Assert
            Assert.ThrowsException<ArgumentException>(() => AppManager.CloseEverythingById(testIds),
                "Invalid id!");
        }

        [TestMethod]
        public void ForceCloseEverythingById_PassValidId_ReturnsTrue()
        {
            //Arrange
            List<int> testIds = new List<int>();
            testIds.Add(AppManager.OpenExe(@"D:\AAADeleteMe.txt"));
            testIds.Add(AppManager.OpenExe(@"D:\AAADeleteMe.txt"));

            //Act
            bool result = AppManager.ForceCloseEverythingById(testIds);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ForceCloseEverythingById_PassInvalidId_ThrowsException()
        {
            //Arrange
            List<int> testIds = new List<int>();
            testIds.Add(-1);
            testIds.Add(-2);

            //Assert
            Assert.ThrowsException<ArgumentException>(() => AppManager.ForceCloseEverythingById(testIds),
                "Invalid id!");
        }

        [TestMethod]
        public void GetProcessMemoryUsage_PassValidId_ReturnGreaterThanOne()
        {
            //Arrange
            int testId = AppManager.OpenExe(@"D:\AAADeleteMe.txt");

            //Act
            double result = AppManager.GetProcessMemoryUsage(testId);

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void GetProcessMemoryUsage_PassInvalidId_ThrowArgException()
        {
            //Arrange
            int testId = -3;

            //Assert
            Assert.ThrowsException<ArgumentException>(() => AppManager.GetProcessMemoryUsage(testId),
                "Invalid id!");
        }

        [TestMethod]
        public void GetCurrentMemoryUsagePercent_ReturnsGreaterThanZero()
        {
            //Act
            double result = AppManager.GetCurrentMemoryUsagePercent();

            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void MemoryExceedsThresholdPercentage_PassPercentageToExceed_ReturnsTrue()
        {
            //Act
            bool result = AppManager.MemoryExceedsThresholdPercentage(10);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MemoryExceedsThresholdPercentage_PassPercentageToNotExceed_ReturnsFalse()
        {
            //Act
            bool result = AppManager.MemoryExceedsThresholdPercentage(101);

            //Assert
            Assert.IsFalse(result);
        }

        // Blueprint //
        #region Blueprint
        [TestMethod]

        public void TestedMethodName_Scenario_ExpectedBehaviour()
        {
            //Arrange

            //Act

            //Assert

        }
        #endregion

    }
}
