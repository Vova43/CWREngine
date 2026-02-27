//======================================
//  ParticleEngine
//  Created on: 19.01.2026 0:40:53
//  Author: Vova43
//======================================
namespace tests.CubeTest.particle {
    using openGL;
    using level;
    using renderer;
    public class ParticleEngine {
        protected Level level;
        private System.Collections.Generic.List<Particle> particles = new System.Collections.Generic.List<Particle>();
        //private Textures textures;

        public ParticleEngine(Level level) {//, Textures textures
            this.level = level;
            //this.textures = textures;
        }

        public void add(Particle p) {
            this.particles.Add(p);
        }

        public void tick() {
            for (int i = 0; i < this.particles.Count; i++) {
                Particle p = this.particles[i];
                p.tick();
                if (p.removed) {
                    this.particles.RemoveAt(i--);
                }
            }
        }

        public void render(Entity entity, Tessellator t, float a, int layer) {
            if (this.particles.Count == 0)
                return;
            GL11.glEnable(3553);
            //int id = this.textures.loadTexture("/terrain.png", 9728);
            //GL11.glBindTexture(3553, id);
            float xa = -(float)System.Math.Cos(entity.yRot);
            float za = -(float)System.Math.Sin(entity.yRot);
            float xa2 = -za * (float)System.Math.Sin(entity.xRot);
            float za2 = xa * (float)System.Math.Sin(entity.xRot);
            float ya = (float)System.Math.Cos(entity.xRot);
            //ya = 0.1f;
            //GL11.glColor4f(0.8F, 0.8F, 0.8F, 1.0F);
            t.clear();
            t.color(0.8F, 0.8F, 0.8F, 1.0F);
            for (int i = 0; i < this.particles.Count; i++) {
                Particle p = this.particles[i];
                //if ((p.isLit() ^ ((layer == 1) ? 1 : 0)) != 0)  {
                p.render(t, a, xa, ya, za, xa2, za2);
                //}
            }
            t.flush();
            GL11.glDisable(3553);
        }
    }
}
