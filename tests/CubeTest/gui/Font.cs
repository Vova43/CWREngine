//======================================
//  Font
//  Created on: 19.01.2026 0:31:34
//  Author: Vova43
//======================================
namespace tests.CubeTest.gui {
    /// <summary>Предназначен для рендеринга текста<para />Пример использования:<para />
    /// <para>Font font = new Font();</para>
    /// <para>font.fileFormat = "./font/unicode_page_{0:x2}.png";</para>
    /// <para>font.fileWidth = "./font/size_width.bin";</para>
    /// <para>font.fileHeight = "./font/size_height.bin";</para>
    /// <para>font.fontSize = 1.0F;</para>
    /// <para>font.italicF = 0.0F;</para>
    /// <para>font.load();</para>
    /// <para>font.setColorHex(0xffffffff);</para>
    /// <para>В цикле рендера:</para>
    /// <para>font.renderChar('A', 1, 0, 0);</para>
    /// <para>font.renderChars("utf-8 \t\n\r\0\u00a7", 1, 12, 0);</para>
    /// <para>font.renderCharsShadow("utf-8 \t\n\r\0\u00a7", 1, 24, 0, 0xffffffff);</para>
    /// <para>font.destroy(); // Если объект больше не нужен уничтожить его можно вызвав метод destroy</para>
    /// </summary>
    using openGL;
    using renderer;
    public class Font {
        public string fileFormat = "map_{0:x2}.png";
        public string filesPath = "";
        public string fileWidth = "size_width.bin";
        public string fileHeight = "size_height.bin";
        public string charsMap = "\u00c0\u00c1\u00c2\u00c8\u00ca\u00cb\u00cd\u00d3\u00d4\u00d5\u00da\u00df\u00e3\u00f5\u011f\u0130\u0131\u0152\u0153\u015e\u015f\u0174\u0175\u017e\u0207\u0000\u0000\u0000\u0000\u0000\u0000\u0000 !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~\u0000\u00c7\u00fc\u00e9\u00e2\u00e4\u00e0\u00e5\u00e7\u00ea\u00eb\u00e8\u00ef\u00ee\u00ec\u00c4\u00c5\u00c9\u00e6\u00c6\u00f4\u00f6\u00f2\u00fb\u00f9\u00ff\u00d6\u00dc\u00f8\u00a3\u00d8\u00d7\u0192\u00e1\u00ed\u00f3\u00fa\u00f1\u00d1\u00aa\u00ba\u00bf\u00ae\u00ac\u00bd\u00bc\u00a1\u00ab\u00bb\u2591\u2592\u2593\u2502\u2524\u2561\u2562\u2556\u2555\u2563\u2551\u2557\u255d\u255c\u255b\u2510\u2514\u2534\u252c\u251c\u2500\u253c\u255e\u255f\u255a\u2554\u2569\u2566\u2560\u2550\u256c\u2567\u2568\u2564\u2565\u2559\u2558\u2552\u2553\u256b\u256a\u2518\u250c\u2588\u2584\u258c\u2590\u2580\u03b1\u03b2\u0393\u03c0\u03a3\u03c3\u03bc\u03c4\u03a6\u0398\u03a9\u03b4\u221e\u2205\u2208\u2229\u2261\u00b1\u2265\u2264\u2320\u2321\u00f7\u2248\u00b0\u2219\u00b7\u221a\u207f\u00b2\u25a0\u0000";

        public int symbolCount = 65536;
        public int atlasCount = 256; // Подумать насчёт математики может и сделать 255 ибо выгоднее чем ставить кучу минусов в коде ведь фактически где нужно действительно 256 для выделения массивов и поиска кратной страницы #1  (сумме четыре случая где нужно число 256)
        public int XSymbolsAtlas = 16;
        public int YSymbolsAtlas = 16;
        public int textureFilterMode = 9728; // GL_NEAREST

        public float widthSymbolAtlas = 16.0F;
        public float heightSymbolAtlas = 16.0F;
        public float widthAtlasMap = 256.0F;
        public float heightAtlasMap = 256.0F;

        public float fontSize = 1.0F;
        public float italicF = 0.0F;
        public float intervalF = 0.0F;

        public bool hasColor = false;
        public uint colorHex = 0xffffffff;

        public byte[] symbolWidth = null;
        public byte[] symbolHeight = null;
        private uint[] listTexture = null;
        private string[] PAGE_LOCATIONS = null;

        public Tessellator tessellator = null;

        private string getPageLocation(int page) {
            if (PAGE_LOCATIONS[page] == null)
                PAGE_LOCATIONS[page] = System.String.Format(filesPath + fileFormat, page);
            return PAGE_LOCATIONS[page];
        }

