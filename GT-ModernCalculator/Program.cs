namespace GT_ModernCalculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { /*
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StandardCalculator());
            //Application.Run(new ScienceCalculator());
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StandardCalculator standardCalculatorForm = new StandardCalculator();
            ScienceCalculator scienceCalculatorForm = new ScienceCalculator();

            // Show the StandardCalculator form initially
            standardCalculatorForm.Show();

            // Start the application loop
            Application.Run();

            
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}