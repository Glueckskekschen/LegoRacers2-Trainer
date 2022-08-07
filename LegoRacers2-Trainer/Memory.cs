using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; //DLL Import
using System.Diagnostics; //Process
using System.Threading; //Sleep

namespace LegoRacers2_Trainer
{
    internal class Memory
    {        
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);


        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);


        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        private const int PROCESS_WM_READ = 0x0010;
        private const int PROCESS_VM_WRITE = 0x0020;
        private const int PROCESS_ALL_ACCESS = 0x1F0FFF;
        private String ProcessesName;
        private Process MyProcess;
        private IntPtr processHandle;

        public Memory(String ProcessesName)
        {
            this.ProcessesName = ProcessesName;           

        }

        public void AccessProcessInWhile()
        {
            do
            {
                try
                {
                    MyProcess = Process.GetProcessesByName(ProcessesName).First();
                    processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, MyProcess.Id);
                }
                catch (Exception ex)
                {
                    //Wait for the game..
                    Thread.Sleep(300);
                }
            } while (MyProcess == null);
        }
         
        public bool AccessProcessOnce()
        {
            try
            {
                MyProcess = Process.GetProcessesByName(ProcessesName).First();
                processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, MyProcess.Id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IntPtr GetProcessBase()
        {
            return MyProcess.MainModule.BaseAddress;
        }

        public bool ProcessStillRunning()
        {
            try
            {
                MyProcess = Process.GetProcessesByName(ProcessesName).First();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public int ReadInt(int offset)
        {
            byte[] buffer = new byte[4];
            int bytesRead = 0;
            int Value = 0;
            ReadProcessMemory((int)processHandle, offset, buffer, buffer.Length, ref bytesRead);

            Value = BitConverter.ToInt32(buffer, 0);
            return Value;
        }

        public void WriteInt(int offset, int Value)
        {
            byte[] buffer = new byte[4];
            buffer = BitConverter.GetBytes(Value);
            int bytesWritten = 0;
            WriteProcessMemory((int)processHandle, offset, buffer, buffer.Length, ref bytesWritten);
        }

    }
}
