using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices; // DLL Import

namespace appWindowsLocker
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            NativeMethods.LockWorkStation();
        }
    }
    static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
    }
}
