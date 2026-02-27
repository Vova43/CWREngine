// by Vova43 / vova436612
namespace openGL {
    /// <summary> Класс представляющий API OpenGL </summary>
    public unsafe class GL {
        private static System.IntPtr hModule = System.IntPtr.Zero;

        /// Import functions from kernel32.dll / Импорт необходимых функций из kernel32.dll
        [System.Runtime.InteropServices.DllImport("kernel32.dll", EntryPoint = "LoadLibraryA", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern System.IntPtr LoadLibraryA(string lpLibFileName); // Use string for convenience

        [System.Runtime.InteropServices.DllImport("kernel32.dll", EntryPoint = "GetProcAddress", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern System.IntPtr GetProcAddress(System.IntPtr hModule, string lpszProcName); // Use string for convenience

        [System.Runtime.InteropServices.DllImport("kernel32.dll", EntryPoint = "FreeLibrary", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern bool FreeLibrary(System.IntPtr hModule); // Use string for convenience

        private static void sendError(string strMessage, bool sendThrow) {
            System.Console.WriteLine(strMessage);
            if (sendThrow)
                throw new System.InvalidOperationException(strMessage);
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate System.IntPtr wglGetProcAddressPROC(string lpszProcName); // Use string for convenience

        private static wglGetProcAddressPROC wglGetProcAddressADRESS = null;
        public static System.IntPtr getProcAddressLibrary(string pointerName) {
            return GetProcAddress(hModule, pointerName);
        }

        public static System.IntPtr getProcAddress(string pointerName) {
            return wglGetProcAddressADRESS(pointerName);
        }

        public static System.IntPtr getProcAddressDebug(string pointerName) {
            System.IntPtr temp = wglGetProcAddressADRESS(pointerName);
            if (temp == System.IntPtr.Zero) {
                sendError("lpszProc " + pointerName + " not found \n", false);
            }
            return temp;
        }

        private static bool isInit = false;
        /// <summary> Класс представляющий API OpenGL </summary>
        public static bool initGL() {
            if (isInit)
                return true;

            hModule = LoadLibraryA("opengl32.dll");
            if (hModule == System.IntPtr.Zero)
                return false;
            isInit = true;

            wglGetProcAddressADRESS = (wglGetProcAddressPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(getProcAddressLibrary("wglGetProcAddress"), typeof(wglGetProcAddressPROC));

            GL11.initGL();
            return true;
        }

        public static bool initGLNext() {
            // XXX
            return isInit;
        }

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public delegate void GLDEBUGPROC(
            uint source,
            uint type,
            uint id,
            uint severity,
            int length,
            char* message,
            void* userParam
        );

        public static bool deinitGLES() {
            isInit = false;
            bool result = FreeLibrary(hModule);
            if (!result)
                return false;
            hModule = System.IntPtr.Zero;
            return true;
        }

        //[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        //public delegate void GLDEBUGPROC(
        //    uint source,
        //    uint type,
        //    uint id,
        //    uint severity,
        //    int length,             // GLsizei
        //    System.IntPtr message,  // const GLchar* (передаем как IntPtr, чтобы затем преобразовать)
        //    System.IntPtr userParam // GLvoid*
        //);

        //public static void initGL2(platform.NativeWindow nativeWindow) {
        //}
    }
}
