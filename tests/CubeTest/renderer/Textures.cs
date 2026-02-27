//======================================
//  Textures
//  Created on: 19.01.2026 0:29:38
//  Author: Vova43
//======================================
namespace tests.CubeTest.renderer {
    /// <summary>
    /// Предназначен для загрузки текстур и получение их идентификатора
    /// <para>uint tex = Textures.loadTexture(".\\test.png", GL11.GL_NEAREST); // Где resource = "Путь до файла", textureFilterMode = Режим фильтрации(флаг open gl пример GL11.GL_NEAREST)</para>
    /// <para>GL11.glEnable(GL11.GL_TEXTURE_2D); // Включение атрибутов для использования текстур "включение текстурирования"</para>
    /// <para>GL11.glBindTexture(GL11.GL_TEXTURE_2D, tex); // Привязка текстуры "активация текстуры на момент рендеринга с её использованием"</para>
    /// <para>GL11.glBindTexture(GL11.GL_TEXTURE_2D, 0); // Для отвязки всех текстур "использованных во время рендеринга"</para>
    /// <para>Textures.destroy(); // Если все ранее загруженные текстуры больше не нужены уничтожить их можно вызвав метод destroy</para>
    /// </summary>
    using openGL;
    using platform;
    public static unsafe class Textures {
        public static System.Collections.Generic.List<uint> textureIdList = null; // old public static System.Collections.Generic.Dictionary<string, uint> textureIdMap;
        public static uint lastBoundTextureId = 0;
        private static int width = 0;
        private static int height = 0;
        private static int depth = 0;

        [System.Runtime.InteropServices.DllImport("libUtilsDll.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* nativeReadImageRLE(string filename, ref int width, ref int height, ref int depth);

        [System.Runtime.InteropServices.DllImport("libUtilsDll.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* nativeReadImage(string filename, ref int width, ref int height, ref int depth, int req_comp);

        public static void bindTexture(uint textureId) {
            if (textureId != Textures.lastBoundTextureId) {
                GL11.glBindTexture(GL11.GL_TEXTURE_2D, textureId);
                Textures.lastBoundTextureId = textureId;
            }
        }

        public static uint loadTexture(string resource, int textureFilterMode) {
            try {
                width = 0;
                height = 0;
                depth = 0;
                uint textureId = 0;
                GL11.glGenTextures(1, &textureId);
                bindTexture(textureId);

                GL11.glTexParameteri(GL11.GL_TEXTURE_2D, GL11.GL_TEXTURE_MIN_FILTER, textureFilterMode);
                GL11.glTexParameteri(GL11.GL_TEXTURE_2D, GL11.GL_TEXTURE_MAG_FILTER, textureFilterMode);

                void* ptr = nativeReadImage(resource, ref width, ref height, ref depth, 0);
                GL11.glTexImage2D(GL11.GL_TEXTURE_2D, 0, GL11.GL_RGBA, width, height, 0, GL11.GL_RGBA, GL11.GL_UNSIGNED_BYTE, ptr);
                Mem.free(ptr);

                return textureId;
            }
            catch (System.Exception ex) {
                throw new System.Exception("Failed to load texture! " + ex.Message);
            }
        }

        //public static uint loadTextureTM(string resourceTM, int textureFilterMode) {
        //    try {
        //        uint[] textureId = new uint[1] { 0 };
        //        //GL11.glGenTextures(1, (uint*)textureId[0]);
        //        fixed (uint* ptrTextureId = &textureId[0]) {
        //            GL11.glGenTextures(1, ptrTextureId);
        //        }
        //        bindTexture(textureId[0]);
        //        GL11.glTexParameteri(GL11.GL_TEXTURE_2D, GL11.GL_TEXTURE_MIN_FILTER, textureFilterMode);
        //        GL11.glTexParameteri(GL11.GL_TEXTURE_2D, GL11.GL_TEXTURE_MAG_FILTER, textureFilterMode);

        //        int width = 1280;
        //        int height = 1280;
        //        int[] rawPixels = new int[width * height];
        //        byte[] bytes = System.IO.File.ReadAllBytes(resourceTM);
        //        int shift = 0;
        //        for (int i = 0; i < rawPixels.Length; i++) {
        //            rawPixels[i] = (
        //                    bytes[shift + 0] << 24 |
        //                    bytes[shift + 1] << 16 |
        //                    bytes[shift + 2] << 8 |
        //                    bytes[shift + 3]
        //                );
        //            shift += 4;
        //        }

        //        GL11.glTexImage2D(GL11.GL_TEXTURE_2D, 0, GL11.GL_RGBA, width, height, 0, GL11.GL_RGBA, GL11.GL_UNSIGNED_BYTE, (void*)rawPixels[0]);
        //        return textureId[0];
        //    }
        //    catch (System.Exception ex) {
        //        throw new System.Exception("Failed to load texture! " + ex.Message);
        //    }
        //}

        public static void destroyTexture(uint textureId) {
            textureIdList.Remove(textureId);
        }

        public static void destroy() {
            int count = textureIdList.Count;
            for (int i = 0; i < count; i += 1) {
                uint value = textureIdList[i];
                if (value > 0)
                    GL11.glGenTextures(1, &value);
            }
            textureIdList.Clear();
        }

        static Textures() {
            Textures.textureIdList = new System.Collections.Generic.List<uint>(); // old Textures.textureIdMap = new System.Collections.Generic.Dictionary<string, uint>();
            Textures.lastBoundTextureId = 0;
        }
    }
}
