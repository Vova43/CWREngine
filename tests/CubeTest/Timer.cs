// by Vova43 / vova436612
namespace tests.CubeTest {
    /// <summary>Предназначен для организации прерываний(выполнение некоторых задач в определённое время)<para />Пример использования:<para />
    /// &#84;&#105;&#109;&#101;&#114;&#160;&#116;&#105;&#109;&#101;&#114;&#160;&#61;&#160;&#110;&#101;&#119;&#160;&#84;&#105;&#109;&#101;&#114;&#40;&#50;&#48;&#40;&#1082;&#1086;&#1083;&#1100;&#1095;&#1077;&#1089;&#1090;&#1074;&#1086;&#160;&#1090;&#1080;&#1082;&#1086;&#1074;&#160;&#1074;&#160;&#49;&#160;&#1089;&#1077;&#1082;&#1091;&#1085;&#1076;&#1077;&#41;&#41;&#59;&#160;<para />&#119;&#104;&#105;&#108;&#101;&#160;&#40;&#116;&#114;&#117;&#101;&#41;&#160;&#123;&#160;&#47;&#47;&#160;&#1055;&#1088;&#1080;&#1084;&#1077;&#1088;&#160;&#1094;&#1080;&#1082;&#1083;&#1072;&#160;&#1074;&#160;&#1087;&#1088;&#1086;&#1075;&#1088;&#1072;&#1084;&#1084;&#1077;<para />&#160;&#160;&#160;&#160;&#116;&#105;&#109;&#101;&#114;&#46;&#117;&#112;&#100;&#97;&#116;&#101;&#40;&#41;&#59;&#160;&#47;&#47;&#160;&#1054;&#1073;&#1085;&#1086;&#1074;&#1083;&#1077;&#1085;&#1080;&#1077;&#160;&#1090;&#1072;&#1081;&#1084;&#1077;&#1088;&#1072;&#160;&#1076;&#1083;&#1103;&#160;&#1087;&#1086;&#1083;&#1091;&#1095;&#1077;&#1085;&#1080;&#1103;&#160;&#1090;&#1086;&#1095;&#1085;&#1086;&#1075;&#1086;&#160;&#1074;&#1088;&#1077;&#1084;&#1077;&#1085;&#1080;&#160;&#1087;&#1086;&#1089;&#1083;&#1077;&#1076;&#1085;&#1077;&#1075;&#1086;&#160;&#1086;&#1073;&#1085;&#1086;&#1074;&#1083;&#1077;&#1085;&#1080;&#1103;<para />&#160;&#160;&#160;&#160;&#102;&#111;&#114;&#160;&#40;&#105;&#110;&#116;&#160;&#116;&#105;&#99;&#107;&#115;&#160;&#61;&#160;&#48;&#59;&#160;&#116;&#105;&#99;&#107;&#115;&#160;&#60;&#160;&#116;&#105;&#109;&#101;&#114;&#46;&#116;&#105;&#99;&#107;&#115;&#59;&#160;&#116;&#105;&#99;&#107;&#115;&#160;&#43;&#61;&#160;&#49;&#41;&#160;&#123;&#160;&#47;&#47;&#160;&#1055;&#1088;&#1080;&#1084;&#1077;&#1088;&#160;&#1076;&#1083;&#1103;&#160;&#1086;&#1073;&#1088;&#1072;&#1073;&#1086;&#1090;&#1082;&#1080;&#160;&#1087;&#1086;&#1089;&#1090;&#1091;&#1087;&#1080;&#1074;&#1096;&#1080;&#1093;&#160;&#1090;&#1080;&#1082;&#1086;&#1074;&#160;&#1077;&#1089;&#1083;&#1080;&#160;&#1090;&#1080;&#1082;&#1086;&#1074;&#160;&#1073;&#1086;&#1083;&#1077;&#1077;&#160;&#49;&#160;&#1084;&#1086;&#1078;&#1085;&#1086;&#160;&#1080;&#1089;&#1087;&#1086;&#1083;&#1100;&#1079;&#1086;&#1074;&#1072;&#1090;&#1100;&#160;&#1094;&#1080;&#1082;&#1083;<para />&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#67;&#111;&#110;&#115;&#111;&#108;&#101;&#46;&#87;&#114;&#105;&#116;&#101;&#76;&#105;&#110;&#101;&#40;&#34;&#116;&#105;&#109;&#101;&#114;&#160;&#104;&#97;&#115;&#160;&#116;&#105;&#99;&#107;&#115;&#34;&#41;&#59;&#160;&#47;&#47;&#160;&#1042;&#160;&#1082;&#1072;&#1095;&#1077;&#1089;&#1090;&#1074;&#1077;&#160;&#1087;&#1088;&#1080;&#1084;&#1077;&#1088;&#1072;<para />&#160;&#160;&#160;&#160;&#125;<para />&#125;
    /// <![CDATA[
    /// Timer timer = new Timer(20(кольчество тиков в 1 секунде)); 
    /// while (true) { // Пример цикла в программе
    ///     timer.update(); // Обновление таймера для получения точного времени последнего обновления
    ///     for (int ticks = 0; ticks < timer.ticks; ticks += 1) { // Пример для обработки поступивших тиков если тиков более 1 можно использовать цикл
    ///         Console.WriteLine("timer has ticks"); // В качестве примера
    ///     }
    /// }
    /// ]]>
    /// </summary>
    public class Timer {
        public static long NANOSECONDS_PER_SECOND     = 1000000000L;
        public static long MAX_NANOSECONDS_PER_UPDATE = 1000000000L;
        public static int MAX_TICKS_PER_UPDATE        = 100;
        public float ticksPerSecond = 0;
        public long lastTime        = 0;
        public int ticks            = 0;
        public float fractionalTicks = 0;
        public float timeScale       = 0;
        public float framesPerSecond = 0;
        public float passedTime      = 0;
        public long elapsedNanoseconds = 0;

