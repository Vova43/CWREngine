//======================================
//  ScaledResolution
//  Created on: 19.01.2026 0:33:50
//  Author: Vova43
//======================================
namespace tests.CubeTest.gui {
    /// <summary>
    /// Предназначен для поиска адаптивного разрешения экрана<para />Пример использования:
    /// <para>ScaledResolution scaledResolution = new ScaledResolution();</para>
    /// <para>scaledResolution.calculateScale(10, wind.width, wind.height, true);</para>
    /// &#9745; Простой класс
    /// </summary>
    public class ScaledResolution {
        public float scaledWidthF = 0.0F;
        public float scaledHeightF = 0.0F;
        public int scaledWidth = 0;
        public int scaledHeight = 0;
        public int scaleFactor = 0;

        public int nativeWidth = 320;
        public int nativeHeight = 240;

        private int ceilingFloatInt(float param) {
            int i = (int)param;
            if (param > (float)i)
                return i + 1;
            return i;
        }

        public void calculateScale(int guiScale, int displayWidth, int displayHeight, bool flagIsUnicode) {
            scaledWidth = displayWidth;
            scaledHeight = displayHeight;
            scaleFactor = 1;

            while (scaleFactor < guiScale && scaledWidth / (scaleFactor + 1) >= nativeWidth && scaledHeight / (scaleFactor + 1) >= nativeHeight) {
                ++scaleFactor;
            }

            if (flagIsUnicode && scaleFactor % 2 != 0 && scaleFactor != 1) {
                --scaleFactor;
            }

            scaledWidthF = (float)scaledWidth / (float)scaleFactor;
            scaledHeightF = (float)scaledHeight / (float)scaleFactor;
            scaledWidth = ceilingFloatInt(scaledWidthF);
            scaledHeight = ceilingFloatInt(scaledHeightF);
        }
    }
}
