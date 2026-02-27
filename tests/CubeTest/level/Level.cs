//======================================
//  Level
//  Created on: 19.01.2026 0:22:36
//  Author: Vova43
//======================================
using phys;
namespace tests.CubeTest.level {
    public class Level {
        public int width = 0;
        public int height = 0;
        public int depth = 0;
        public byte[] blocks = null;
        public int chunkAmountX = 0;
        public int chunkAmountY = 0;
        public int chunkAmountZ = 0;
        public Chunk[] chunks = null;

        public Level(int xs, int ys, int zs) {
            width = xs;
            height = zs;
            depth = ys;
            blocks = new byte[xs * ys * zs];
            chunkAmountX = width / 16;
            chunkAmountY = depth / 16;
            chunkAmountZ = height / 16;
            chunks = new Chunk[chunkAmountX * chunkAmountY * chunkAmountZ];
        }

        public void setTile(int x, int y, int z, byte type) {
            if (x < 0 || y < 0 || z < 0 || x >= width || y >= depth || z >= height) {
                return;
            }
            this.blocks[(y * height + z) * width + x] = (byte)type;
        }

        public byte getTile(int x, int y, int z) {
            if (x < 0 || y < 0 || z < 0 || x >= width || y >= depth || z >= height) {
                return 0;
            }
            return this.blocks[(y * height + z) * width + x];
        }

        public bool isTile(int x, int y, int z) {
            if (x < 0 || y < 0 || z < 0 || x >= width || y >= depth || z >= height) {
                return false;
            }
            return this.blocks[(y * height + z) * width + x] > 0;
        }

        public void generateTiles() {
            int d = depth / 2;
            for (int y = 0; y < d; y += 1) {
                for (int x = 0; x < width; x += 1) {
                    for (int z = 0; z < height; z += 1) {
                        if (y <= d - 2) {
                            setTile(x, y, z, 2);
                        }
                        else {
                            setTile(x, y, z, 1);
                        }
                    }
                }
            }
        }

        public void generateCaves() {
            System.Random random = new System.Random();
            for (int i = 0; i < 10000; i++) {
                int caveSize = (int)(random.NextDouble() * 7) + 1;

                int caveX = (int)(random.NextDouble() * width);
                int caveY = (int)(random.NextDouble() * depth);
                int caveZ = (int)(random.NextDouble() * height);

                // Grow cave
                for (int radius = 0; radius < caveSize; radius++) {
                    for (int sphere = 0; sphere < 1000; sphere++) {
                        int offsetX = (int)(random.NextDouble() * radius * 2 - radius);
                        int offsetY = (int)(random.NextDouble() * radius * 2 - radius);
                        int offsetZ = (int)(random.NextDouble() * radius * 2 - radius);

                        // Sphere shape
                        double distance = System.Math.Pow(offsetX, 2) + System.Math.Pow(offsetY, 2) + System.Math.Pow(offsetZ, 2);
                        if (distance > radius * radius)
                            continue;

                        int tileX = caveX + offsetX;
                        int tileY = caveY + offsetY;
                        int tileZ = caveZ + offsetZ;

                        // Calculate index from x, y and z
                        int index = (tileY * this.height + tileZ) * this.width + tileX;

                        // Check if tile is out of level
                        if (index >= 0 && index < this.blocks.Length) {

                            // Border of level
                            if (tileX > 0 && tileY > 0 && tileZ > 0
                                    && tileX < this.width - 1 && tileY < this.depth && tileZ < this.height - 1) {

                                // Fill level with tiles
                                this.blocks[index] = (byte)0;
                            }
                        }
                    }
                }
            }
        }

        public void setChunk(int x, int y, int z, Chunk chunk) {
            if (x < 0 || y < 0 || z < 0 || x >= chunkAmountX || y >= chunkAmountY || z >= chunkAmountZ) {
                return;
            }
            this.chunks[(x + y * this.chunkAmountX) * this.chunkAmountZ + z] = (Chunk)chunk;
        }

