namespace phys.vector {
    public class MatrixUtils {
        public static Matrix4f view(float x, float y, float width, float height, Matrix4f src) {
            src.m00 = width / 2;
            src.m11 = height / 2;
            src.m03 = (x + width) / 2;
            src.m13 = (y + height) / 2;
            return src;
        }

        public static Matrix4f ortho(float left, float right, float bottom, float top, float near, float far, Matrix4f src) {
            src.m00 = 2 / (right - left);
            src.m11 = 2 / (top - bottom);
            src.m22 = -2 / (far - near);
            src.m30 = -(right + left) / (right - left);
            src.m31 = -(top + bottom) / (top - bottom);
            src.m32 = -(far + near) / (far - near);
            return src;
        }

        public static Matrix4f frustum(float left, float right, float botton, float top, float near, float far, Matrix4f src) {
            src.m00 = 2 * near / (right - left);
            src.m11 = 2 * near / (top - botton);
            src.m20 = (right + left) / (right - left);
            src.m21 = (top + botton) / (top - botton);
            src.m22 = -(far + near) / (far - near);
            src.m23 = -1;
            src.m32 = -2 * far * near / (far - near);
            src.m33 = 0;
            return src;
        }

        public static Matrix4f projection(float fovyRadians, float aspect, float zNear, float zFar, Matrix4f src) {
            float deltaZ = zFar - zNear;
            float sine = (float)System.Math.Sin(fovyRadians); 
            float cotangent = (float)System.Math.Cos(fovyRadians) / sine;
            if ((deltaZ == 0) || (sine == 0) || (aspect == 0)) {
                return src;
            }
            src.m00 = cotangent / aspect;         //  0 * 4 + 0
            src.m11 = cotangent;                  //  1 * 4 + 1
            src.m22 = -(zFar + zNear) / deltaZ;   //  2 * 4 + 2
            src.m32 = -2 * zNear * zFar / deltaZ; //  3 * 4 + 2
            src.m23 = -1;                         //  2 * 4 + 3
            src.m33 = 0;                          //  3 * 4 + 3
            return src;
        }
    }
}
