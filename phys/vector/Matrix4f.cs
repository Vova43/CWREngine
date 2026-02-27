// by Vova43 / vova436612
namespace phys.vector {
    [System.Serializable]
    public class Matrix4f: Matrix {
        public float m00;
        public float m01;
        public float m02;
        public float m03;
        public float m10;
        public float m11;
        public float m12;
        public float m13;
        public float m20;
        public float m21;
        public float m22;
        public float m23;
        public float m30;
        public float m31;
        public float m32;
        public float m33;

        public Matrix4f() {
            setIdentity();
        }

        public Matrix4f(Matrix4f src) {
            load(src);
        }

        public string toString() {
            System.Text.StringBuilder buf = new System.Text.StringBuilder();
            buf.Append(this.m00).Append(' ').Append(this.m10).Append(' ').Append(this.m20).Append(' ').Append(this.m30)
                    .Append('\n');
            buf.Append(this.m01).Append(' ').Append(this.m11).Append(' ').Append(this.m21).Append(' ').Append(this.m31)
                    .Append('\n');
            buf.Append(this.m02).Append(' ').Append(this.m12).Append(' ').Append(this.m22).Append(' ').Append(this.m32)
                    .Append('\n');
            buf.Append(this.m03).Append(' ').Append(this.m13).Append(' ').Append(this.m23).Append(' ').Append(this.m33)
                    .Append('\n');
            return buf.ToString();
        }

        public string toStringName() {
            System.Text.StringBuilder buf = new System.Text.StringBuilder();
            buf.Append("m00: " + this.m00).Append(' ').Append("m10: " + this.m10).Append(' ').Append("m20: " + this.m20).Append(' ').Append("m30: " + this.m30)
                    .Append('\n');
            buf.Append("m01: " + this.m01).Append(' ').Append("m11: " + this.m11).Append(' ').Append("m21: " + this.m21).Append(' ').Append("m31: " + this.m31)
                    .Append('\n');
            buf.Append("m02: " + this.m02).Append(' ').Append("m12: " + this.m12).Append(' ').Append("m22: " + this.m22).Append(' ').Append("m32: " + this.m32)
                    .Append('\n');
            buf.Append("m03: " + this.m03).Append(' ').Append("m13: " + this.m13).Append(' ').Append("m23: " + this.m23).Append(' ').Append("m33: " + this.m33)
                    .Append('\n');
            return buf.ToString();
        }

        public override Matrix setIdentity() {
            return setIdentity(this);
        }

        public static Matrix4f setIdentity(Matrix4f m) {
            m.m00 = 1.0F;
            m.m01 = 0.0F;
            m.m02 = 0.0F;
            m.m03 = 0.0F;
            m.m10 = 0.0F;
            m.m11 = 1.0F;
            m.m12 = 0.0F;
            m.m13 = 0.0F;
            m.m20 = 0.0F;
            m.m21 = 0.0F;
            m.m22 = 1.0F;
            m.m23 = 0.0F;
            m.m30 = 0.0F;
            m.m31 = 0.0F;
            m.m32 = 0.0F;
            m.m33 = 1.0F;
            return m;
        }

        public override Matrix setZero() {
            return setZero(this);
        }

        public static Matrix4f setZero(Matrix4f m) {
            m.m00 = 0.0F;
            m.m01 = 0.0F;
            m.m02 = 0.0F;
            m.m03 = 0.0F;
            m.m10 = 0.0F;
            m.m11 = 0.0F;
            m.m12 = 0.0F;
            m.m13 = 0.0F;
            m.m20 = 0.0F;
            m.m21 = 0.0F;
            m.m22 = 0.0F;
            m.m23 = 0.0F;
            m.m30 = 0.0F;
            m.m31 = 0.0F;
            m.m32 = 0.0F;
            m.m33 = 0.0F;
            return m;
        }

        public Matrix4f load(Matrix4f src) {
            return load(src, this);
        }

        public static Matrix4f load(Matrix4f src, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            dest.m00 = src.m00;
            dest.m01 = src.m01;
            dest.m02 = src.m02;
            dest.m03 = src.m03;
            dest.m10 = src.m10;
            dest.m11 = src.m11;
            dest.m12 = src.m12;
            dest.m13 = src.m13;
            dest.m20 = src.m20;
            dest.m21 = src.m21;
            dest.m22 = src.m22;
            dest.m23 = src.m23;
            dest.m30 = src.m30;
            dest.m31 = src.m31;
            dest.m32 = src.m32;
            dest.m33 = src.m33;
            return dest;
        }

