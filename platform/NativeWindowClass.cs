// by Vova43 / vova436612
namespace platform {
    /// <summary> Класс представляющий концепцию чертежей для стилей будущих окон, имя полей где можно применить название данных чертежей называется className </summary>
    public class NativeWindowClass {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct WNDCLASS {
            public uint style;
            public System.IntPtr lpfnWndProc;
            public int cbClsExtra;
            public int cbWndExtra;
            public System.IntPtr hInstance;
            public System.IntPtr hIcon;
            public System.IntPtr hCursor;
            public System.IntPtr hbrBackground;
            public string lpszMenuName;
            public string lpszClassName;
        }

        //public string className         = null;
        public WNDCLASS windowClass     = default(WNDCLASS);
        private System.IntPtr hInstance = System.IntPtr.Zero;

        public const string defaultClassName = "STATIC";

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern ushort RegisterClass(ref WNDCLASS lpWndClass);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool UnregisterClass(string lpClassName, System.IntPtr hInstance);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern System.IntPtr GetModuleHandle(string lpModuleName);

        public void create(WNDCLASS wndClass) {
            windowClass = wndClass;
            RegisterClass(ref windowClass);
        }

        public void create(string name) {
            //className = name;
            hInstance = GetModuleHandle(null);
            windowClass = new WNDCLASS {
                lpfnWndProc = System.IntPtr.Zero,
                hInstance = hInstance,
                lpszClassName = name
            };
            RegisterClass(ref windowClass);
        }

        public void destroy() {
            UnregisterClass(windowClass.lpszClassName, hInstance);
        }
    }
}
