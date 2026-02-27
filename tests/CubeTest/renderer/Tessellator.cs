//======================================
//  Tessellator
//  Created on: 19.01.2026 0:26:39
//  Author: Vova43
//======================================
namespace tests.CubeTest.renderer {
    /// <summary> 
    /// Предназначен для создания простых мешей*
    /// <para>Tessellator tessellator1 = new Tessellator(48(размер буфера для вершин));</para>
    /// <para>tessellator1.mode = GL11.GL_QUADS; // Также обязательно необходимо установить режим примитивов для отрисовки от режима зависит способ построения полигонов</para>
    /// <para>tessellator.flush(); // В цикле рендера для отрисовки на экране</para>
    /// <para>tessellator1.destroy(); // Если объект больше не нужен уничтожить его можно вызвав метод destroy</para>
    /// <para>*Меш (компьютерная графика) — набор вершин и многоугольников(иные примитивы), определяющих форму трёхмерного объекта.</para>
    /// </summary>
    using openGL;
    using platform;
    public unsafe class Tessellator {
        public int vertices = 0;
        public float u = 0;
        public float v = 0;
        public float r = 1;
        public float g = 1;
        public float b = 1;
        public float a = 1;

        public int MAX_VERTICES = 10000000;
        public float* buffer = null;
        public uint mode = 0;
        public bool hasColor = false;
        public bool hasTexture = false;

        public void clear() {
            vertices = 0;
            hasColor = false;
            hasTexture = false;
        }

        public void init(int maxVertices) {
            MAX_VERTICES = maxVertices;
            if (buffer != null)
                Mem.free(buffer);
            clear();
            buffer = (float*)Mem.malloc((uint)((maxVertices * 9) * sizeof(float)));
        }

        public void destroy() {
            if (buffer != null)
                Mem.free(buffer);
            buffer = null;
        }

        public void flush() {
            if (vertices == 0)
                return; // Nothing to draw
            int stride = 9 * sizeof(float); // 9 => 3 + 2 + 4 = 9
            GL11.glVertexPointer(3, GL11.GL_FLOAT, stride, buffer);

            if (hasTexture) {
                GL11.glTexCoordPointer(2, GL11.GL_FLOAT, stride, buffer + 3);
                GL11.glEnableClientState(GL11.GL_TEXTURE_COORD_ARRAY);
            }

            if (hasColor) {
                GL11.glColorPointer(4, GL11.GL_FLOAT, stride, buffer + 5);
                GL11.glEnableClientState(GL11.GL_COLOR_ARRAY);
            }

            GL11.glEnableClientState(GL11.GL_VERTEX_ARRAY);
            GL11.glDrawArrays(mode, 0, vertices);
            GL11.glDisableClientState(GL11.GL_VERTEX_ARRAY);

            if (hasTexture) {
                GL11.glDisableClientState(GL11.GL_TEXTURE_COORD_ARRAY);
            }

            if (hasColor) {
                GL11.glDisableClientState(GL11.GL_COLOR_ARRAY);
            }
        }

        public void tex(float u_, float v_) {
            hasTexture = true;
            u = u_;
            v = v_;
        }

        public void color(float r_, float g_, float b_, float a_) {
            hasColor = true;
            r = r_;
            g = g_;
            b = b_;
            a = a_;
        }

        public void color(uint c) {
            float a = ((c >> 24) & 0xFF) / 255.0f;
            float r = ((c >> 16) & 0xFF) / 255.0f;
            float g = ((c >> 8) & 0xFF) / 255.0f;
            float b = (c & 0xFF) / 255.0f;
            color(r, g, b, a);
        }

        public void vertex(float x, float y, float z) {
            if (vertices < MAX_VERTICES) {
                int bufferIndex = vertices * 9;
                buffer[bufferIndex] = x;
                buffer[bufferIndex + 1] = y;
                buffer[bufferIndex + 2] = z;

                if (hasTexture) { // 3 + 2 = 5
                    buffer[bufferIndex + 3] = u;
                    buffer[bufferIndex + 4] = v;
                }

                if (hasColor) {
                    buffer[bufferIndex + 5] = r; // 5 + 4 = 9
                    buffer[bufferIndex + 6] = g;
                    buffer[bufferIndex + 7] = b;
                    buffer[bufferIndex + 8] = a;
                }
                vertices++;
            }
            else {
                flush();
                clear();
                vertex(x, y, z);
            }
        }

        public void vertexUV(float x, float y, float z, float u, float v) {
            tex(u, v);
            vertex(x, y, z);
        }

        public Tessellator() {
        }

        public Tessellator(int SET_MAX_VERTICES) {
            init(SET_MAX_VERTICES); //MAX_VERTICES * 9 // - > 10000000000 MAX SIZE
        }

        ~Tessellator() {
            destroy();
        }
    }
}
