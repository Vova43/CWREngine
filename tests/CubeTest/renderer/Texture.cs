//======================================
//  Texture
//  Created on: 19.01.2026 0:27:20
//  Author: Vova43
//======================================
namespace tests.CubeTest.renderer {
    /// <summary>
    /// Предназначен для загрузки текстур и получение объекта текстуры
    /// <para>Texture tex = new Texture(".\\test.png", GL11.GL_NEAREST); // Где resource = "Путь до файла", textureFilterMode = Режим фильтрации(флаг open gl пример GL11.GL_NEAREST)</para>
    /// <para>GL11.glEnable(GL11.GL_TEXTURE_2D); // Включение атрибутов для использования текстур "включение текстурирования"</para>
    /// <para>GL11.glBindTexture(GL11.GL_TEXTURE_2D, tex.id); // Привязка текстуры "активация текстуры на момент рендеринга с её использованием"</para>
    /// <para>//Или</para>
    /// <para>tex.bind();</para>
    /// <para>GL11.glBindTexture(GL11.GL_TEXTURE_2D, 0); // Для отвязки всех текстур "использованных во время рендеринга"</para>
    /// <para>tex.destroy(); // Если объект больше не нужен уничтожить его можно вызвав метод destroy</para>
    /// </summary>
    using openGL;
    using platform;
    public unsafe class Texture {
        public int width = 0;
        public int height = 0;
        public int depth = 0;
        public uint id = 0;
        public void* data = null;
        public int filterMode = 0;

        [System.Runtime.InteropServices.DllImport("libUtilsDll.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* nativeReadImageRLE(string filename, ref int width, ref int height, ref int depth);

        [System.Runtime.InteropServices.DllImport("libUtilsDll.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void* nativeReadImage(string filename, ref int width, ref int height, ref int depth, int req_comp);

        public void bind() {
            GL11.glBindTexture(GL11.GL_TEXTURE_2D, id);
        }

        public void load(string resource, int textureFilterMode) {
            try {
                width = 0;
                height = 0;
                depth = 0;
                filterMode = textureFilterMode;
                fixed (uint* ptrTextureId = &id) {
                    GL11.glGenTextures(1, ptrTextureId);
                }
                bind();
                GL11.glTexParameteri(GL11.GL_TEXTURE_2D, GL11.GL_TEXTURE_MIN_FILTER, textureFilterMode);
                GL11.glTexParameteri(GL11.GL_TEXTURE_2D, GL11.GL_TEXTURE_MAG_FILTER, textureFilterMode);

                data = nativeReadImage(resource, ref width, ref height, ref depth, 0);
                GL11.glTexImage2D(GL11.GL_TEXTURE_2D, 0, GL11.GL_RGBA, width, height, 0, GL11.GL_RGBA, GL11.GL_UNSIGNED_BYTE, data);
            }
            catch (System.Exception ex) {
                throw new System.Exception("Failed to load texture! " + ex.Message);
            }
        }

        public void destroy() {
            width = 0;
            height = 0;
            depth = 0;
            if (id > 0)
                fixed (uint* ptrTextureId = &id) {
                    GL11.glDeleteTextures(1, ptrTextureId);
                }
            id = 0;
            Mem.free(data);
            data = null;
        }

        public Texture() { }

        public Texture(string resource, int textureFilterMode) {
            load(resource, textureFilterMode);
        }

        ~Texture() {
            destroy();
        }
    }

}
