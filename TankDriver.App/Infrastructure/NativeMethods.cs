using System;
using System.Runtime.InteropServices;

namespace TankDriver.App.Infrastructure
{
    internal static class NativeMethods
    {
        private const string Kernel32 = "Kernel32";
        private const string User32 = "User32";

        private const int SW_HIDE = 0;

        [DllImport(Kernel32)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport(User32)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void HideConsoleWindow()
        {
            var handle = GetConsoleWindow();
            if (handle == IntPtr.Zero)
            {
                return;
            }

            ShowWindow(handle, SW_HIDE);
        }
    }
}
