// by Vova43 / vova436612
namespace platform {
    /// <summary> Класс представляющий обёртку над NativeWindow </summary>
    public unsafe class Display {
        // const flags
        private const int WS_THICKFRAME       = 0x00040000;
        private const int WS_MAXIMIZEBOX      = 0x00010000;
        private const int WS_OVERLAPPEDWINDOW = 0x00CF0000;
        private const int WM_WINDOWPOSCHANGED = 0x0047;
        private const int WM_CREATE           = 0x0001;
        private const int WM_MOVE             = 0x0003;
        private const int WM_SIZE             = 0x0005;
        private const int WM_CANCELMODE       = 0x001F;
        private const int WM_DESTROY          = 0x0002;
        private const int WM_CLOSE            = 0x0010;
        private const int WM_QUIT             = 0x0012;
        private const int WM_ACTIVATE         = 0x0006;
        private const int WM_SYSCOMMAND       = 0x0112;
        private const int WM_SIZING           = 0x0214;
        private const int WM_PAINT            = 0x000F;
        private const int WM_KILLFOCUS        = 0x0008;
        private const int WM_SETFOCUS         = 0x0007;
        private const int WM_GETICON          = 0x007F;
        private const int SC_SIZE         = 0xF000;
        private const int SC_MOVE         = 0xF010;
        private const int SC_MINIMIZE     = 0xF020;
        private const int SC_MAXIMIZE     = 0xF030;
        private const int SC_NEXTWINDOW   = 0xF040;
        private const int SC_PREVWINDOW   = 0xF050;
        private const int SC_CLOSE        = 0xF060;
        private const int SC_VSCROLL      = 0xF070;
        private const int SC_HSCROLL      = 0xF080;
        private const int SC_MOUSEMENU    = 0xF090;
        private const int SC_KEYMENU      = 0xF100;
        private const int SC_ARRANGE      = 0xF110;
        private const int SC_RESTORE      = 0xF120;
        private const int SC_TASKLIST     = 0xF130;
        private const int SC_SCREENSAVE   = 0xF140;
        private const int SC_HOTKEY       = 0xF150;
        private const int SC_DEFAULT      = 0xF160;
        private const int SC_MONITORPOWER = 0xF170;
        private const int SC_CONTEXTHELP  = 0xF180;
        private const int SC_SEPARATOR    = 0xF00F;
        private const int SIZE_RESTORED      = 0;
        private const int SIZE_MINIMIZED     = 1;
        private const int SIZE_MAXIMIZED     = 2;
        private const int WA_INACTIVE        = 0;
        private const int WA_ACTIVE          = 1;
        private const int WA_CLICKACTIVE     = 2;
        public const int SW_NORMAL          = 1;
        public const int SW_SHOWMINNOACTIVE = 7;
        public const int SW_SHOWDEFAULT     = 10;
        public const int SW_RESTORE         = 9;
        public const int SW_MAXIMIZE        = 3;
        public const int SW_SHOWNORMAL      = 1;
        public const int SW_HIDE            = 0;
        public const int SW_SHOWMINIMIZED   = 2;
        public const int SW_SHOWMAXIMIZED   = 3;
        public const int SW_SHOWNOACTIVATE  = 4;
        public const int SW_SHOW            = 5;
        public const int SW_MINIMIZE        = 6;
        public const int SW_SHOWNA          = 8;
        public const int SW_FORCEMINIMIZE   = 11;
        private const int SWP_NOSIZE         = 0x0001;
        private const int SWP_NOMOVE         = 0x0002;
        private const int SWP_NOZORDER       = 0x0004;
        private const int SWP_FRAMECHANGED   = 0x0020;
        private const int SWP_SHOWWINDOW     = 0x0040;
        private const int SWP_NOOWNERZORDER  = 0x0200;
        private const int GWL_WNDPROC        = -4;
        private const int GWL_STYLE          = -16;
        private const int GWL_EXSTYLE        = -20;
        private const long HWND_TOP          = 0;
        private const long HWND_BOTTOM       = 1;
        private const long HWND_TOPMOST      = -1;
        private const long HWND_NOTOPMOST    = -2;

        // Keyboard
        private const int WM_KEYDOWN    = 256;
        private const int WM_KEYUP      = 257;
        private const int WM_SYSKEYUP   = 261;
        private const int WM_SYSKEYDOWN = 260;
        private const int WM_SYSCHAR    = 262;
        private const int WM_CHAR       = 258;

