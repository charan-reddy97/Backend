using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pinvoke
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int MessageBox(IntPtr chaaran, string lptext, string lpcaption, uint utype);
        [DllImport("kernel32.dll")]
         static extern uint GetCurrentProcessId();
        [DllImport("kernel32.dll", SetLastError = true)]

        internal static extern void GetSystemInfo(ref SYSTEM_INFO Info);
        [StructLayout(LayoutKind.Sequential)]
        internal struct SYSTEM_INFO
        {
            internal ushort wProcessorArchitecture;
            internal ushort wReserved;
            internal uint dwPageSize;
            internal IntPtr lpMinimumApplicationAddress;
            internal IntPtr lpMaximumApplicationAddress;
            internal IntPtr dwActiveProcessorMask;
            internal uint dwNumberOfProcessors;
            internal uint dwProcessorType;
            internal uint dwAllocationGranularity;
            internal ushort wProcessorLevel;
            internal ushort wProcessorRevision;
        }

        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hi Charan", "Attention users", 0);
            uint processId = GetCurrentProcessId();
            Console.WriteLine(processId);
        }
    }
}
