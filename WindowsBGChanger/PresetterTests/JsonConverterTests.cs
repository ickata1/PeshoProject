using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramTest;

namespace PresetterTests
{
    [TestClass]
    public class JsonConverterTests
    {
        [TestMethod]
        public void ConvertFromJson_PassInvalidFilepath_ThrowsArugmentException()
        {
            //Arrange
            string filepath = @"D:\Expot.json";

            //Assert
            Assert.ThrowsException<ArgumentException>(() => JsonConverter.ConvertFromJson(filepath),"Invalid filepath!");
        }

        [TestMethod]
        public void ConvertFromJson_PassInvalidJsonFile_ThrowsArgumentException()
        {
            //Arange
            string filepath = @"D:\InvalidExport.json";

            //Assert
            Assert.ThrowsException<ArgumentException>(() => JsonConverter.ConvertFromJson(filepath), "Invalid data!");
        }

        [TestMethod]
        public void ConvertFromJson_PassInvalidJsonFile2_ThrowsArgumentException()
        {
            //Arange
            string filepath = @"D:\InvalidExport2.json";

            //Assert
            Assert.ThrowsException<ArgumentException>(() => JsonConverter.ConvertFromJson(filepath), "Invalid data!");
        }
    }
}
