using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace WindowsBGChanger
{
    public static class AppManager
    {
        public static List<int> processIds = new List<int>();
        public static List<string> processNames = new List<string>();
        
        /// <summary>
        /// Opens a file/program in the specified directory in filePath 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>
        /// Returns the opened process id
        /// </returns>
        public static int OpenExe(string filePath)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.FileName = filePath;
                    myProcess.Start();

                    //Adds process' id to a list to kill *SPECIFIC* process instanses
                    return myProcess.Id;
                }
            }
            catch (Exception)
            {
                return -1;
            }

        }

        /// <summary>
        /// Opens a web link through the machine's default browser. Only links starting with http may be opened due to safety reasons.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// 
        /// </returns>
        public static void OpenLink(string url)
        {
            //Checks if the connection is secure, can be removed, though not recommended.
            if (url.StartsWith("http"))
            {
                try
                {
                    Process.Start(url);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                throw new ArgumentException("Website address may not be safe. Ensure it starts with 'http'!");
            }
        }

        // =========== Closing Programs/Files =================== //

        // Process.Kill() vs CloseMainWindow()
        // Process.Kill() = FORCES the process to close
        // Process.CloseMainWindow() = Will send a termination REQUEST, safer to use than .Kill()


        //WORKS, closes only one browser instance (last viewed)
        public static void CloseBrowserByName(string browserName)
        {
            browserName = browserName.ToLower();

            if (browserName == "internet explorer" || browserName == "explorer")
            {
                browserName = "iexplorer";
            }
            else if (browserName == "microsoftedge")
            {
                browserName = "MicrosoftEdge";
            }
            else if (browserName != "chrome" && browserName != "firefox" && browserName != "")
            {
                throw new ArgumentException("Incorrect browser name!");
            }

            try
            {
                Process[] processesToKill = Process.GetProcessesByName(browserName);

                foreach (var process in processesToKill)
                {
                    process.CloseMainWindow();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void CloseAllBrowsers()
        {
            List<string> browserNames = new List<string> { "chrome", "MicrosoftEdge", "firefox" };

            try
            {
                foreach (var browserName in browserNames)
                {
                    CloseBrowserByName(browserName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void CloseEverythingById(List<int> processIdsToClose)
        {
            try
            {
                List<Process> processesToKill = new List<Process>();

                foreach (var processId in processIdsToClose)
                {
                    processesToKill.Add(Process.GetProcessById(processId));
                }

                //Closes all open processes
                foreach (var process in processesToKill)
                {
                    process.CloseMainWindow();
                }
            }
            catch (Exception)
            {

                
            }
           

        }

        public static void ForceCloseEverythingById(List<int> processIdsToClose)
        {
            try
            {
                List<Process> processesToKill = new List<Process>();

                foreach (var processId in processIdsToClose)
                {
                    processesToKill.Add(Process.GetProcessById(processId));
                }

                //Closes all open processes
                foreach (var process in processesToKill)
                {
                    process.Kill();
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        // =========== Memory Usage ============= //

        //Returns the amount of memory a process is using in bytes
        public static long GetProcessMemoryUsage(int processId)
        {
            try
            {
                Process process = Process.GetProcessById(processId);
                return process.PrivateMemorySize64;
            }
            catch (ArgumentException)
            {
                //No such process is running
                return -1;
            }
        }

        //Returns the available system memory in percentage
        public static double GetCurrentMemoryUsagePercent()
        {
            double totalMemory = new ComputerInfo().TotalPhysicalMemory;
            double availableMemory = new ComputerInfo().AvailablePhysicalMemory;
            double usedMemory = totalMemory - availableMemory;
            double memoryUsagePercent = usedMemory / totalMemory * 100;      //Calculates the percentage of memory used

            return Math.Round(memoryUsagePercent, 2);
        }

        /// <summary>
        /// Checks whether the used memory amount exceeds a given threshold percentage
        /// </summary>
        /// <param name="thresholdPercentage">Maximum percentage of used memory</param>
        /// <returns></returns>
        public static bool MemoryExceedsThresholdPercentage(double thresholdPercentage)
        {
            double usedMemoryPercentage = GetCurrentMemoryUsagePercent();

            if (usedMemoryPercentage > thresholdPercentage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Ideas
        //https://stackoverflow.com/questions/3345363/kill-some-processes-by-exe-file-name

        //IDEA #1: using handles https://stackoverflow.com/questions/5791927/c-sharp-process-name-but-not-like-chrome-exe-but-like-chrome
        //research WM_CLOSE (win32.dll)

        //IDEA #2: Get the top active window, close it, repeat until no more windows are open, can add a param

        //IDEA #3 (Implemented): Get processId when opening the program and save it so you can close it later with said processId

        //IDEA #4: Research handles, handle.exe for a quicker albeit worse solution 

        //IDEA #5 (Useless): Try making the opening code async, if possible/sensible

        //IDEA #6 (Implemented):  Use .Kill() for a "force close" button/method to forcefully close every opened by the program app.

        //IDEA #7 (Useless): Make a list of Office apps and check if the process is one of them. If so, use a method with .Kill() instead of .CloseMainWindow()

        //IDEA #8 (Implemented): Make a method to close all browsers

        //IDEA #9: Find default browser, using unmanaged code: https://stackoverflow.com/questions/13621467/how-to-find-default-web-browser-using-c, using Microsoft.Win32;

        //IDEA #10 (risky): Add a mothod to KILL all browsers
        #endregion
    }
}