        public override Matrix load(float[] buf) {
            this.m00 = buf[0];
            this.m01 = buf[1];
            this.m02 = buf[2];
            this.m03 = buf[3];
            this.m10 = buf[4];
            this.m11 = buf[5];
            this.m12 = buf[6];
            this.m13 = buf[7];
            this.m20 = buf[8];
            this.m21 = buf[9];
            this.m22 = buf[10];
            this.m23 = buf[11];
            this.m30 = buf[12];
            this.m31 = buf[13];
            this.m32 = buf[14];
            this.m33 = buf[15];
            return this;
        }

        public override Matrix loadTranspose(float[] buf) {
            this.m00 = buf[0];
            this.m10 = buf[1];
            this.m20 = buf[2];
            this.m30 = buf[3];
            this.m01 = buf[4];
            this.m11 = buf[5];
            this.m21 = buf[6];
            this.m31 = buf[7];
            this.m02 = buf[8];
            this.m12 = buf[9];
            this.m22 = buf[10];
            this.m32 = buf[11];
            this.m03 = buf[12];
            this.m13 = buf[13];
            this.m23 = buf[14];
            this.m33 = buf[15];
            return this;
        }

        public override Matrix store(float[] buf) {
            buf[0] = (this.m00);
            buf[1] = (this.m01);
            buf[2] = (this.m02);
            buf[3] = (this.m03);
            buf[4] = (this.m10);
            buf[5] = (this.m11);
            buf[6] = (this.m12);
            buf[7] = (this.m13);
            buf[8] = (this.m20);
            buf[9] = (this.m21);
            buf[10] = (this.m22);
            buf[11] = (this.m23);
            buf[12] = (this.m30);
            buf[13] = (this.m31);
            buf[14] = (this.m32);
            buf[15] = (this.m33);
            return this;
        }

        public override Matrix storeTranspose(float[] buf) {
            buf[0] = (this.m00);
            buf[1] = (this.m10);
            buf[2] = (this.m20);
            buf[3] = (this.m30);
            buf[4] = (this.m01);
            buf[5] = (this.m11);
            buf[6] = (this.m21);
            buf[7] = (this.m31);
            buf[8] = (this.m02);
            buf[9] = (this.m12);
            buf[10] = (this.m22);
            buf[11] = (this.m32);
            buf[12] = (this.m03);
            buf[13] = (this.m13);
            buf[14] = (this.m23);
            buf[15] = (this.m33);
            return this;
        }

        public Matrix store3f(float[] buf) {
            buf[0] = (this.m00);
            buf[1] = (this.m01);
            buf[2] = (this.m02);
            buf[3] = (this.m10);
            buf[4] = (this.m11);
            buf[5] = (this.m12);
            buf[6] = (this.m20);
            buf[7] = (this.m21);
            buf[8] = (this.m22);
            return this;
        }

        public static Matrix4f add(Matrix4f left, Matrix4f right, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            left.m00 += right.m00;
            left.m01 += right.m01;
            left.m02 += right.m02;
            left.m03 += right.m03;
            left.m10 += right.m10;
            left.m11 += right.m11;
            left.m12 += right.m12;
            left.m13 += right.m13;
            left.m20 += right.m20;
            left.m21 += right.m21;
            left.m22 += right.m22;
            left.m23 += right.m23;
            left.m30 += right.m30;
            left.m31 += right.m31;
            left.m32 += right.m32;
            left.m33 += right.m33;
            return dest;
        }

        public static Matrix4f sub(Matrix4f left, Matrix4f right, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            left.m00 -= right.m00;
            left.m01 -= right.m01;
            left.m02 -= right.m02;
            left.m03 -= right.m03;
            left.m10 -= right.m10;
            left.m11 -= right.m11;
            left.m12 -= right.m12;
            left.m13 -= right.m13;
            left.m20 -= right.m20;
            left.m21 -= right.m21;
            left.m22 -= right.m22;
            left.m23 -= right.m23;
            left.m30 -= right.m30;
            left.m31 -= right.m31;
            left.m32 -= right.m32;
            left.m33 -= right.m33;
            return dest;
        }

