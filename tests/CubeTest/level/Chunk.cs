//======================================
//  Chunk
//  Created on: 19.01.2026 0:19:40
//  Author: Vova43
//======================================
namespace tests.CubeTest.level {
    using openGL;
    using platform;
    using renderer;
    public class Chunk {
        public int x = 0;
        public int y = 0;
        public int z = 0;
        public Level level = null;
        public uint lists = 0;
        public bool isBuilded = false;
        public int x1 = 0;
        public int y1 = 0;
        public int z1 = 0;

        public Chunk(int _x, int _y, int _z, Level _level) {
            this.x = _x;
            this.y = _y;
            this.z = _z;
            this.level = _level;
            this.lists = GL11.glGenLists(2);
            this.x1 = _x + 16;
            this.y1 = _y + 16;
            this.z1 = _z + 16;
        }

        public void build(uint layer) {
            GL11.glNewList(this.lists + layer, 4864);
            Tessellator tessellator = new Tessellator(24576); // 24576 = 16 * 16 * 16 * 6
            tessellator.mode = GL11.GL_QUADS;
            for (int yp = y; yp < y1; yp += 1) {
                for (int xp = x; xp < x1; xp += 1) {
                    for (int zp = z; zp < z1; zp += 1) {
                        if (this.level.isTile(xp, yp, zp)) {
                            byte tex = this.level.getTile(xp, yp, zp);
                            if (!this.level.isTile(xp, yp + 1, zp))
                                Tile.renderFace(tessellator, xp, yp, zp, 1, tex);
                            if (!this.level.isTile(xp, yp - 1, zp))
                                Tile.renderFace(tessellator, xp, yp, zp, 0, tex);
                            if (!this.level.isTile(xp + 1, yp, zp))
                                Tile.renderFace(tessellator, xp, yp, zp, 5, tex);
                            if (!this.level.isTile(xp - 1, yp, zp))
                                Tile.renderFace(tessellator, xp, yp, zp, 4, tex);
                            if (!this.level.isTile(xp, yp, zp + 1))
                                Tile.renderFace(tessellator, xp, yp, zp, 3, tex);
                            if (!this.level.isTile(xp, yp, zp - 1))
                                Tile.renderFace(tessellator, xp, yp, zp, 2, tex);
                        }
                    }
                }
            }
            tessellator.flush();
            GL11.glEndList();
            tessellator.destroy();
            isBuilded = true;
        }

        public void rebuild(uint layer) {
            isBuilded = false;
            build(layer);
        }

        public void draw(uint layer) {
            if (!isBuilded) {
                build(layer);
            }
            GL11.glCallList(this.lists + layer);
        }

        public float distanceSqr(float _x, float _y, float _z) {
            float xd = _x - (x + (x1)) / 2.0F;
            float yd = _y - (y + (y1)) / 2.0F;
            float zd = _z - (z + (z1)) / 2.0F;
            return xd * xd + yd * yd + zd * zd;
        }
    }
}
