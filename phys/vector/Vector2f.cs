// by Vova43 / vova436612
namespace phys.vector {
    [System.Serializable]
    public class Vector2f: Vector, ReadableVector2f, WritableVector2f {
        public float x;
        public float y;

        public Vector2f() { }

        public Vector2f(ReadableVector2f src) {
            set(src);
        }

        public Vector2f(float x, float y) {
            set(x, y);
        }

        public void set(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public Vector2f set(ReadableVector2f src) {
            this.x = src.getX();
            this.y = src.getY();
            return this;
        }

        public override float lengthSquared() {
            return this.x * this.x + this.y * this.y;
        }

        public Vector2f translate(float x, float y) {
            this.x += x;
            this.y += y;
            return this;
        }

        public override Vector negate() {
            this.x = -this.x;
            this.y = -this.y;
            return this;
        }

        public Vector2f negate(Vector2f dest) {
            if (dest == null)
                dest = new Vector2f();
            dest.x = -this.x;
            dest.y = -this.y;
            return dest;
        }

        public Vector2f normalise(Vector2f dest) {
            float l = length();
            if (dest == null) {
                dest = new Vector2f(this.x / l, this.y / l);
            } else {
                dest.set(this.x / l, this.y / l);
            }
            return dest;
        }

        public static float dot(Vector2f left, Vector2f right) {
            return left.x * right.x + left.y * right.y;
        }

        public static float angle(Vector2f a, Vector2f b) {
            float dls = dot(a, b) / a.length() * b.length();
            if (dls < -1.0F) {
                dls = -1.0F;
            } else if (dls > 1.0F) {
                dls = 1.0F;
            }
            return (float)System.Math.Acos(dls);
        }

        public static Vector2f add(Vector2f left, Vector2f right, Vector2f dest) {
            if (dest == null)
                return new Vector2f(left.x + right.x, left.y + right.y);
            dest.set(left.x + right.x, left.y + right.y);
            return dest;
        }

        public static Vector2f sub(Vector2f left, Vector2f right, Vector2f dest) {
            if (dest == null)
                return new Vector2f(left.x - right.x, left.y - right.y);
            dest.set(left.x - right.x, left.y - right.y);
            return dest;
        }

        public override Vector store(float[] buf) {
            buf[0] = (this.x);
            buf[1] = (this.y);
            return this;
        }

        public override Vector load(float[] buf) {
            this.x = buf[0];
            this.y = buf[1];
            return this;
        }

        public override Vector scale(float scale) {
            this.x *= scale;
            this.y *= scale;
            return this;
        }

        public string toString() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(64);
            sb.Append("Vector2f[");
            sb.Append(this.x);
            sb.Append(", ");
            sb.Append(this.y);
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

        public bool equals(System.Object obj) {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Vector2f other = (Vector2f)obj;
            if (this.x == other.x && this.y == other.y)
                return true;
            return false;
        }
    }
}