        public static Matrix4f mul(Matrix4f left, Matrix4f right, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            float m00 = left.m00 * right.m00 + left.m10 * right.m01 + left.m20 * right.m02 + left.m30 * right.m03;
            float m01 = left.m01 * right.m00 + left.m11 * right.m01 + left.m21 * right.m02 + left.m31 * right.m03;
            float m02 = left.m02 * right.m00 + left.m12 * right.m01 + left.m22 * right.m02 + left.m32 * right.m03;
            float m03 = left.m03 * right.m00 + left.m13 * right.m01 + left.m23 * right.m02 + left.m33 * right.m03;
            float m10 = left.m00 * right.m10 + left.m10 * right.m11 + left.m20 * right.m12 + left.m30 * right.m13;
            float m11 = left.m01 * right.m10 + left.m11 * right.m11 + left.m21 * right.m12 + left.m31 * right.m13;
            float m12 = left.m02 * right.m10 + left.m12 * right.m11 + left.m22 * right.m12 + left.m32 * right.m13;
            float m13 = left.m03 * right.m10 + left.m13 * right.m11 + left.m23 * right.m12 + left.m33 * right.m13;
            float m20 = left.m00 * right.m20 + left.m10 * right.m21 + left.m20 * right.m22 + left.m30 * right.m23;
            float m21 = left.m01 * right.m20 + left.m11 * right.m21 + left.m21 * right.m22 + left.m31 * right.m23;
            float m22 = left.m02 * right.m20 + left.m12 * right.m21 + left.m22 * right.m22 + left.m32 * right.m23;
            float m23 = left.m03 * right.m20 + left.m13 * right.m21 + left.m23 * right.m22 + left.m33 * right.m23;
            float m30 = left.m00 * right.m30 + left.m10 * right.m31 + left.m20 * right.m32 + left.m30 * right.m33;
            float m31 = left.m01 * right.m30 + left.m11 * right.m31 + left.m21 * right.m32 + left.m31 * right.m33;
            float m32 = left.m02 * right.m30 + left.m12 * right.m31 + left.m22 * right.m32 + left.m32 * right.m33;
            float m33 = left.m03 * right.m30 + left.m13 * right.m31 + left.m23 * right.m32 + left.m33 * right.m33;
            dest.m00 = m00;
            dest.m01 = m01;
            dest.m02 = m02;
            dest.m03 = m03;
            dest.m10 = m10;
            dest.m11 = m11;
            dest.m12 = m12;
            dest.m13 = m13;
            dest.m20 = m20;
            dest.m21 = m21;
            dest.m22 = m22;
            dest.m23 = m23;
            dest.m30 = m30;
            dest.m31 = m31;
            dest.m32 = m32;
            dest.m33 = m33;
            return dest;
        }

        public Matrix4f mul(Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();

            float m00 = this.m00 * dest.m00 + this.m10 * dest.m01 + this.m20 * dest.m02 + this.m30 * dest.m03;
            float m01 = this.m01 * dest.m00 + this.m11 * dest.m01 + this.m21 * dest.m02 + this.m31 * dest.m03;
            float m02 = this.m02 * dest.m00 + this.m12 * dest.m01 + this.m22 * dest.m02 + this.m32 * dest.m03;
            float m03 = this.m03 * dest.m00 + this.m13 * dest.m01 + this.m23 * dest.m02 + this.m33 * dest.m03;
            float m10 = this.m00 * dest.m10 + this.m10 * dest.m11 + this.m20 * dest.m12 + this.m30 * dest.m13;
            float m11 = this.m01 * dest.m10 + this.m11 * dest.m11 + this.m21 * dest.m12 + this.m31 * dest.m13;
            float m12 = this.m02 * dest.m10 + this.m12 * dest.m11 + this.m22 * dest.m12 + this.m32 * dest.m13;
            float m13 = this.m03 * dest.m10 + this.m13 * dest.m11 + this.m23 * dest.m12 + this.m33 * dest.m13;
            float m20 = this.m00 * dest.m20 + this.m10 * dest.m21 + this.m20 * dest.m22 + this.m30 * dest.m23;
            float m21 = this.m01 * dest.m20 + this.m11 * dest.m21 + this.m21 * dest.m22 + this.m31 * dest.m23;
            float m22 = this.m02 * dest.m20 + this.m12 * dest.m21 + this.m22 * dest.m22 + this.m32 * dest.m23;
            float m23 = this.m03 * dest.m20 + this.m13 * dest.m21 + this.m23 * dest.m22 + this.m33 * dest.m23;
            float m30 = this.m00 * dest.m30 + this.m10 * dest.m31 + this.m20 * dest.m32 + this.m30 * dest.m33;
            float m31 = this.m01 * dest.m30 + this.m11 * dest.m31 + this.m21 * dest.m32 + this.m31 * dest.m33;
            float m32 = this.m02 * dest.m30 + this.m12 * dest.m31 + this.m22 * dest.m32 + this.m32 * dest.m33;
            float m33 = this.m03 * dest.m30 + this.m13 * dest.m31 + this.m23 * dest.m32 + this.m33 * dest.m33;

            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;

            return this;
        }