        public Chunk getChunk(int x, int y, int z) {
            if (x < 0 || y < 0 || z < 0 || x >= chunkAmountX || y >= chunkAmountY || z >= chunkAmountZ) {
                return null;
            }
            return this.chunks[(x + y * this.chunkAmountX) * this.chunkAmountZ + z];
        }

        public void generateChunks() {
            for (int y = 0; y < this.chunkAmountY; y += 1) {
                for (int x = 0; x < this.chunkAmountX; x += 1) {
                    for (int z = 0; z < this.chunkAmountZ; z += 1) {
                        Chunk chunk = new Chunk(x * 16, y * 16, z * 16, this);
                        setChunk(x, y, z, chunk);
                    }
                }
            }
        }

        public void draw(float x, float y, float z) {
            Frustum frustum = Frustum.getFrustum();
            for (int i = 0; i < chunks.Length; i += 1) {
                Chunk chunk = chunks[i];
                if (chunk.distanceSqr(x, y, z) < 8192) { // 1 Chunk = 128 Sqr
                    if (frustum.cubeInFrustum(chunk.x, chunk.y, chunk.z, chunk.x1, chunk.y1, chunk.z1)) {
                        chunk.draw(0);
                    }
                }
            }
        }

        public System.Collections.Generic.List<AABB> getCubes(AABB boundingBox) {
            System.Collections.Generic.List<AABB> boundingBoxList = new System.Collections.Generic.List<AABB>();
            int minX = (int)System.Math.Floor(boundingBox.x0);
            int maxX = (int)System.Math.Floor(boundingBox.x1 + 1);
            int minY = (int)System.Math.Floor(boundingBox.y0);
            int maxY = (int)System.Math.Floor(boundingBox.y1 + 1);
            int minZ = (int)System.Math.Floor(boundingBox.z0);
            int maxZ = (int)System.Math.Floor(boundingBox.z1 + 1);
            for (int x = minX; x < maxX; x++) {
                for (int y = minY; y < maxY; y++) {
                    for (int z = minZ; z < maxZ; z++) {
                        if (isTile(x, y, z)) {
                            boundingBoxList.Add(new AABB(x, y, z, x + 1, y + 1, z + 1));
                        }
                    }
                }
            }
            return boundingBoxList;
        }

        public void setTileAt(int x, int y, int z, byte type) {
            if (x < 0 || y < 0 || z < 0 || x >= width || y >= depth || z >= height) {
                return;
            }
            this.blocks[(y * height + z) * width + x] = (byte)type;
            Chunk chunk = getChunk((x >> 4), (y >> 4), (z >> 4));
            if (chunk != null)
                chunk.isBuilded = false;
            if ((x & 0xF) == 0) {
                chunk = getChunk((x - 1 >> 4), (y >> 4), (z >> 4));
                if (chunk != null)
                    chunk.isBuilded = false;
            }

            if ((x & 0xF) == 15) {
                chunk = getChunk((x + 1 >> 4), (y >> 4), (z >> 4));
                if (chunk != null)
                    chunk.isBuilded = false;
            }

            if ((y & 0xF) == 0) {
                chunk = getChunk((x >> 4), (y - 1 >> 4), (z >> 4));
                if (chunk != null)
                    chunk.isBuilded = false;
            }

            if ((y & 0xF) == 15) {
                chunk = getChunk((x >> 4), (y + 1 >> 4), (z >> 4));
                if (chunk != null)
                    chunk.isBuilded = false;
            }

            if ((z & 0xF) == 0) {
                chunk = getChunk((x >> 4), (y >> 4), (z - 1 >> 4));
                if (chunk != null)
                    chunk.isBuilded = false;
            }

            if ((z & 0xF) == 15) {
                chunk = getChunk((x >> 4), (y >> 4), (z + 1 >> 4));
                if (chunk != null)
                    chunk.isBuilded = false;
            }
        }

        public void updateChunks() {
            for (int y = 0; y < this.chunkAmountY; y += 1) {
                for (int x = 0; x < this.chunkAmountX; x += 1) {
                    for (int z = 0; z < this.chunkAmountZ; z += 1) {
                        Chunk chunk = getChunk(x, y, z);
                        if (chunk != null)
                            chunk.isBuilded = false;
                    }
                }
            }
        }
    }
}
