// by Vova43 / vova436612
namespace phys.vector {
    [System.Serializable]
    public class Vector4f: Vector, ReadableVector4f, WritableVector4f {
        public float x;
        public float y;
        public float z;
        public float w;

        public Vector4f() { }

        public Vector4f(ReadableVector4f src) {
            set(src);
        }

        public Vector4f(float x, float y, float z, float w) {
            set(x, y, z, w);
        }

        public void set(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public void set(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void set(float x, float y, float z, float w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Vector4f set(ReadableVector4f src) {
            this.x = src.getX();
            this.y = src.getY();
            this.z = src.getZ();
            this.w = src.getW();
            return this;
        }

        public override float lengthSquared() {
            return this.x * this.x + this.y * this.y + this.z * this.z + this.w * this.w;
        }

        public Vector4f translate(float x, float y, float z, float w) {
            this.x += x;
            this.y += y;
            this.z += z;
            this.w += w;
            return this;
        }

        public static Vector4f add(Vector4f left, Vector4f right, Vector4f dest) {
            if (dest == null)
                return new Vector4f(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
            dest.set(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
            return dest;
        }

        public static Vector4f sub(Vector4f left, Vector4f right, Vector4f dest) {
            if (dest == null)
                return new Vector4f(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
            dest.set(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
            return dest;
        }

        public override Vector negate() {
            this.x = -this.x;
            this.y = -this.y;
            this.z = -this.z;
            this.w = -this.w;
            return this;
        }

        public Vector4f negate(Vector4f dest) {
            if (dest == null)
                dest = new Vector4f();
            dest.x = -this.x;
            dest.y = -this.y;
            dest.z = -this.z;
            dest.w = -this.w;
            return dest;
        }

        public Vector4f normalise(Vector4f dest) {
            float l = length();
            if (dest == null) {
                dest = new Vector4f(this.x / l, this.y / l, this.z / l, this.w / l);
            } else {
                dest.set(this.x / l, this.y / l, this.z / l, this.w / l);
            }
            return dest;
        }

        public static float dot(Vector4f left, Vector4f right) {
            return left.x * right.x + left.y * right.y + left.z * right.z + left.w * right.w;
        }

        public static float angle(Vector4f a, Vector4f b) {
            float dls = dot(a, b) / a.length() * b.length();
            if (dls < -1.0F) {
                dls = -1.0F;
            } else if (dls > 1.0F) {
                dls = 1.0F;
            }
            return (float)System.Math.Acos(dls);
        }

        public override Vector load(float[] buf) {
            this.x = buf[0];
            this.y = buf[1];
            this.z = buf[2];
            this.w = buf[3];
            return this;
        }

        public override Vector scale(float scale) {
            this.x *= scale;
            this.y *= scale;
            this.z *= scale;
            this.w *= scale;
            return this;
        }

        public override Vector store(float[] buf) {
            buf[0] = (this.x);
            buf[1] = (this.y);
            buf[2] = (this.z);
            buf[3] = (this.w);
            return this;
        }

        //public string toString() {
        //    return "Vector4f: " + this.x + " " + this.y + " " + this.z + " " + this.w;
        //}

        public string toString() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(64);
            sb.Append("Vector4f[");
            sb.Append(this.x);
            sb.Append(", ");
            sb.Append(this.y);
            sb.Append(", ");
            sb.Append(this.z);
            sb.Append(", ");
            sb.Append(this.w);
            sb.Append(']');
            return sb.ToString();
        }

        public float getX() {
            return this.x;
        }

        public float getY() {
            return this.y;
        }

        public void setX(float x) {
            this.x = x;
        }

        public void setY(float y) {
            this.y = y;
        }

        public void setZ(float z) {
            this.z = z;
        }

        public float getZ() {
            return this.z;
        }

        public void setW(float w) {
            this.w = w;
        }

        public float getW() {
            return this.w;
        }

        public bool equals(System.Object obj) {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Vector4f other = (Vector4f)obj;
            if (this.x == other.x && this.y == other.y && this.z == other.z && this.w == other.w)
                return true;
            return false;
        }
    }
}