        private void bindTexture(int pange) {
            if (pange > atlasCount)
                return;
            uint index = listTexture[pange];
            if (index != 0)
                GL11.glBindTexture(GL11.GL_TEXTURE_2D, index);///Textures.bindTexture(index);
            else
                listTexture[pange] = Textures.loadTexture(this.getPageLocation(pange), textureFilterMode);
        }

        public float renderChar(char ch, float posX, float posY, float posZ) {
            this.bindTexture(ch / atlasCount); // #1
            float uTex = (float)(ch % XSymbolsAtlas * YSymbolsAtlas);
            float vTex = (float)((ch & (atlasCount - 1)) / XSymbolsAtlas * YSymbolsAtlas);

            if ((int)ch > symbolCount)
                return (int)widthSymbolAtlas;

            int byteWidth = this.symbolWidth[ch] & (atlasCount - 1);
            int byteHeight = this.symbolHeight[ch] & (atlasCount - 1);

            uTex += (int)((uint)byteWidth >> 4); // offset x
            float widthSymbol = (byteWidth & 15) + 1; // width x

            vTex += (int)((uint)byteHeight >> 4); // offset y
            float heightSymbol = (byteHeight & 15) + 1; // height y

            tessellator.clear();
            if (hasColor)
                tessellator.hasColor = true;
            tessellator.vertexUV(posX + italicF, posY, posZ, uTex / widthAtlasMap, vTex / heightAtlasMap);
            tessellator.vertexUV(posX - italicF, posY + heightSymbol * fontSize, posZ, uTex / widthAtlasMap, (vTex + heightSymbol) / heightAtlasMap);
            tessellator.vertexUV(posX + widthSymbol * fontSize + italicF, posY, posZ, (uTex + widthSymbol) / widthAtlasMap, vTex / heightAtlasMap);
            tessellator.vertexUV(posX + widthSymbol * fontSize - italicF, posY + heightSymbol * fontSize, posZ, (uTex + widthSymbol) / widthAtlasMap, (vTex + heightSymbol) / heightAtlasMap);
            tessellator.flush();
            return widthSymbol * fontSize + intervalF;
        }

        public float renderCharInt(int ch, float posX, float posY, float posZ) { return float.NaN; }

        public float renderChars(string chars, float posX, float posY, float posZ) {
            float result = 0;
            int length = chars.Length;
            for (int i = 0; i < length; i++) {
                result += renderChar(chars[i], posX + result, posY, posZ);
            }
            return result;
        }

        public float renderCharsShadow(string chars, float posX, float posY, float posZ, uint color) {
            float result = 0;
            int length = chars.Length;
            for (int i = 0; i < length; i++) {
                tessellator.color((color & 0xFF000000) | (color & 0xFCFCFC) >> 2);
                renderChar(chars[i], posX + result + fontSize, posY + fontSize, posZ - 0.01f);
                tessellator.color(colorHex);
                result += renderChar(chars[i], posX + result, posY, posZ);
            }
            return result;
        }

        public void setColor(float r, float g, float b, float a) {
            hasColor = true;
            tessellator.color(r, g, b, a);
        }

        public void setColorHex(uint setColorHex) {
            hasColor = true;
            tessellator.color(setColorHex);
            colorHex = setColorHex;
        }

        public void init() {
            symbolWidth = new byte[symbolCount];
            symbolHeight = new byte[symbolCount];
            listTexture = new uint[atlasCount];
            PAGE_LOCATIONS = new string[atlasCount];

            tessellator = new Tessellator();
            tessellator.mode = GL11.GL_TRIANGLE_STRIP;
            tessellator.init(4);
        }

        public void load() {
            symbolWidth = System.IO.File.ReadAllBytes(filesPath  + fileWidth);
            symbolHeight = System.IO.File.ReadAllBytes(filesPath + fileHeight);
        }

        public void destroy() {
            tessellator.destroy();
        }

        public int getSymbolWidth(char ch) {
            if ((int)ch > symbolCount)
                return (int)widthSymbolAtlas;
            return (this.symbolWidth[ch] & (atlasCount - 1) & 15);
        }

        public int getSymbolHeight(char ch) {
            if ((int)ch > symbolCount)
                return (int)heightSymbolAtlas;
            return (this.symbolHeight[ch] & (atlasCount - 1) & 15);
        }

        public int getOffsetSymbolWidth(char ch) {
            if ((int)ch > symbolCount)
                return 0;
            return (int)((uint)this.symbolWidth[ch] & (atlasCount - 1) >> 4);
        }

        public int getOffsetHeight(char ch) {
            if ((int)ch > symbolCount)
                return 0;
            return (int)((uint)this.symbolHeight[ch] & (atlasCount - 1) >> 4);
        }

        public Font() {
            init();
        }

        ~Font() {
            destroy();
        }
    }
}