        public static Vector4f transform(Matrix4f left, Vector4f right, Vector4f dest) {
            if (dest == null)
                dest = new Vector4f();
            float x = left.m00 * right.x + left.m10 * right.y + left.m20 * right.z + left.m30 * right.w;
            float y = left.m01 * right.x + left.m11 * right.y + left.m21 * right.z + left.m31 * right.w;
            float z = left.m02 * right.x + left.m12 * right.y + left.m22 * right.z + left.m32 * right.w;
            float w = left.m03 * right.x + left.m13 * right.y + left.m23 * right.z + left.m33 * right.w;
            dest.x = x;
            dest.y = y;
            dest.z = z;
            dest.w = w;
            return dest;
        }

        public override Matrix transpose() {
            return transpose(this);
        }

        public Matrix4f translate(Vector2f vec) {
            return translate(vec, this);
        }

        public Matrix4f translate(Vector3f vec) {
            return translate(vec, this);
        }

        public Matrix4f scale(Vector3f vec) {
            return scale(vec, this, this);
        }

        public static Matrix4f scale(Vector3f vec, Matrix4f src, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            src.m00 *= vec.x;
            src.m01 *= vec.x;
            src.m02 *= vec.x;
            src.m03 *= vec.x;
            src.m10 *= vec.y;
            src.m11 *= vec.y;
            src.m12 *= vec.y;
            src.m13 *= vec.y;
            src.m20 *= vec.z;
            src.m21 *= vec.z;
            src.m22 *= vec.z;
            src.m23 *= vec.z;
            return dest;
        }

        public Matrix4f rotate(float angle, Vector3f axis) {
            return rotate(angle, axis, this);
        }

        public Matrix4f rotate(float angle, Vector3f axis, Matrix4f dest) {
            return rotate(angle, axis, this, dest);
        }

        //public static Matrix4f rotate(float angle, Vector3f axis, Matrix4f src, Matrix4f dest) {
        //    if (dest == null)
        //        dest = new Matrix4f();
        //    float c = (float)System.Math.Cos(angle);
        //    float s = (float)System.Math.Sin(angle);
        //    float oneminusc = 1.0F - c;
        //    float xy = axis.x * axis.y;
        //    float yz = axis.y * axis.z;
        //    float xz = axis.x * axis.z;
        //    float xs = axis.x * s;
        //    float ys = axis.y * s;
        //    float zs = axis.z * s;
        //    float f00 = axis.x * axis.x * oneminusc + c;
        //    float f01 = xy * oneminusc + zs;
        //    float f02 = xz * oneminusc - ys;
        //    float f10 = xy * oneminusc - zs;
        //    float f11 = axis.y * axis.y * oneminusc + c;
        //    float f12 = yz * oneminusc + xs;
        //    float f20 = xz * oneminusc + ys;
        //    float f21 = yz * oneminusc - xs;
        //    float f22 = axis.z * axis.z * oneminusc + c;
        //    float t00 = src.m00 * f00 + src.m10 * f01 + src.m20 * f02;
        //    float t01 = src.m01 * f00 + src.m11 * f01 + src.m21 * f02;
        //    float t02 = src.m02 * f00 + src.m12 * f01 + src.m22 * f02;
        //    float t03 = src.m03 * f00 + src.m13 * f01 + src.m23 * f02;
        //    float t10 = src.m00 * f10 + src.m10 * f11 + src.m20 * f12;
        //    float t11 = src.m01 * f10 + src.m11 * f11 + src.m21 * f12;
        //    float t12 = src.m02 * f10 + src.m12 * f11 + src.m22 * f12;
        //    float t13 = src.m03 * f10 + src.m13 * f11 + src.m23 * f12;
        //    dest.m20 = src.m00 * f20 + src.m10 * f21 + src.m20 * f22;
        //    dest.m21 = src.m01 * f20 + src.m11 * f21 + src.m21 * f22;
        //    dest.m22 = src.m02 * f20 + src.m12 * f21 + src.m22 * f22;
        //    dest.m23 = src.m03 * f20 + src.m13 * f21 + src.m23 * f22;
        //    dest.m00 = t00;
        //    dest.m01 = t01;
        //    dest.m02 = t02;
        //    dest.m03 = t03;
        //    dest.m10 = t10;
        //    dest.m11 = t11;
        //    dest.m12 = t12;
        //    dest.m13 = t13;
        //    return dest;
        //}

