using Data;
using Local_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramTest
{
    static class Program
    {
        private static PresetDbContext dbContext;

        public static PresetDbContext DbContext
        {
            get 
            {
                if(dbContext == null)
                {
                    dbContext = new PresetDbContext();
                }
                return dbContext; 
            }
            
        }

        private static LocalPresetDbContext localDbContext;

        public static LocalPresetDbContext LocalDbContext
        {
            get
            {
                if (localDbContext == null)
                {
                    localDbContext = new LocalPresetDbContext();
                }
                return localDbContext;
            }

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
