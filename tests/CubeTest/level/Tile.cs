//======================================
//  Tile
//  Created on: 19.01.2026 0:24:23
//  Author: Vova43
//======================================
namespace tests.CubeTest.level {
    using renderer;
    public class Tile {
        private int getTexture(int face) {
            return 0;
        }

        public static void renderFace(Tessellator t, int x, int y, int z, int face, byte tex) {
            //int tex = getTexture(face);
            //int tex = face;
            if (tex > 0) {
                tex -= 1;
            }
            float u0 = (tex % 16) / 16.0F;
            float u1 = u0 + 0.0624375F;
            float v0 = (tex / 16) / 16.0F;
            float v1 = v0 + 0.0624375F;
            float x0 = x + 0.0F;
            float x1 = x + 1.0F;
            float y0 = y + 0.0F;
            float y1 = y + 1.0F;
            float z0 = z + 0.0F;
            float z1 = z + 1.0F;
            if (face == 0) {
                t.vertexUV(x0, y0, z1, u0, v1);
                t.vertexUV(x0, y0, z0, u0, v0);
                t.vertexUV(x1, y0, z0, u1, v0);
                t.vertexUV(x1, y0, z1, u1, v1);
            }
            if (face == 1) {
                t.vertexUV(x1, y1, z1, u1, v1);
                t.vertexUV(x1, y1, z0, u1, v0);
                t.vertexUV(x0, y1, z0, u0, v0);
                t.vertexUV(x0, y1, z1, u0, v1);
            }
            if (face == 2) {
                t.vertexUV(x0, y1, z0, u1, v0);
                t.vertexUV(x1, y1, z0, u0, v0);
                t.vertexUV(x1, y0, z0, u0, v1);
                t.vertexUV(x0, y0, z0, u1, v1);
            }
            if (face == 3) {
                t.vertexUV(x0, y1, z1, u0, v0);
                t.vertexUV(x0, y0, z1, u0, v1);
                t.vertexUV(x1, y0, z1, u1, v1);
                t.vertexUV(x1, y1, z1, u1, v0);
            }
            if (face == 4) {
                t.vertexUV(x0, y1, z1, u1, v0);
                t.vertexUV(x0, y1, z0, u0, v0);
                t.vertexUV(x0, y0, z0, u0, v1);
                t.vertexUV(x0, y0, z1, u1, v1);
            }
            if (face == 5) {
                t.vertexUV(x1, y0, z1, u0, v1);
                t.vertexUV(x1, y0, z0, u1, v1);
                t.vertexUV(x1, y1, z0, u1, v0);
                t.vertexUV(x1, y1, z1, u0, v0);
            }
        }

        public static void renderFaceNoTexture(Tessellator t, int x, int y, int z, int face) {
            float x0 = x + 0.0F;
            float x1 = x + 1.0F;
            float y0 = y + 0.0F;
            float y1 = y + 1.0F;
            float z0 = z + 0.0F;
            float z1 = z + 1.0F;
            if (face == 0) {
                t.vertex(x0, y0, z1);
                t.vertex(x0, y0, z0);
                t.vertex(x1, y0, z0);
                t.vertex(x1, y0, z1);
            }
            if (face == 1) {
                t.vertex(x1, y1, z1);
                t.vertex(x1, y1, z0);
                t.vertex(x0, y1, z0);
                t.vertex(x0, y1, z1);
            }
            if (face == 2) {
                t.vertex(x0, y1, z0);
                t.vertex(x1, y1, z0);
                t.vertex(x1, y0, z0);
                t.vertex(x0, y0, z0);
            }
            if (face == 3) {
                t.vertex(x0, y1, z1);
                t.vertex(x0, y0, z1);
                t.vertex(x1, y0, z1);
                t.vertex(x1, y1, z1);
            }
            if (face == 4) {
                t.vertex(x0, y1, z1);
                t.vertex(x0, y1, z0);
                t.vertex(x0, y0, z0);
                t.vertex(x0, y0, z1);
            }
            if (face == 5) {
                t.vertex(x1, y0, z1);
                t.vertex(x1, y0, z0);
                t.vertex(x1, y1, z0);
                t.vertex(x1, y1, z1);
            }
        }
    }
}
