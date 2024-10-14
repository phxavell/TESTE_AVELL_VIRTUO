using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ROBOTESTE
{
    internal class Helpers
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void BringWindowToFront(string windowTitle)
        {
            Process[] processes = Process.GetProcessesByName(windowTitle);
            if (processes.Length > 0)
            {
                IntPtr handle = processes[0].MainWindowHandle;
                SetForegroundWindow(handle);
                Console.WriteLine($"{windowTitle} em execução.");
            }
            else
            {
                Console.WriteLine($"{windowTitle} não está em execução.");
            }
        }
    }
}