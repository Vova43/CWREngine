// by Vova43 / vova436612
namespace platform {
    /// <summary> Класс представляющий окно и механизмы управления им, является низкоуровневой реализацией </summary>
    public unsafe class NativeWindow {
        public void* hInstance;
        public void* hWnd;
        public void* hDC;
        public void* sEglDisplay;
        public void* sEglSurface;
        public void* sEglConfig;
        //public void* hRC;
        public bool isCreated        = false;
        public bool isCloseRequested = false;
        private WndProcDelegate wndProcDelegate = null;

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MSG {
            public void* hWnd;
            public uint message;
            public uint wParam;
            public long lParam;
            public uint time;
            public int pt_x;
            public int pt_y;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct RECT {
            public int x;
            public int y;
            public int width;
            public int height;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* CreateWindowEx(
            uint dwExStyle,
            string lpClassName,
            string lpWindowName,
            uint dwStyle,
            int x,
            int y,
            int nWidth,
            int nHeight,
            void* hWndParent,
            void* hMenu,
            void* hInstance,
            void* lpParam
        );

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool DestroyWindow(void* hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool ShowWindow(void* hWnd, int nCmdShow);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool UpdateWindow(void* hWnd);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern void* GetModuleHandle(string lpModuleName);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern uint DefWindowProc(void* hWnd, uint Msg, uint wParam, uint lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* GetMessage(ref MSG lpMsg, void* hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool TranslateMessage(ref MSG lpMsg);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool PeekMessage(ref MSG lpMsg, void* hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* DispatchMessage(ref MSG lpMsg);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void PostQuitMessage(int nExitCode);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool GetWindowRect(void* hWnd, out RECT lpRect);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool GetClientRect(void* hWnd, out RECT lpRect);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern int GetSystemMetrics(int nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* GetDC(void* hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern int ReleaseDC(void* hWnd, void* hDC);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* SetWindowLongA(void* hWnd, int nIndex, void* dwNewLong);

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "SwapBuffers")]
        private static extern bool SwapBuffers(void* hDC);

        private delegate uint WndProcDelegate(void* hWnd, uint Msg, uint wParam, uint lParam);
        private uint WndProc(void* hWnd, uint Msg, uint wParam, uint lParam) {
            switch (Msg) {
                case 0x0002: // WM_DESTROY
                    isCreated        = false;
                    isCloseRequested = true;
                    return 0;
                case 0x0012: // WM_QUIT
                    isCreated        = false;
                    isCloseRequested = true;
                    return 0;
                case 0x0112: //WM_SYSCOMMAND
                    switch ((int)((long)wParam & 0xfff0)) {
                        case 0xF060: // SC_CLOSE
                            isCreated        = false;
                            isCloseRequested = true;
                            return 0;
                        default:
                            break;
                    }
                    break;
            }
            return DefWindowProc(hWnd, Msg, wParam, lParam);
        }

        private static void sendError(string strMessage, bool sendThrow) {
            System.Console.WriteLine(strMessage);
            if (sendThrow)
                throw new System.InvalidOperationException(strMessage);
        }

        private void initWndProcDelegate() {
            wndProcDelegate = new WndProcDelegate(WndProc); // GWL_WNDPROC -4
            SetWindowLongA(hWnd, -4, System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(wndProcDelegate).ToPointer());
        }

        public void create(string className) {
            hInstance = GetModuleHandle(null);
            hWnd = (void*)0;
            hDC  = (void*)0;
            //hRC  = (void*)0;
            isCreated        = true;
            isCloseRequested = false;
            uint style = 0xCF0000 | 0x4000000 | 0x2000000; // WS_OVERLAPPEDWINDOW | WS_CLIPSIBLINGS | WS_CLIPCHILDREN
            hWnd = CreateWindowEx(0, className, " ", style, 0, 0, 512, 512, (void*)0, (void*)0, hInstance, (void*)0);
            if (hWnd == (void*)0) {
                sendError("Failed to create window.", false);
                return;
            }
            hDC = GetDC(hWnd);
            if (hDC == (void*)0) {
                sendError("Failed to create device context.", false);
                return;
            }
            initWndProcDelegate();
        }

        public void create(void* hWnd_ptr) {
            hInstance = GetModuleHandle(null);
            hWnd = (void*)0;
            hDC  = (void*)0;
            //hRC  = (void*)0;
            isCreated = true;
            isCloseRequested = false;
            hWnd = hWnd_ptr;
            if (hWnd == (void*)0) {
                sendError("Failed to create window.", false);
                return;
            }
            hDC = GetDC(hWnd);
            if (hDC == (void*)0) {
                sendError("Failed to create device context.", false);
                return;
            }
            initWndProcDelegate();
        }

        public void show() {
            ShowWindow(hWnd, 1); // 1 SW_SHOWNORMAL
            UpdateWindow(hWnd);
        }

        public void hide() {
            ShowWindow(hWnd, 0); // 0 SW_HIDE
            UpdateWindow(hWnd);
        }

        public void create() {
            create(NativeWindowClass.defaultClassName);
        }

        public void create(bool needShow) {
            create(NativeWindowClass.defaultClassName);
            if (needShow)
                show();
        }

        public void create(string className, bool needShow) {
            create(className);
            if (needShow)
                show();
        }

        public void destroy() {
            isCreated        = false;
            isCloseRequested = true;
            PostQuitMessage(0);
            ReleaseDC(hWnd, hDC);
            DestroyWindow(hWnd);
        }

        public void update() { // Обработка сообщений окна
            MSG msg = new MSG();
            while (PeekMessage(ref msg, (void*)0, 0, 0, 0x0001)) { // PM_REMOVE = 0x0001; GetMessage(ref msg, (void*)0, 0, 0) != (void*)0
                TranslateMessage(ref msg);
                DispatchMessage(ref msg);
            }
            //SwapBuffers(hDC);
        }
    }
}
