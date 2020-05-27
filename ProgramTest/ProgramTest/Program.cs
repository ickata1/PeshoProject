using Data;
using System;
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
                if (dbContext == null)
                {
                    dbContext = new PresetDbContext();
                }
                return dbContext;
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
