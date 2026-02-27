// by Vova43 / vova436612
namespace phys.vector {
    [System.Serializable]
    public abstract class Vector: ReadableVector {
        public abstract float lengthSquared();
        public abstract Vector load(float[] paramfloat);
        public abstract Vector negate();

        public float length() {
            return (float)System.Math.Sqrt(lengthSquared());
        }

        public Vector normalise() {
            float len = length();
            if (len != 0.0F) {
                float l = 1.0F / len;
                return scale(l);
            }
            throw new System.InvalidOperationException("Zero length vector");
        }

        public abstract Vector store(float[] paramfloat);

        public abstract Vector scale(float paramFloat);
    }
}