        public static Matrix4f rotate(float angle, Vector3f axis, Matrix4f src, Matrix4f dest) {
            return rotate(angle, axis.x, axis.y, axis.z, src, dest);
        }

        public static Matrix4f rotate(float angle, float x, float y, float z, Matrix4f src, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            float c = (float)System.Math.Cos(angle);
            float s = (float)System.Math.Sin(angle);
            float oneminusc = 1.0F - c;
            float xy = x * y;
            float yz = y * z;
            float xz = x * z;
            float xs = x * s;
            float ys = y * s;
            float zs = z * s;
            float f00 = x * x * oneminusc + c;
            float f01 = xy * oneminusc + zs;
            float f02 = xz * oneminusc - ys;
            float f10 = xy * oneminusc - zs;
            float f11 = y * y * oneminusc + c;
            float f12 = yz * oneminusc + xs;
            float f20 = xz * oneminusc + ys;
            float f21 = yz * oneminusc - xs;
            float f22 = z * z * oneminusc + c;
            float t00 = src.m00 * f00 + src.m10 * f01 + src.m20 * f02;
            float t01 = src.m01 * f00 + src.m11 * f01 + src.m21 * f02;
            float t02 = src.m02 * f00 + src.m12 * f01 + src.m22 * f02;
            float t03 = src.m03 * f00 + src.m13 * f01 + src.m23 * f02;
            float t10 = src.m00 * f10 + src.m10 * f11 + src.m20 * f12;
            float t11 = src.m01 * f10 + src.m11 * f11 + src.m21 * f12;
            float t12 = src.m02 * f10 + src.m12 * f11 + src.m22 * f12;
            float t13 = src.m03 * f10 + src.m13 * f11 + src.m23 * f12;
            dest.m20 = src.m00 * f20 + src.m10 * f21 + src.m20 * f22;
            dest.m21 = src.m01 * f20 + src.m11 * f21 + src.m21 * f22;
            dest.m22 = src.m02 * f20 + src.m12 * f21 + src.m22 * f22;
            dest.m23 = src.m03 * f20 + src.m13 * f21 + src.m23 * f22;
            dest.m00 = t00;
            dest.m01 = t01;
            dest.m02 = t02;
            dest.m03 = t03;
            dest.m10 = t10;
            dest.m11 = t11;
            dest.m12 = t12;
            dest.m13 = t13;
            return dest;
        }

        public Matrix4f translate(Vector3f vec, Matrix4f dest) {
            return translate(vec, this, dest);
        }

        //public static Matrix4f translate(Vector3f vec, Matrix4f src, Matrix4f dest) {
        //    if (dest == null)
        //        dest = new Matrix4f();
        //    dest.m30 += src.m00 * vec.x + src.m10 * vec.y + src.m20 * vec.z;
        //    dest.m31 += src.m01 * vec.x + src.m11 * vec.y + src.m21 * vec.z;
        //    dest.m32 += src.m02 * vec.x + src.m12 * vec.y + src.m22 * vec.z;
        //    dest.m33 += src.m03 * vec.x + src.m13 * vec.y + src.m23 * vec.z;
        //    return dest;
        //}

