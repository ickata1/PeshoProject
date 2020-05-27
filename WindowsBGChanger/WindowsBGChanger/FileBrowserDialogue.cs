using System;
using System.Windows.Forms;

namespace WindowsBGChanger
{
    public static class FileBrowserDialogue
    {
        private static string folderPath;
        private static string filePath;
        private static string[] filePaths;

        /// <summary>
        /// Opens the windows explorer file browser dialogue and gets the selected file's path
        /// </summary>
        /// <returns>
        /// Returns the filepath of the selected file.
        /// </returns>
        public static string GetFullFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Applications (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            return filePath;
        }

        /// <summary>
        /// Opens the windows explorer file browser dialogue and gets all the selected files' paths
        /// </summary>
        /// <returns>
        /// Returns an array of all selected files' paths
        /// </returns>
        public static string[] GetFullFilePathForMultipleFiles()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Applications (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePaths = openFileDialog.FileNames;
                }
            }

            return filePaths;
        }

        /// <summary>
        /// Opens the windows explorer file browser dialogue and returns the selected folder path
        /// </summary>
        /// <returns></returns>
        public static string GetFolderPath()
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowser.ShowNewFolderButton = true;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of the folder
                    folderPath = folderBrowser.SelectedPath;
                }
            }

            return folderPath;
        }
    }


}
