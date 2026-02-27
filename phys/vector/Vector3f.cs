// by Vova43 / vova436612
namespace phys.vector {
    [System.Serializable]
    public class Vector3f: Vector, ReadableVector3f, WritableVector3f {
        public float x;
        public float y;
        public float z;

        public Vector3f() { }

        public Vector3f(ReadableVector3f src) {
            set(src);
        }

        public Vector3f(float x, float y, float z) {
            set(x, y, z);
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

        public Vector3f set(ReadableVector3f src) {
            this.x = src.getX();
            this.y = src.getY();
            this.z = src.getZ();
            return this;
        }

        public override float lengthSquared() {
            return this.x * this.x + this.y * this.y + this.z * this.z;
        }

        public Vector3f translate(float x, float y, float z) {
            this.x += x;
            this.y += y;
            this.z += z;
            return this;
        }

        public static Vector3f add(Vector3f left, Vector3f right, Vector3f dest) {
            if (dest == null)
                return new Vector3f(left.x + right.x, left.y + right.y, left.z + right.z);
            dest.set(left.x + right.x, left.y + right.y, left.z + right.z);
            return dest;
        }

        public static Vector3f sub(Vector3f left, Vector3f right, Vector3f dest) {
            if (dest == null)
                return new Vector3f(left.x - right.x, left.y - right.y, left.z - right.z);
            dest.set(left.x - right.x, left.y - right.y, left.z - right.z);
            return dest;
        }

        public static Vector3f cross(Vector3f left, Vector3f right, Vector3f dest) {
            if (dest == null)
                dest = new Vector3f();
            dest.set(left.y * right.z - left.z * right.y, right.x * left.z - right.z * left.x, left.x * right.y - left.y * right.x);
            return dest;
        }

        public override Vector negate() {
            this.x = -this.x;
            this.y = -this.y;
            this.z = -this.z;
            return this;
        }

        public Vector3f negate(Vector3f dest) {
            if (dest == null)
                dest = new Vector3f();
            dest.x = -this.x;
            dest.y = -this.y;
            dest.z = -this.z;
            return dest;
        }

        public Vector3f normalise(Vector3f dest) {
            float l = length();
            if (dest == null) {
                dest = new Vector3f(this.x / l, this.y / l, this.z / l);
            } else {
                dest.set(this.x / l, this.y / l, this.z / l);
            }
            return dest;
        }

        public static float dot(Vector3f left, Vector3f right) {
            return left.x * right.x + left.y * right.y + left.z * right.z;
        }

        public static float angle(Vector3f a, Vector3f b) {
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
            return this;
        }

        public override Vector scale(float scale) {
            this.x *= scale;
            this.y *= scale;
            this.z *= scale;
            return this;
        }

        public override Vector store(float[] buf) {
            buf[0] = (this.x);
            buf[1] = (this.y);
            buf[2] = (this.z);
            return this;
        }

        public string toString() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(64);
            sb.Append("Vector3f[");
            sb.Append(this.x);
            sb.Append(", ");
            sb.Append(this.y);
            sb.Append(", ");
            sb.Append(this.z);
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

        public bool equals(System.Object obj) {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Vector3f other = (Vector3f)obj;
            if (this.x == other.x && this.y == other.y && this.z == other.z)
                return true;
            return false;
        }
    }
}