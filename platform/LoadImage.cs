//======================================
//  LoadImage
//  Created on: 18.12.2025 13:39:26
//  Author: Vova43
//======================================
namespace platform {
    /// <summary> Класс представляющий загрузку изображений и получение их указателя для использования в API OpenGL, OpenGLES </summary>
    public unsafe class LoadImage {
        /// <summary> Реализует загрузку RLE изображений. RLE это тип изображений использующих алгоритмы сжатия lzw подходит для простых битомапов для хранения бетомапов шрифтов и т.д, данный формат отличается легковесностью </summary>
        [System.Runtime.InteropServices.DllImport("libUtilsDll.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* nativeReadImageRLE(string filename, ref int width, ref int height, ref int depth);
        /// <summary> Реализует загрузку любых изображений от jpg до gif, поддерживают прозрачность png, основной метод для работы с чтением изображений </summary>
        [System.Runtime.InteropServices.DllImport("libUtilsDll.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* nativeReadImage(string filename, ref int width, ref int height, ref int depth, int req_comp);
        /// <summary> Реализует освобождение изображения после его использования. Данный метод необходимо всегда вызывать если изображение было загружено чтобы освободить его из оперативной памяти </summary>
        public static void freeNativeImage(void* ptrImage) {
            if (ptrImage == (void*)0)
                return;
            Mem.free(ptrImage);
        }
    }
}
