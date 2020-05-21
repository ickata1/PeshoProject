using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBGChanger
{
    public class ApplicationTimer
    {
        /// <summary>
        /// Finds a process by name and assigns an event handler to its Exited event.
        /// </summary>
        /// <param name="processName"></param>
        /// <returns></returns>
        public static bool WatchProcess(string processName)
        {
            try
            {
                Process process = Process.GetProcessesByName(processName)[0];
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(ProcessExited);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Finds a process by its id and assigns an event handler to its Exited event.
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        public static bool WatchProcess(int processId)
        {
            try
            {
                Process process = Process.GetProcessById(processId);
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(ProcessExited);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Assings an event handler to the Exited event.
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public static bool WatchProcess(Process process)
        {
            try
            {
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(ProcessExited);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void ProcessExited(object sender, EventArgs e)
        {
            Process terminatedProcess = (Process)sender;
            //TO DO: Send to DB
            //Console.WriteLine(terminatedProcess.StartTime.ToUniversalTime());
            //Console.WriteLine(terminatedProcess.ExitTime.ToUniversalTime());

        }
    }
}
