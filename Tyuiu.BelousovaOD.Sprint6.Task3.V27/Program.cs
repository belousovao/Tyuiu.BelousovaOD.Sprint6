using Tyuiu.BelousovaOD.Sprint6.Task3.V27.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task3.V27
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}