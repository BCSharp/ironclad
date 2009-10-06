using System;
using System.Runtime.InteropServices;

namespace Ironclad
{
    public class Unmanaged
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string s);
        
        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr l);
        
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr l, string s);
        
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string s);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();
        

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, int bInitialOwner, IntPtr lpName);
        
        [DllImport("kernel32.dll")]
        public static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);
        
        [DllImport("kernel32.dll")]
        public static extern int ReleaseMutex(IntPtr hMutex);
        
        [DllImport("kernel32.dll")]
        public static extern int CloseHandle(IntPtr hObject);
        
        [DllImport("kernel32.dll")]
        public static extern void DebugBreak();
        
        
        [DllImport("msvcr90.dll")]
        public static extern IntPtr _fdopen(int fd, string mode);
        
        [DllImport("msvcr90.dll")]
        public static extern int _open_osfhandle(IntPtr f, int flags);
        
        [DllImport("msvcr90.dll")]
        public static extern int fread(IntPtr buf, int size, int count, IntPtr file);
        
        [DllImport("msvcr90.dll")]
        public static extern int fwrite(IntPtr buf, int size, int count, IntPtr file);

        [DllImport("msvcr90.dll")]
        public static extern int fflush(IntPtr file);
        
        [DllImport("msvcr90.dll")]
        public static extern int fclose(IntPtr FILE);
        
        [DllImport("msvcr90.dll")]
        public static extern IntPtr memcpy(IntPtr dst, IntPtr src, uint bytes);
    }
}
