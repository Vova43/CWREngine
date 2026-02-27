//======================================
//  Entity
//  Created on: 19.01.2026 0:17:27
//  Author: Vova43
//======================================
namespace tests.CubeTest {
    using level;
    using phys;
    public class Entity {
        private Level level = null;
        public float x, y, z;
        public float xo, yo, zo;
        public float xd, yd, zd;
        public float xRot, yRot;
        public bool onGround = false;
        public bool isSneaking = false;
        public bool onFly = false;
        public float width = 0.3F;
        public float height = 0.9F;

        public float defaultSpeed = 0.12F;
        public float heightOffset = 1.62F;
        public phys.AABB boundingBox;

        public Entity(Level level) {
            this.level = level;
            this.boundingBox = new AABB(x - width, y - height,
                    z - width, x + width,
                    y + height, z + width);
            resetPosition();
        }

        public void setPosition(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;

            boundingBox.x0 = x - width;
            boundingBox.y0 = y - height;
            boundingBox.z0 = z - width;

            boundingBox.x1 = x + width;
            boundingBox.y1 = y + height;
            boundingBox.z1 = z + width;
        }

        public void setSize(float w, float h) {
            width = w;
            height = h;
            boundingBox.x0 = x - width;
            boundingBox.y0 = y - height;
            boundingBox.z0 = z - width;

            boundingBox.x1 = x + width;
            boundingBox.y1 = y + height;
            boundingBox.z1 = z + width;
        }

        public void resetPosition() {
            System.Random random = new System.Random();
            float x = (float)random.NextDouble() * this.level.width;
            float y = (float)(this.level.depth + 3);
            float z = (float)random.NextDouble() * this.level.height;

            setPosition(x, y, z);
        }

        public void moveRelative(float xa, float za, float speed) {
            float dist = xa * xa + za * za;
            if (dist < 0.01F)
                return;
            dist = speed / (float)System.Math.Sqrt(dist);
            xa *= dist;
            za *= dist;
            float sin = (float)System.Math.Sin(this.yRot);
            float cos = (float)System.Math.Cos(this.yRot);
            this.xd += xa * cos - za * sin;
            this.zd += za * cos + xa * sin;
        }

        public void turn(float xr, float yr) {
            //this.yRot += x * 0.15F;
            //this.xRot -= y * 0.15F;
            yRot += (float)(xr / 260);
            xRot -= (float)(yr / 260);
            if (xRot < -1.5707f) {
                xRot = -1.5707f;
            }
            if (xRot > 1.5707f) {
                xRot = 1.5707f;
            }

            if (yRot < -6.28f) {
                yRot = 0.0f;
            }
            if (yRot > 6.28f) {
                yRot = 0.0f;
            }
        }

        public void moveRelativeV(float xa, float za) {
            //moveRelative(xa, za, this.onGround ? 0.12F : 0.03F);
            float speed = defaultSpeed;
            if (!this.onGround)
                speed /= 4;
            if (this.isSneaking)
                speed /= 3;
            moveRelative(xa, za, speed);
        }


        public void tick() {
            this.xo = this.x;
            this.yo = this.y;
            this.zo = this.z;
            if (!onFly)
                this.yd -= 0.036F;
            move(this.xd, this.yd, this.zd);
            this.xd *= 0.91F;
            this.yd *= 0.98F;
            this.zd *= 0.91F;
            if (this.onGround) {
                this.xd *= 0.75F;
                this.zd *= 0.75F;
            }
            if (onFly) {
                this.xd *= 0.01F;
                this.zd *= 0.01F;
            }
        }

        public void move(float x, float y, float z) {
            float prevX = x;
            float prevY = y;
            float prevZ = z;
            // sneak
            if (this.onGround && this.isSneaking) {
                float step = 0.05F;
                for (; x != 0.0F && this.level.getCubes(this.boundingBox.cloneMove(x, -1.0F, 0.0F)).Count == 0; prevX = x) {
                    if (x < step && x >= -step) {
                        x = 0.0F;
                        this.xd = 0.0F;
                    }
                    else if (x > 0.0F) {
                        x -= step;
                    }
                    else {
                        x += step;
                    }
                }
                for (; z != 0.0F && this.level.getCubes(this.boundingBox.cloneMove(0.0F, -1.0F, z)).Count == 0; prevZ = z) {
                    if (z < step && z >= -step) {
                        z = 0.0F;
                        this.zd = 0.0F;
                    }
                    else if (z > 0.0F) {
                        z -= step;
                    }
                    else {
                        z += step;
                    }
                }
            }

            System.Collections.Generic.List<AABB> aABBs = this.level.getCubes(this.boundingBox.expand(x, y, z));

            for (int i = 0; i < aABBs.Count; i++) {
                y = aABBs[i].clipYCollide(this.boundingBox, y);
            }

            this.boundingBox.move(0.0F, y, 0.0F);

            for (int i = 0; i < aABBs.Count; i++) {
                x = aABBs[i].clipXCollide(this.boundingBox, x);
            }
            this.boundingBox.move(x, 0.0F, 0.0F);

            for (int i = 0; i < aABBs.Count; i++) {
                z = aABBs[i].clipZCollide(this.boundingBox, z);
            }
            this.boundingBox.move(0.0F, 0.0F, z);

            this.onGround = prevY != y && prevY < 0.0F;

            if (prevX != x) this.xd = 0.0F;
            if (prevY != y) this.yd = 0.0F;
            if (prevZ != z) this.zd = 0.0F;

            this.x = (this.boundingBox.x0 + this.boundingBox.x1) / 2.0F;
            this.y = this.boundingBox.y0 + heightOffset; // this.boundingBox.y0 + 1.62F;
            this.z = (this.boundingBox.z0 + this.boundingBox.z1) / 2.0F;

            if (isSneaking)
                this.y -= 0.2F;
        }
    }
}
