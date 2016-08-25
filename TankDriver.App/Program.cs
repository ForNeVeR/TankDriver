using System;
using NLog;

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
        static void Main()
        {
            Logger.Info("Game started");
            using (var game = new Game())
            {
                game.Run();
            }
            Logger.Info("Exiting game");
        }
    }
}
