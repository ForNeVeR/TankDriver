using System;
using NLog;
using TankDriver.App.Infrastructure;

namespace TankDriver.App
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT
                && (args.Length == 0 || args[0] != "--console"))
            {
                NativeMethods.HideConsoleWindow();
            }

            Logger.Info("Game started");
            using (var game = new Game())
            {
                game.Run();
            }
            Logger.Info("Exiting game");
        }
    }
}
