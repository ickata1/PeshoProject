using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBGChanger
{
    public static class FileBrowserDialogue
    {
        private static string filePath;
        private static string[] filePaths;
        private static string friendlyFilePath;

        //WORKS
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
                openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
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

        //WORKS
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
                openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
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

        //USELESS
        /// <summary>
        /// Opens the windows explorer file browser dialogue
        /// </summary>
        /// <returns>
        /// Returns the file name, without the path
        /// </returns>
        public static string GetFriendlyFileName()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";    //Remove the ALL filter
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    friendlyFilePath = openFileDialog.SafeFileName;
                }
            }

            //Removes the extension (.exe, .png, etc.)
            return friendlyFilePath.Substring(0, friendlyFilePath.IndexOf("."));
        }

    }
}
