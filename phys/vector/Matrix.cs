// by Vova43 / vova436612
namespace phys.vector {
    [System.Serializable]
    public abstract class Matrix {
        public abstract Matrix setIdentity();
        public abstract Matrix invert();
        public abstract Matrix load(float[] paramfloat);
        public abstract Matrix loadTranspose(float[] paramfloat);
        public abstract Matrix negate();
        public abstract Matrix store(float[] paramfloat);
        public abstract Matrix storeTranspose(float[] paramfloat);
        public abstract Matrix transpose();
        public abstract Matrix setZero();
        public abstract float determinant();
    }
}