        // add in 15.12.24 - 1:38 оптимизировать надо -->> готово 14.02.25 - 23:02 / 20.10.25 - 02:21/26
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern void QueryPerformanceCounter(ref long ticks);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern void QueryPerformanceFrequency(ref long frequency);

        private long ticksPerSecondNano = 0;
        private long ticksNano = 0;
        private long getNano() {
            QueryPerformanceCounter(ref ticksNano);
            return (1000000000 * ticksNano) / ticksPerSecondNano;
        }

        public Timer(float ticksPerSecond) {
            this.timeScale       = 1.0f;
            this.framesPerSecond = 0.0f;
            this.passedTime      = 0.0f;
            this.ticksPerSecond = ticksPerSecond;
            QueryPerformanceFrequency(ref ticksPerSecondNano);
            this.lastTime = getNano();
        }

        public void update() {
            long currentTime = 0L;
            currentTime = getNano();
            elapsedNanoseconds = currentTime - this.lastTime;

            this.lastTime = currentTime;

            if (elapsedNanoseconds < 0L) {
                elapsedNanoseconds = 0L;
            }

            if (elapsedNanoseconds > MAX_NANOSECONDS_PER_UPDATE) {
                elapsedNanoseconds = MAX_NANOSECONDS_PER_UPDATE;
            }
            if (elapsedNanoseconds != 0)
                this.framesPerSecond = (float)(NANOSECONDS_PER_SECOND / elapsedNanoseconds);

            this.passedTime += elapsedNanoseconds * this.timeScale * this.ticksPerSecond / NANOSECONDS_PER_SECOND;
            this.ticks = (int)this.passedTime;

            if (this.ticks > MAX_TICKS_PER_UPDATE) {
                this.ticks = MAX_TICKS_PER_UPDATE;
            }

            this.passedTime -= this.ticks;
            this.fractionalTicks = this.passedTime;
        }
    }
}