        public static Matrix4f translate(Vector3f vec, Matrix4f src, Matrix4f dest) {
            return translate(vec.x, vec.y, vec.z, src, dest);
        }

        public static Matrix4f translate(float x, float y, float z, Matrix4f src, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            dest.m30 += src.m00 * x + src.m10 * y + src.m20 * z;
            dest.m31 += src.m01 * x + src.m11 * y + src.m21 * z;
            dest.m32 += src.m02 * x + src.m12 * y + src.m22 * z;
            dest.m33 += src.m03 * x + src.m13 * y + src.m23 * z;
            return dest;
        }

        public Matrix4f translate(Vector2f vec, Matrix4f dest) {
            return translate(vec, this, dest);
        }

        public static Matrix4f translate(Vector2f vec, Matrix4f src, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            dest.m30 += src.m00 * vec.x + src.m10 * vec.y;
            dest.m31 += src.m01 * vec.x + src.m11 * vec.y;
            dest.m32 += src.m02 * vec.x + src.m12 * vec.y;
            dest.m33 += src.m03 * vec.x + src.m13 * vec.y;
            return dest;
        }

        public Matrix4f transpose(Matrix4f dest) {
            return transpose(this, dest);
        }

        public static Matrix4f transpose(Matrix4f src, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            float m00 = src.m00;
            float m01 = src.m10;
            float m02 = src.m20;
            float m03 = src.m30;
            float m10 = src.m01;
            float m11 = src.m11;
            float m12 = src.m21;
            float m13 = src.m31;
            float m20 = src.m02;
            float m21 = src.m12;
            float m22 = src.m22;
            float m23 = src.m32;
            float m30 = src.m03;
            float m31 = src.m13;
            float m32 = src.m23;
            float m33 = src.m33;
            dest.m00 = m00;
            dest.m01 = m01;
            dest.m02 = m02;
            dest.m03 = m03;
            dest.m10 = m10;
            dest.m11 = m11;
            dest.m12 = m12;
            dest.m13 = m13;
            dest.m20 = m20;
            dest.m21 = m21;
            dest.m22 = m22;
            dest.m23 = m23;
            dest.m30 = m30;
            dest.m31 = m31;
            dest.m32 = m32;
            dest.m33 = m33;
            return dest;
        }

        public override float determinant() {
            float f = this.m00 * (this.m11 * this.m22 * this.m33 + this.m12 * this.m23 * this.m31
                    + this.m13 * this.m21 * this.m32 - this.m13 * this.m22 * this.m31 - this.m11 * this.m23 * this.m32
                    - this.m12 * this.m21 * this.m33);
            f -= this.m01 * (this.m10 * this.m22 * this.m33 + this.m12 * this.m23 * this.m30
                    + this.m13 * this.m20 * this.m32 - this.m13 * this.m22 * this.m30 - this.m10 * this.m23 * this.m32
                    - this.m12 * this.m20 * this.m33);
            f += this.m02 * (this.m10 * this.m21 * this.m33 + this.m11 * this.m23 * this.m30
                    + this.m13 * this.m20 * this.m31 - this.m13 * this.m21 * this.m30 - this.m10 * this.m23 * this.m31
                    - this.m11 * this.m20 * this.m33);
            f -= this.m03 * (this.m10 * this.m21 * this.m32 + this.m11 * this.m22 * this.m30
                    + this.m12 * this.m20 * this.m31 - this.m12 * this.m21 * this.m30 - this.m10 * this.m22 * this.m31
                    - this.m11 * this.m20 * this.m32);
            return f;
        }

        private static float determinant3x3(float t00, float t01, float t02, float t10, float t11, float t12, float t20,
                float t21, float t22) {
            return t00 * (t11 * t22 - t12 * t21) + t01 * (t12 * t20 - t10 * t22) + t02 * (t10 * t21 - t11 * t20);
        }

        public override Matrix invert() {
            return invert(this, this);
        }

