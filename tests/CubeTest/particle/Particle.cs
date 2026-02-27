//======================================
//  Particle
//  Created on: 19.01.2026 0:38:33
//  Author: Vova43
//======================================
namespace tests.CubeTest.particle {
    using level;
    using renderer;
    public class Particle : Entity {
        private float xd = 0;
        private float yd = 0;
        private float zd = 0;
        private int age = 0;
        public int tex = 0;
        private float uo = 0;
        private float vo = 0;
        private int lifetime = 0;
        private float size = 0;
        public bool removed = false;

        public Particle(Level level, float x, float y, float z, float xa, float ya, float za, int tex): base(level) {
            this.tex = tex;
            setSize(0.2F, 0.2F);
            this.heightOffset = this.height / 2.0F;
            setPosition(x, y, z);
            System.Random random = new System.Random();
            this.xd = xa + (float)(random.NextDouble() * 2.0D - 1.0D) * 0.4F;
            this.yd = ya + (float)(random.NextDouble() * 2.0D - 1.0D) * 0.4F;
            this.zd = za + (float)(random.NextDouble() * 2.0D - 1.0D) * 0.4F;
            float speed = (float)(random.NextDouble() + random.NextDouble() + 1.0D) * 0.15F;
            float dd = (float)System.Math.Sqrt((this.xd * this.xd + this.yd * this.yd + this.zd * this.zd));
            this.xd = this.xd / dd * speed * 0.4F;
            this.yd = this.yd / dd * speed * 0.4F + 0.1F;
            this.zd = this.zd / dd * speed * 0.4F;
            this.uo = (float)random.NextDouble() * 3.0F;
            this.vo = (float)random.NextDouble() * 3.0F;
            this.size = (float)(random.NextDouble() * 0.5D + 0.5D);
            this.lifetime = (int)(4.0D / (random.NextDouble() * 0.1D + 0.1D));//this.lifetime = (int)(4.0D / (random.NextDouble() * 0.9D + 0.1D));
            this.age = 0;
        }

        public void tick() {
            this.xo = this.x;
            this.yo = this.y;
            this.zo = this.z;
            if (this.age++ >= this.lifetime) removed = true;
            this.yd = (float)(this.yd - 0.04D);
            move(this.xd, this.yd, this.zd);
            this.xd *= 0.98F;
            this.yd *= 0.98F;
            this.zd *= 0.98F;
            if (this.onGround) {
                this.xd *= 0.7F;
                this.zd *= 0.7F;
            }
        }

        public void render(Tessellator tessellator, float fractionalTicks, float xa, float ya, float za, float xa2, float za2) {
            float u0 = ((this.tex % 16) + this.uo / 4.0F) / 16.0F;
            float u1 = u0 + 0.015609375F;
            float v0 = ((this.tex / 16) + this.vo / 4.0F) / 16.0F;
            float v1 = v0 + 0.015609375F;
            float r = 0.1F * this.size;
            float x = this.xo + (this.x - this.xo) * fractionalTicks;
            float y = this.yo + (this.y - this.yo) * fractionalTicks;
            float z = this.zo + (this.z - this.zo) * fractionalTicks;
            tessellator.vertexUV(x - xa * r - xa2 * r, y - ya * r, z - za * r - za2 * r, u0, v1);
            tessellator.vertexUV(x - xa * r + xa2 * r, y + ya * r, z - za * r + za2 * r, u0, v0);
            tessellator.vertexUV(x + xa * r + xa2 * r, y + ya * r, z + za * r + za2 * r, u1, v0);
            tessellator.vertexUV(x + xa * r - xa2 * r, y - ya * r, z + za * r - za2 * r, u1, v1);
        }
    }
}
