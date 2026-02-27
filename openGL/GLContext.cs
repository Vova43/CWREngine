// by Vova43 / vova436612
namespace openGL {
    /// <summary> Класс представляющий контекст прикреплённый к окну для API OpenGL </summary>
    public unsafe class GLContext {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PIXELFORMATDESCRIPTOR {
            public ushort nSize;
            public ushort nVersion;
            public uint dwFlags;
            public byte iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public byte iLayerType;
            public byte bReserved;
            public uint dwLayerMask;
            public uint dwVisibleMask;
            public uint dwDamageMask;
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll", SetLastError = true)]
        private static extern int ChoosePixelFormat(void* hWnd, [System.Runtime.InteropServices.In] ref PIXELFORMATDESCRIPTOR ppfd);

        [System.Runtime.InteropServices.DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool SetPixelFormat(void* hWnd, int format, [System.Runtime.InteropServices.In] ref PIXELFORMATDESCRIPTOR ppfd);

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "SwapBuffers")]
        private static extern bool SwapBuffers(void* hDC);
        
        [System.Runtime.InteropServices.DllImport("opengl32.dll", SetLastError = true, EntryPoint = "wglCreateContext")]
        private static extern void* wglCreateContext(void* hWnd);

        [System.Runtime.InteropServices.DllImport("opengl32.dll", SetLastError = true, EntryPoint = "wglMakeCurrent")]
        private static extern bool wglMakeCurrent(void* hWnd, void* hglrc);

        [System.Runtime.InteropServices.DllImport("opengl32.dll", SetLastError = true, EntryPoint = "wglDeleteContext")]
        private static extern bool wglDeleteContext(void* hglrc);

        private static void sendError(string strMessage, bool sendThrow) {
            System.Console.WriteLine(strMessage);
            if (sendThrow)
                throw new System.InvalidOperationException(strMessage);
        }

        public static void* createContext(platform.NativeWindow nativeWindow, PIXELFORMATDESCRIPTOR pixelFormatDescriptor) {
            int pixelFormat = ChoosePixelFormat((void*)nativeWindow.hDC, ref pixelFormatDescriptor);
            if (pixelFormat == 0) {
                sendError("Failed to choose pixel format.", false);
                return (void*)0;
            }

            if (!SetPixelFormat((void*)nativeWindow.hDC, pixelFormat, ref pixelFormatDescriptor)) {
                sendError("Failed to set pixel format.", false);
                return (void*)0;
            }

            void* hRC = (void*)0;
            if (hRC == (void*)0) {
                hRC = wglCreateContext((void*)nativeWindow.hDC);
                if (hRC == (void*)0) {
                    sendError("Failed to create OpenGL rendering context.", false);
                    return (void*)0;
                }

                if (!wglMakeCurrent((void*)nativeWindow.hDC, hRC)) {
                    sendError("Failed to activate OpenGL rendering context.", false);
                    return (void*)0;
                }
            }
            return hRC;
        }

        public static bool makeContext(platform.NativeWindow nativeWindow, void* hRC) {
            return wglMakeCurrent((void*)nativeWindow.hDC, hRC);
        }

        public static bool destroyContext(platform.NativeWindow nativeWindow, void* hRC) {
            wglMakeCurrent((void*)nativeWindow.hDC, (void*)0);
            if (hRC != (void*)0) {
                bool result = wglDeleteContext(hRC);
                //////hRC = (void*)0;
                return result;
            }
            return false;
        }

        public static bool update(platform.NativeWindow nativeWindow) {
            return SwapBuffers(nativeWindow.hDC);
        }

        public static void* createContext(platform.Display display, PIXELFORMATDESCRIPTOR pixelFormatDescriptor) {
            return createContext(display.nativeWindow, pixelFormatDescriptor);
        }

        public static void* createContext(platform.NativeWindow nativeWindow) {
            PIXELFORMATDESCRIPTOR pixelFormatDescriptor = new PIXELFORMATDESCRIPTOR {
                nSize = (ushort)System.Runtime.InteropServices.Marshal.SizeOf(typeof(PIXELFORMATDESCRIPTOR)),
                nVersion = 1,
                dwFlags = 0x00000004 | 0x00000020 | (true ? 0x00000001 : 0) | (true ? 0x00000002 : 0), // PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | (1 ? PFD_DOUBLEBUFFER : 0) | (1 ? PFD_STEREO : 0)
                iPixelType = 0, // PFD_TYPE_RGBA
                cColorBits = 24,
                cRedBits = 0,
                cRedShift = 0,
                cGreenBits = 0,
                cGreenShift = 0,
                cBlueBits = 0,
                cBlueShift = 0,
                cAlphaBits = 0,
                cAlphaShift = 0,
                cAccumBits = 0,
                cAccumRedBits = 0,
                cAccumGreenBits = 0,
                cAccumBlueBits = 0,
                cAccumAlphaBits = 0,
                cDepthBits = 24,
                cStencilBits = 8,
                cAuxBuffers = 0,
                iLayerType = 0, // PFD_MAIN_PLANE
                bReserved = 0,
                dwLayerMask = 0,
                dwVisibleMask = 0,
                dwDamageMask = 0
            };
            return createContext(nativeWindow, pixelFormatDescriptor);
        }

        public static void* createContext(platform.Display display) {
            return createContext(display.nativeWindow);
        }

        public static bool makeContext(platform.Display display, void* hRC) {
            return makeContext(display.nativeWindow, hRC);
        }

        public static bool destroyContext(platform.Display display, void* hRC) {
            return destroyContext(display.nativeWindow, hRC);
        }

        public static bool update(platform.Display display) {
            return SwapBuffers(display.nativeWindow.hDC);
        }
    }
}