        public static Matrix4f invert(Matrix4f src, Matrix4f dest) {
            float determinant = src.determinant();
            if (determinant != 0.0F) {
                if (dest == null)
                    dest = new Matrix4f();
                float determinant_inv = 1.0F / determinant;
                float t00 = determinant3x3(src.m11, src.m12, src.m13, src.m21, src.m22, src.m23, src.m31, src.m32, src.m33);
                float t01 = -determinant3x3(src.m10, src.m12, src.m13, src.m20, src.m22, src.m23, src.m30, src.m32,
                        src.m33);
                float t02 = determinant3x3(src.m10, src.m11, src.m13, src.m20, src.m21, src.m23, src.m30, src.m31, src.m33);
                float t03 = -determinant3x3(src.m10, src.m11, src.m12, src.m20, src.m21, src.m22, src.m30, src.m31,
                        src.m32);
                float t10 = -determinant3x3(src.m01, src.m02, src.m03, src.m21, src.m22, src.m23, src.m31, src.m32,
                        src.m33);
                float t11 = determinant3x3(src.m00, src.m02, src.m03, src.m20, src.m22, src.m23, src.m30, src.m32, src.m33);
                float t12 = -determinant3x3(src.m00, src.m01, src.m03, src.m20, src.m21, src.m23, src.m30, src.m31,
                        src.m33);
                float t13 = determinant3x3(src.m00, src.m01, src.m02, src.m20, src.m21, src.m22, src.m30, src.m31, src.m32);
                float t20 = determinant3x3(src.m01, src.m02, src.m03, src.m11, src.m12, src.m13, src.m31, src.m32, src.m33);
                float t21 = -determinant3x3(src.m00, src.m02, src.m03, src.m10, src.m12, src.m13, src.m30, src.m32,
                        src.m33);
                float t22 = determinant3x3(src.m00, src.m01, src.m03, src.m10, src.m11, src.m13, src.m30, src.m31, src.m33);
                float t23 = -determinant3x3(src.m00, src.m01, src.m02, src.m10, src.m11, src.m12, src.m30, src.m31,
                        src.m32);
                float t30 = -determinant3x3(src.m01, src.m02, src.m03, src.m11, src.m12, src.m13, src.m21, src.m22,
                        src.m23);
                float t31 = determinant3x3(src.m00, src.m02, src.m03, src.m10, src.m12, src.m13, src.m20, src.m22, src.m23);
                float t32 = -determinant3x3(src.m00, src.m01, src.m03, src.m10, src.m11, src.m13, src.m20, src.m21,
                        src.m23);
                float t33 = determinant3x3(src.m00, src.m01, src.m02, src.m10, src.m11, src.m12, src.m20, src.m21, src.m22);
                dest.m00 = t00 * determinant_inv;
                dest.m11 = t11 * determinant_inv;
                dest.m22 = t22 * determinant_inv;
                dest.m33 = t33 * determinant_inv;
                dest.m01 = t10 * determinant_inv;
                dest.m10 = t01 * determinant_inv;
                dest.m20 = t02 * determinant_inv;
                dest.m02 = t20 * determinant_inv;
                dest.m12 = t21 * determinant_inv;
                dest.m21 = t12 * determinant_inv;
                dest.m03 = t30 * determinant_inv;
                dest.m30 = t03 * determinant_inv;
                dest.m13 = t31 * determinant_inv;
                dest.m31 = t13 * determinant_inv;
                dest.m32 = t23 * determinant_inv;
                dest.m23 = t32 * determinant_inv;
                return dest;
            }
            return null;
        }

        public override Matrix negate() {
            return negate(this);
        }

        public Matrix4f negate(Matrix4f dest) {
            return negate(this, dest);
        }

        public static Matrix4f negate(Matrix4f src, Matrix4f dest) {
            if (dest == null)
                dest = new Matrix4f();
            dest.m00 = -src.m00;
            dest.m01 = -src.m01;
            dest.m02 = -src.m02;
            dest.m03 = -src.m03;
            dest.m10 = -src.m10;
            dest.m11 = -src.m11;
            dest.m12 = -src.m12;
            dest.m13 = -src.m13;
            dest.m20 = -src.m20;
            dest.m21 = -src.m21;
            dest.m22 = -src.m22;
            dest.m23 = -src.m23;
            dest.m30 = -src.m30;
            dest.m31 = -src.m31;
            dest.m32 = -src.m32;
            dest.m33 = -src.m33;
            return dest;
        }
    }
}