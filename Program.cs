using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize SplashScreen (creating object of SplashScreen class)
            SplashScreen splash = new SplashScreen();

            splash.Show();

            // Simulate some loading time
            Thread.Sleep(3000); // 3 seconds

            //show progress bar for 2 seconds

            for(int i = 0; i <= 100; i++)
            {
                splash.UpdateProgress(i);
                Thread.Sleep(20); // 20 milliseconds
            }


            splash.Close();


            Application.Run(new Form1());
        }
    }
}