        // Mouse
        private const int WM_MOUSEMOVE      = 0x0200;
        private const int WM_LBUTTONDOWN    = 0x0201;
        private const int WM_LBUTTONUP      = 0x0202;
        private const int WM_LBUTTONDBLCLK  = 0x0203;
        private const int WM_RBUTTONDOWN    = 0x0204;
        private const int WM_RBUTTONUP      = 0x0205;
        private const int WM_RBUTTONDBLCLK  = 0x0206;
        private const int WM_MBUTTONDOWN    = 0x0207;
        private const int WM_MBUTTONUP      = 0x0208;
        private const int WM_MBUTTONDBLCLK  = 0x0209;
        private const int WM_XBUTTONDOWN    = 0x020B;
        private const int WM_XBUTTONUP      = 0x020C;
        private const int WM_XBUTTONDBLCLK  = 0x020D;
        private const int WM_MOUSEWHEEL     = 0x020A;
        private const int WM_CAPTURECHANGED = 0x0215;
        private const int WM_MOUSELEAVE     = 0x02A3;
        private const int WM_SETCURSOR      = 0x0020;
        private const int WM_MOUSEACTIVATE  = 0x0021;
        private const int MK_XBUTTON1 = 0x0020;
        private const int MK_XBUTTON2 = 0x0040;
        private const int XBUTTON1    = 0x0001;
        private const int XBUTTON2    = 0x0002;
        private const int SM_CXCURSOR          = 13;
        private const int SM_CYCURSOR          = 14;
        private const int SM_CMOUSEBUTTONS     = 43;
        private const int SM_MOUSEWHEELPRESENT = 75;

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct RECT {
            public int x;      // left
            public int y;      // top
            public int width;  // right
            public int height; // bottom
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct POINT {
            public int x;      // left
            public int y;      // top
        }

        // Display
        public platform.NativeWindow nativeWindow;
        private RECT windowSizeRect;
        private POINT windowPosPoint;
        private delegate long WndProcDelegate(void* hWnd, uint Msg, uint wParam, uint lParam);
        private WndProcDelegate wndProcDelegate = null;

        public bool isCreated        = false;
        public bool isCloseRequested = false;
        public bool isResizable      = true;
        public bool isFullscreen     = false;
        public bool isDirty          = false;
        public bool isIconsLoaded    = false;
        public bool isFocused        = false;
        public bool isMaximized      = false;
        public bool isMinimized      = false;
        public bool isVisible        = false;
        public bool inAppActivate    = false;

        public int x = 0;
        public int y = 0;
        public int width  = 100;
        public int height = 100;
        public string title = "";

        // keyboard
        public bool[] keys     = new bool[256];
        public bool[] keyPress = new bool[256];
        public byte[] keyState = new byte[256];
        public uint keyCode         = 0;
        public uint lastKeyCode     = 0;
        public uint keyCodeChar     = 0;
        public uint lastKeyCodeChar = 0;

        // mouse
        public bool[] keysMouse     = new bool[16];
        public bool[] keyPressMouse = new bool[16];
        public bool isGrabbedMouse       = false;
        public bool isClippedCursorMouse = false;
        public bool isMouseInsideMouse   = false;
        public bool isMouseHasWheel      = false;
        public int captureMouseButton    = -1;
        public int keyCodeMouse          = -1;
        public int lastKeyCodeMouse      = -1;
        public int mouseButtonCount      = 16;
        public int xMouse      = 0;
        public int yMouse      = 0;
        public int zMouse      = 0;
        public int xLastMouse  = 0;
        public int yLastMouse  = 0;
        public int zLastMouse  = 0;
        public int xDeltaMouse = 0;
        public int yDeltaMouse = 0;
        public int zDeltaMouse = 0;
        private RECT rectSetClipCursor = new RECT();

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern long DefWindowProcA(void* hWnd, uint msg, uint wParam, uint lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* SetWindowLongA(void* hWnd, int nIndex, void* dwNewLong);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* GetWindowLongA(void* hWnd, int nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool GetClientRect(void* hWnd, out RECT rect);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool ClientToScreen(void* hWnd, out POINT point);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* SetFocus(void* hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool SetForegroundWindow(void* hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern int GetSystemMetrics(int nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool ShowWindow(void* hWnd, int nCmdShow);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* SetWindowTextA(void* hWnd, string title);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool SetWindowPos(void* hWnd, void* hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        // keyboard
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool GetKeyboardState(byte[] pbKeyState);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern short VkKeyScanEx(char ch, void* dwhkl);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, char* lpChar, int cchBuf, uint flags, void* dwhkl);

        // mouse
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* SetCapture(void* HWND);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void* GetCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern int ShowCursor(bool bShow);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool ClipCursor(ref Display.RECT lpRect);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool ClipCursor(void* lpRect);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool GetClipCursor(out Display.RECT lpRect);

        private void clearWindowSizeRect() { // Используется для обновления текущих координат во время использования windowSizeRect
            windowSizeRect.width  = windowSizeRect.x = 0;
            windowSizeRect.height = windowSizeRect.y = 0;
        }

        private void updateWidthAndHeight(void* hWnd) { // GetClientRect - Метод возвращает текущий размер окна с учётом клиентской области даже если отсутствует заголовок окна(В таком случае клиентская область занимает весь размер окна)
            GetClientRect(hWnd, out windowSizeRect);
            width  = windowSizeRect.width - windowSizeRect.x;
            height = windowSizeRect.height - windowSizeRect.y;
        }

        private void updateXAndY(void* hWnd) { // ClientToScreen - Метод возвращает текущий положение окна с учётом клиентской области даже если отсутствует заголовок окна(В таком случае клиентская область занимает весь размер окна)
            windowPosPoint.x = 0;
            windowPosPoint.y = 0;
            ClientToScreen(hWnd, out windowPosPoint);
            x = windowPosPoint.x;
            y = windowPosPoint.y;
        }

        private void appActivate(bool active, void* hWnd) { // Механизм активной фиксации окна в момент фокуса
            if (inAppActivate) {
                return;
            }
            inAppActivate = true;
            isFocused = active;
            if (active) {
                SetForegroundWindow(hWnd);
                SetFocus(hWnd);
                //if (Display.isFullscreen)
                //    Mouse.updateClipping();
            }
            //else if (Display.isFullscreen) {
            //     ShowWindow(getHWND(), SW_SHOWMINNOACTIVE);
            //}
            //else
            //    Mouse.updateClipping();
            //updateCursor();
            inAppActivate = false;
        }

        private void handleChar(uint wParam, long lParam) { // keyboard
            lastKeyCodeChar = keyCodeChar;
            keyCodeChar = (wParam & 0xFFFF);
        }

        private void handleKeyButton(uint wParam, long lParam, int state) { // keyboard
            if (state == 0) {
                this.keys[wParam]     = false;
                this.keyPress[wParam] = false;
                lastKeyCode = keyCode;
                keyCode = 0;
            }
            else {
                this.keys[wParam] = true;
                if (((lParam >> 30) & 0x1) != (1 - ((lParam >> 31) & 0x1)))
                    this.keyPress[wParam] = true;
                lastKeyCode = keyCode;
                keyCode = wParam;
            }
        }

        private void handleMouseButton(int button, int state, void* hWnd) { // mouse
            if (state != 0) {
                this.keyPressMouse[button] = true;
                this.keysMouse[button]     = true;
                lastKeyCodeMouse = keyCodeMouse;
                keyCodeMouse = button;
            }
            else {
                this.keyPressMouse[button] = false;
                this.keysMouse[button]     = false;
                lastKeyCodeMouse = keyCodeMouse;
                keyCodeMouse = -1;
            }
            if (captureMouseButton == -1 && button != -1 && state == 1) { // need to capture?
                captureMouseButton = button;
                SetCapture(hWnd);
            }
            if (captureMouseButton != -1 && button == captureMouseButton && state == 0) { // done with capture?
                captureMouseButton = -1;
                ReleaseCapture();
            }
        }

        private int dxMouse = 0;
        private int dyMouse = 0;
        private void handleMouseMoved(int x, int y) {
            if ((x & 1 << 15) != 0) x -= (1 << 16); // #2
            if ((y & 1 << 15) != 0) y -= (1 << 16); // #2
            this.xMouse = x;
            this.yMouse = y;
            dxMouse = x - xLastMouse;
            dyMouse = y - yLastMouse;
            if (dxMouse != 0 || dyMouse != 0) {
                xLastMouse = x;
                yLastMouse = y;
                if (isGrabbedMouse) {
                    this.xDeltaMouse = dxMouse;
                    this.yDeltaMouse = dyMouse;
                    xLastMouse = this.width / 2;
                    yLastMouse = this.height / 2;
                    SetCursorPos(this.x + xLastMouse, this.y + yLastMouse);
                }
                else {
                    this.xDeltaMouse = x;
                    this.yDeltaMouse = y;
                }
            }
        }

        private void handleMouseScrolled(int dwheel) { // mouse
            zMouse = dwheel;
            zDeltaMouse = zLastMouse + zMouse;
            zLastMouse = zMouse;
        }

        public void centerCursor() { // mouse
            xLastMouse = this.width / 2;
            yLastMouse = this.height / 2;
            SetCursorPos(this.x + xLastMouse, this.y + yLastMouse);
        }

        public void updateClipping() { // mouse // #1
            if (isClippedCursorMouse) {
                rectSetClipCursor.x = this.x;
                rectSetClipCursor.y = this.y;
                rectSetClipCursor.width = this.x + this.width;
                rectSetClipCursor.height = this.y + this.height;
                ClipCursor(ref rectSetClipCursor);
            }
            else {
                ClipCursor((void*)0);
            }
        }

        private long WndProc(void* hWnd, uint msg, uint wParam, uint lParam) { // см коммент #1 //return void* --> long OK
            // Display
            switch (msg) {
                case WM_ACTIVATE:
                    switch ((int)wParam) {
                        case WA_ACTIVE:
                        case WA_CLICKACTIVE:
                            appActivate(true, hWnd);
                            break;
                        case WA_INACTIVE:
                            appActivate(false, hWnd);
                            break;
                    }
                    return 0L;
                case WM_CREATE:
                    updateWidthAndHeight(hWnd);
                    break;
                case WM_SIZE:
                    updateXAndY(hWnd);
                    updateWidthAndHeight(hWnd);
                    //width = (int)(lParam & 0xffff);
                    //height = (int)(lParam >> 16 & 0xffff);
                    switch ((int)wParam) {
                        case SIZE_RESTORED:
                        case SIZE_MAXIMIZED:
                            isMaximized = ((int)wParam) == SIZE_MAXIMIZED;
                            isResizable = true;
                            isMinimized = false;
                            break;
                        case SIZE_MINIMIZED:
                            isMinimized = true;
                            break;
                    }
		            break;
                case WM_MOVE:
                    updateXAndY(hWnd);
                    updateWidthAndHeight(hWnd);
                    break;
                case WM_DESTROY:
                    isCloseRequested = true;
                    break;
                case WM_QUIT:
                    isCloseRequested = true;
                    break;
                case WM_SYSCOMMAND:
                    switch ((int)((long)wParam & 0xfff0)) {
                        case SC_KEYMENU:
                        case SC_MOUSEMENU:
                        case SC_SCREENSAVE:
                        case SC_MONITORPOWER:
                            return 0L;
                        case SC_CLOSE:
                            isCloseRequested = true;
                            return 0L;
                        default:
                            break;
                    }
                    break;
                case WM_SIZING:
                    isResizable = true;
                    break;
                case WM_KILLFOCUS:
                    appActivate(false, hWnd);
                    return 0L;
                case WM_SETFOCUS:
                    appActivate(true, hWnd);
                    return 0L;
                case WM_PAINT:
                    isDirty = true;
                    break;
                case WM_WINDOWPOSCHANGED:
                    updateXAndY(hWnd);
                    updateWidthAndHeight(hWnd);
                    if (isGrabbedMouse)
                        centerCursor();
                    updateClipping();
                    break;
                case WM_CANCELMODE:
                    ReleaseCapture();
                    break;
                case WM_CAPTURECHANGED:
                    if (captureMouseButton != -1) {
                        handleMouseButton(captureMouseButton, 0, hWnd);
                        captureMouseButton = -1;
                    }
                    return 0L;
                case WM_GETICON:
                    isIconsLoaded = true; //....
                    break;
                //case WM_SETCURSOR:
                //    if (((long)lParam & 0xFFFF) == 0x01) {
                //        //System.Console.WriteLine("WM_SETCURSOR\n");
                //        //return 1; //TRUE
                //        return DefWindowProcA(hWnd, Msg, wParam, lParam);
                //    }
                //    else {
                //        //System.Console.WriteLine("WM_SETCURSOR NO WM\n");
                //        //if (Mouse.isCreated)
                //        //    Mouse.resetKeyButtons();
                //        return DefWindowProcA(hWnd, Msg, wParam, lParam);
                //    }
                //    break;
            }

            // Keyboard
            switch (msg) {
                case WM_SYSCHAR:
                case WM_CHAR:
                    handleChar(wParam, lParam);
                    return 0L;
                case WM_SYSKEYUP:
                case WM_KEYUP:
                    handleKeyButton(wParam, lParam, 0);
                    //break;
                    return 0L;
                case WM_SYSKEYDOWN:
                case WM_KEYDOWN:
                    handleKeyButton(wParam, lParam, 1);
                    //break;
                    return 0L;
            }

            // Mouse
            switch (msg) {
                case WM_MOUSEACTIVATE:
                    if (!isFocused)
                        SetFocus(hWnd);
                    System.Console.WriteLine("SetFocus WM_MOUSEACTIVATE");
                    return 3L; // MA_NOACTIVATE
                case WM_MOUSELEAVE:
                    isMouseInsideMouse = false;
                    break;
                case WM_MOUSEMOVE:
                    //Mouse.x = (int)((long)lParam & 0xffff); // LOWORD
                    //Mouse.y = (int)(((long)lParam >> 16) & 0xffff); // HIWORD
                    isMouseInsideMouse = true;
                    handleMouseMoved((int)(lParam & 0xffff), (int)((lParam >> 16) & 0xffff));
                    return 0L;
                case WM_MOUSEWHEEL:
                    //Mouse.zDelta += (int)(short)(((long)wParam >> 16) & 0xFFFF); // HIWORD
                    handleMouseScrolled((short)((wParam >> 16) & 0xFFFF));
                    return 0L;
                case WM_LBUTTONDOWN:
                    handleMouseButton(0, 1, hWnd);
                    return 0L;
                case WM_LBUTTONUP:
                    handleMouseButton(0, 0, hWnd);
                    return 0L;
                case WM_RBUTTONDOWN:
                    handleMouseButton(1, 1, hWnd);
                    return 0L;
                case WM_RBUTTONUP:
                    handleMouseButton(1, 0, hWnd);
                    return 0L;
                case WM_MBUTTONDOWN:
                    handleMouseButton(2, 1, hWnd);
                    return 0L;
                case WM_MBUTTONUP:
                    handleMouseButton(2, 0, hWnd);
                    return 0L;
                case WM_XBUTTONUP:
                    if (((long)wParam >> 16) == XBUTTON1)
                        handleMouseButton(3, 0, hWnd);
                    else
                        handleMouseButton(3, 0, hWnd);
                    return 1;
                case WM_XBUTTONDOWN:
                    if (((long)wParam & 0xFF) == MK_XBUTTON1)
                        handleMouseButton(3, 1, hWnd);
                    else
                        handleMouseButton(4, 1, hWnd);
                    return 1;
            }
            return DefWindowProcA(hWnd, msg, wParam, lParam);
        }

        private void initWndProcDelegate(platform.NativeWindow nativeWindow) {
            wndProcDelegate = new WndProcDelegate(WndProc);
            SetWindowLongA(nativeWindow.hWnd, GWL_WNDPROC, System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(wndProcDelegate).ToPointer());
        }
        /// <param name="className">Имя чертежа используемого для задания базовых стилей, создаётся в NativeWindowClass</param>
        public void create(string className) {
            if (nativeWindow != null)
                nativeWindow.destroy();
            nativeWindow = new platform.NativeWindow();
            nativeWindow.create(className);

            initWndProcDelegate(nativeWindow);
            updateXAndY(nativeWindow.hWnd);
            updateWidthAndHeight(nativeWindow.hWnd);
            isCloseRequested = false;
            isCreated        = true;

            mouseButtonCount = System.Math.Min(5, Display.GetSystemMetrics(SM_CMOUSEBUTTONS));
            isMouseHasWheel  = Display.GetSystemMetrics(SM_MOUSEWHEELPRESENT) != 0;
        }

        /// <param name="hWnd_ptr">Указатель на существующее окно в качестве указателя может быть элемент(control) форма(Form даже из System.Windows.Form / form.Handle) и т.д.</param>
        public void create(void* hWnd_ptr) {
            if (nativeWindow != null)
                nativeWindow.destroy();
            nativeWindow = new platform.NativeWindow();
            nativeWindow.create(hWnd_ptr);

            initWndProcDelegate(nativeWindow);
            updateXAndY(nativeWindow.hWnd);
            updateWidthAndHeight(nativeWindow.hWnd);
            isCloseRequested = false;
            isCreated = true;

            mouseButtonCount = System.Math.Min(5, Display.GetSystemMetrics(SM_CMOUSEBUTTONS));
            isMouseHasWheel = Display.GetSystemMetrics(SM_MOUSEWHEELPRESENT) != 0;
        }

        public void destroy() {
            nativeWindow.destroy();
            isCloseRequested = true;
            isCreated        = false;
        }

        public void update() {
            nativeWindow.update();
        }

        //public void makeCurrent() {
        //    //fixed (Sys.NativeWindow* pNativeWindow = &nativeWindow) {
        //    //    Sys.makeContext(pNativeWindow);
        //    //}
        //}

        public Display() {
            create(NativeWindowClass.defaultClassName);
        }
        /// <param name="className">Имя чертежа используемого для задания базовых стилей, создаётся в NativeWindowClass</param>
        public Display(string className) {
            create(className);
        }

        /// <param name="hWnd_ptr">Указатель на существующее окно в качестве указателя может быть элемент(control) форма(Form даже из System.Windows.Form / form.Handle) и т.д.</param>
        public Display(void* hWnd_ptr) {
            create(hWnd_ptr);
        }

        public bool show(int nCmdShow_SW) {
            if (nCmdShow_SW == SW_HIDE)
                isVisible = false;
            else
                isVisible = true;
            return ShowWindow(nativeWindow.hWnd, nCmdShow_SW);
        }

        public bool show() {
            isVisible = true;
            return ShowWindow(nativeWindow.hWnd, SW_SHOW);
        }

        public Display(bool needShow) {
            create(NativeWindowClass.defaultClassName);
            if (needShow)
                show();
        }
        /// <param name="className">Имя чертежа используемого для задания базовых стилей, создаётся в NativeWindowClass</param>
        public Display(string className, bool needShow) {
            create(className);
            if (needShow)
                show();
        }

        public void setVisible(bool visible) {
            isVisible = visible;
            if (visible)
                ShowWindow(nativeWindow.hWnd, SW_SHOW);
            else
                ShowWindow(nativeWindow.hWnd, SW_HIDE);
        }

        public void setPosition(int newX, int newY) {
            x = newX;
            y = newY;
            SetWindowPos(nativeWindow.hWnd, (void*)HWND_TOP, x, y, width, height, (int)(SWP_NOSIZE | SWP_SHOWWINDOW | SWP_FRAMECHANGED));
            updateClipping();
        }

        public void setSize(int newWidth, int newHeight) {
            width = newWidth;
            height = newHeight;
            SetWindowPos(nativeWindow.hWnd, (void*)HWND_TOP, x, y, width, height, (int)(SWP_SHOWWINDOW | SWP_FRAMECHANGED));
            updateClipping();
        }

        public void setTitle(string newTitle) {
            title = newTitle;
            SetWindowTextA(nativeWindow.hWnd, title);
        }

        public void setResizable(bool resizable) {
            if (isResizable != resizable) {
                int style = (int)GetWindowLongA(nativeWindow.hWnd, GWL_STYLE);
                if (resizable && !isFullscreen) { // update frame style
                    SetWindowLongA(nativeWindow.hWnd, GWL_STYLE, (void*)(style |= (WS_THICKFRAME | WS_MAXIMIZEBOX)));
                }
                else {
                    SetWindowLongA(nativeWindow.hWnd, GWL_STYLE, (void*)(style &= ~(WS_THICKFRAME | WS_MAXIMIZEBOX)));
                }
                updateClipping();
            }
            isResizable = resizable;
        }

        public void setOverlapped(bool overlapped) {
            int style = (int)GetWindowLongA(nativeWindow.hWnd, GWL_STYLE);
            if (overlapped) { // update frame style
                SetWindowLongA(nativeWindow.hWnd, GWL_STYLE, (void*)(style & ~WS_OVERLAPPEDWINDOW));
            }
            else {
                SetWindowLongA(nativeWindow.hWnd, GWL_STYLE, (void*)(style | WS_OVERLAPPEDWINDOW));
            }
            SetWindowPos(nativeWindow.hWnd, (void*)0, 0, 0, 0, 0, SWP_NOZORDER | SWP_NOOWNERZORDER | SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);
            updateXAndY(nativeWindow.hWnd);
            updateWidthAndHeight(nativeWindow.hWnd);
            updateClipping();
        }

        public void setFullscreen(bool fullscreen) {
            isFullscreen = fullscreen;
            setOverlapped(fullscreen);
            if (fullscreen) { // update frame style
                ShowWindow(nativeWindow.hWnd, SW_MAXIMIZE);
                SetWindowPos(nativeWindow.hWnd, (void*)HWND_TOP, 0, 0, 0, 0, SWP_NOZORDER | SWP_NOOWNERZORDER | SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);
            }
            else {
                ShowWindow(nativeWindow.hWnd, SW_NORMAL);
                SetWindowPos(nativeWindow.hWnd, (void*)HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOZORDER | SWP_NOOWNERZORDER | SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);
            }
            updateXAndY(nativeWindow.hWnd);
            updateWidthAndHeight(nativeWindow.hWnd);
            updateClipping();
        }

        public bool isKeyPressed(int keyCode) { // keyboard
            bool keyPressed = keyPress[keyCode];
            keyPress[keyCode] = false;
            return keyPressed;
        }

        public bool isKeyDown(int keyCode) { // keyboard
            return keys[keyCode];
        }

        public bool updateBytesKeyState() {  // keyboard
            return GetKeyboardState(keyState);
        }

        public char[] getUnicodeChars(uint vKey, int count) { // keyboard
            if (!updateBytesKeyState())
                return null;
            char* unicodeCharsBuffer = (char*)System.Runtime.InteropServices.Marshal.AllocHGlobal(count * sizeof(char));
            int result = ToUnicodeEx((uint)vKey, MapVirtualKey((uint)vKey, 0), keyState, unicodeCharsBuffer, count, 0, (void*)0);
            char[] resultStr = new char[result];
            for (int i = 0; i < result; i += 1) {
                resultStr[i] = unicodeCharsBuffer[i];
                if (unicodeCharsBuffer[i] == '\0')
                    break;
            }
            Mem.free(unicodeCharsBuffer);
            return resultStr;
        }

        public int getUnicodeChars(uint vKey, char[] buffer, int count) { // keyboard
            if (!updateBytesKeyState())
                return 0;
            int result = 0;
            fixed (char* unicodeCharsBuffer = &buffer[0]) {
                result = ToUnicodeEx((uint)vKey, MapVirtualKey((uint)vKey, 0), keyState, unicodeCharsBuffer, count, 0, (void*)0);
                //for (int i = 0; i < result; i += 1) {
                //    if (unicodeCharsBuffer[i] == '\0')
                //        break;
                //}
            }
            return result;
        }

        public bool isMouseKeyPressed(int keyCode) { // mouse
            bool keyPressed = keyPressMouse[keyCode];
            keyPressMouse[keyCode] = false;
            return keyPressed;
        }

        public bool isMouseKeyDown(int keyCode) { // mouse
            return keysMouse[keyCode];
        }

        public void setClipCursor(bool clip) { // mouse
            isClippedCursorMouse = clip;
            updateClipping();
        }

        public void setPositionCursor(int newX, int newY) { // mouse
            xMouse = newX;
            yMouse = newY;
            SetCursorPos(this.x + xMouse, this.y + yMouse);
        }

        public void setGrabbedCursor(bool grab) { // mouse
            isGrabbedMouse = grab;
            xDeltaMouse = 0;
            yDeltaMouse = 0;
            xLastMouse = this.width / 2;
            yLastMouse = this.height / 2;
            SetCursorPos((this.x * 2 + this.width) / 2, (this.y * 2 + this.height) / 2);
            setClipCursor(isGrabbedMouse);
            ShowCursor(!isGrabbedMouse); // <<-- скрыть курсор
        }

        public bool setFocus(bool focus) {
            isFocused = focus;
            if (focus) {
                isFocused = SetForegroundWindow(nativeWindow.hWnd);
                SetFocus(nativeWindow.hWnd);
            }
            return isFocused;
        }

        public int getDeltaWheel() {
            return zDeltaMouse;
        }

        public int getMinCursorSize() {
            return Display.GetSystemMetrics(SM_CXCURSOR);
        }

        public int getMaxCursorSize() {
            return Display.GetSystemMetrics(SM_CXCURSOR);
        }
    }
}
