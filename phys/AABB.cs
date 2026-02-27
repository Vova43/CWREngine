// by Vova43 / vova436612
namespace phys {
    /// <summary> AABB (англ. axis-aligned bounding box — «параллельный осям ограничивающий параллелепипед») <para>Данный класс содержит всё что необходимо для расчётов c параллелепипедом</para></summary>
    public class AABB {
        private float epsilon;
        public float x0;
        public float y0;
        public float z0;
        public float x1;
        public float y1;
        public float z1;

        public AABB(float x0, float y0, float z0, float x1, float y1, float z1) {
            this.epsilon = 0.0f;
            this.x0 = x0;
            this.y0 = y0;
            this.z0 = z0;
            this.x1 = x1;
            this.y1 = y1;
            this.z1 = z1;
        }

        public AABB expand(float xa, float ya, float za) {
            float _x0 = this.x0;
            float _y0 = this.y0;
            float _z0 = this.z0;
            float _x2 = this.x1;
            float _y2 = this.y1;
            float _z2 = this.z1;

            if (xa < 0.0f) {
                _x0 += xa;
            }
            if (xa > 0.0f) {
                _x2 += xa;
            }
            if (ya < 0.0f) {
                _y0 += ya;
            }
            if (ya > 0.0f) {
                _y2 += ya;
            }
            if (za < 0.0f) {
                _z0 += za;
            }
            if (za > 0.0f) {
                _z2 += za;
            }

            return new AABB(_x0, _y0, _z0, _x2, _y2, _z2);
        }

        public AABB grow(float xa, float ya, float za) {
            float _x0 = this.x0 - xa;
            float _y0 = this.y0 - ya;
            float _z0 = this.z0 - za;
            float _x2 = this.x1 + xa;
            float _y2 = this.y1 + ya;
            float _z2 = this.z1 + za;

            return new AABB(_x0, _y0, _z0, _x2, _y2, _z2);
        }

        public AABB cloneMove(float xa, float ya, float za) {
            return new AABB(this.x0 + xa, this.y0 + ya, this.z0 + za, this.x1 + xa, this.y1 + ya, this.z1 + za);
        }

        public float clipXCollide(AABB aabb, float xa) {
            if (aabb.y1 <= this.y0 || aabb.y0 >= this.y1) {
                return xa;
            }
            if (aabb.z1 <= this.z0 || aabb.z0 >= this.z1) {
                return xa;
            }
            if (xa > 0.0f && aabb.x1 <= this.x0) {
                float max = this.x0 - aabb.x1 - this.epsilon;
                if (max < xa) {
                    xa = max;
                }
            }
            if (xa < 0.0f && aabb.x0 >= this.x1) {
                float max = this.x1 - aabb.x0 + this.epsilon;
                if (max > xa) {
                    xa = max;
                }
            }
            return xa;
        }

        public float clipYCollide(AABB aabb, float ya) {
            if (aabb.x1 <= this.x0 || aabb.x0 >= this.x1) {
                return ya;
            }
            if (aabb.z1 <= this.z0 || aabb.z0 >= this.z1) {
                return ya;
            }
            if (ya > 0.0f && aabb.y1 <= this.y0) {
                float max = this.y0 - aabb.y1 - this.epsilon;
                if (max < ya) {
                    ya = max;
                }
            }
            if (ya < 0.0f && aabb.y0 >= this.y1) {
                float max = this.y1 - aabb.y0 + this.epsilon;
                if (max > ya) {
                    ya = max;
                }
            }
            return ya;
        }

        public float clipZCollide(AABB aabb, float za) {
            if (aabb.x1 <= this.x0 || aabb.x0 >= this.x1) {
                return za;
            }
            if (aabb.y1 <= this.y0 || aabb.y0 >= this.y1) {
                return za;
            }
            if (za > 0.0f && aabb.z1 <= this.z0) {
                float max = this.z0 - aabb.z1 - this.epsilon;
                if (max < za) {
                    za = max;
                }
            }
            if (za < 0.0f && aabb.z0 >= this.z1) {
                float max = this.z1 - aabb.z0 + this.epsilon;
                if (max > za) {
                    za = max;
                }
            }
            return za;
        }

        public bool intersects(AABB aabb) {
            return aabb.x1 > this.x0 && aabb.x0 < this.x1 && aabb.y1 > this.y0 && aabb.y0 < this.y1 && aabb.z1 > this.z0 && aabb.z0 < this.z1;
        }

        public bool intersectsV(AABB other) {
            if (other.x1 <= this.x0 || other.x0 >= this.x1) return false;
            if (other.y1 <= this.y0 || other.y0 >= this.y1) return false;
            if (other.z1 <= this.z0 || other.z0 >= this.z1) return false;
            return true;
        }

        public void move(float xa, float ya, float za) {
            this.x0 += xa;
            this.y0 += ya;
            this.z0 += za;
            this.x1 += xa;
            this.y1 += ya;
            this.z1 += za;
        }
    }
}