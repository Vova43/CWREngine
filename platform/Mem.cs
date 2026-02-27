// by Vova43 / vova436612
namespace platform {
    /// <summary> Класс представляющий механизмы для управления памятью, данная память является неуправляемой и чистить её нужно самостоятельно </summary>
    public unsafe class Mem {
        /// <summary>
        /// Константы для работы с кучей процесса.
        /// </summary>
        public static class HeapConstants {
            /// <summary>
            /// Флаг для HeapAlloc: память будет доступна для записи.
            /// </summary>
            public const uint HEAP_ALLOC_SIZE_PRESENT = 0x00000001; // Не очень часто используется напрямую для HeapAlloc

            /// <summary>
            /// Флаг для HeapReAlloc: память может быть перемещена.
            /// </summary>
            public const uint HEAP_REALLOC_IN_USE_FLAG = 0x00000001; // Для HeapReAlloc

            /// <summary>
            /// Флаг для HeapDestroy: не проверять блоки.
            /// </summary>
            public const uint HEAP_DESTROY_CHECK_ONLY_MARKERS = 0x00000001; // Для HeapDestroy

            /// <summary>
            /// Флаг для HeapCompact: возвращает количество освобожденного пространства.
            /// </summary>
            public const uint HEAP_COMPACT_USE_MAXIMUM_AMOUNT = 0x00000001; // Для HeapCompact

            /// <summary>
            /// Флаг для HeapWalk: блок занят.
            /// </summary>
            public const uint HEAP_ENTRY_INUSE = 0x00000004; // Для PROCESS_HEAP_ENTRY

            /// <summary>
            /// Флаг для HeapWalk: блок перемещаемый.
            /// </summary>
            public const uint HEAP_ENTRY_MOVEABLE = 0x00000002; // Для PROCESS_HEAP_ENTRY

            /// <summary>
            /// Флаг для HeapWalk: блок является сегментом.
            /// </summary>
            public const uint HEAP_ENTRY_SEGMENT = 0x00000001; // Для PROCESS_HEAP_ENTRY

            /// <summary>
            /// Флаг для HeapWalk: блок находится в общем сегменте DDE.
            /// </summary>
            public const uint HEAP_ENTRY_DDESHARE = 0x00000008; // Для PROCESS_HEAP_ENTRY
        }
        /// <summary>
        /// Представляет запись в куче процесса для обхода (HeapWalk).
        /// </summary>
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct PROCESS_HEAP_ENTRY {
            /// <summary>
            /// Указатель на блок.
            /// </summary>
            public void* lpData;

            /// <summary>
            /// Размер блока.
            /// </summary>
            public uint cbData;

            /// <summary>
            /// Флаги блока (например, HEAP_ENTRY_MOVEABLE, HEAP_ENTRY_DDESHARE).
            /// </summary>
            public uint dwFlags;

            /// <summary>
            /// Битовое поле для смещения в сегменте (для MOVEABLE блоков).
            /// </summary>
            public uint dwReserved;

            /// <summary>
            /// Указатель на следующий блок (для следующей итерации HeapWalk).
            /// </summary>
            public void* phantom; // Эта часть структуры может меняться в зависимости от версии Windows

            /// <summary>
            /// Получает значение, указывающее, является ли блок занятым.
            /// </summary>
            public bool IsAllocated {
                get {
                    return (dwFlags & HeapConstants.HEAP_ENTRY_INUSE) != 0;
                }
            }
        }

        /// <summary>
        /// Получает дескриптор кучи текущего процесса.
        /// </summary>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* GetProcessHeap();

        /// <summary>
        /// Создает новую кучу.
        /// </summary>
        /// <param name="flOptions">Опции для создания кучи (например, HEAP_CREATE_PRIVATE, HEAP_CREATE_ENABLE_EXECUTE).</param>
        /// <param name="dwInitialSize">Начальный размер кучи.</param>
        /// <param name="dwMaximumSize">Максимальный размер кучи.</param>
        /// <returns>Дескриптор новой кучи или void*.Zero в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* HeapCreate(uint flOptions, uint dwInitialSize, uint dwMaximumSize);

        /// <summary>
        /// Уничтожает указанную кучу.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи для уничтожения.</param>
        /// <returns>TRUE в случае успеха, FALSE в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern bool HeapDestroy(void* hHeap);

        /// <summary>
        /// Выделяет блок памяти из указанной кучи.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи.</param>
        /// <param name="dwFlags">Опции выделения (например, HEAP_ZERO_MEMORY, HEAP_NO_SERIALIZE).</param>
        /// <param name="dwBytes">Размер выделяемой памяти в байтах.</param>
        /// <returns>Указатель на выделенный блок памяти или void*.Zero в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* HeapAlloc(void* hHeap, uint dwFlags, uint dwBytes);

        /// <summary>
        /// Освобождает блок памяти, ранее выделенный из указанной кучи.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи.</param>
        /// <param name="dwFlags">Опции освобождения (например, HEAP_NO_SERIALIZE).</param>
        /// <param name="lpMem">Указатель на блок памяти, который нужно освободить.</param>
        /// <returns>TRUE в случае успеха, FALSE в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern bool HeapFree(void* hHeap, uint dwFlags, void* lpMem);

        /// <summary>
        /// Перераспределяет размер ранее выделенного блока памяти.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи.</param>
        /// <param name="dwFlags">Опции перераспределения (например, HEAP_REALLOC_IN_USE_FLAG).</param>
        /// <param name="lpMem">Указатель на блок памяти, который нужно перераспределить.</param>
        /// <param name="dwBytes">Новый размер блока памяти в байтах.</param>
        /// <returns>Указатель на перераспределенный блок памяти (может отличаться от исходного) или void*.Zero в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* HeapReAlloc(void* hHeap, uint dwFlags, void* lpMem, uint dwBytes);

        /// <summary>
        /// Возвращает размер блока памяти, выделенного из указанной кучи.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи.</param>
        /// <param name="dwFlags">Опции (например, HEAP_NO_SERIALIZE).</param>
        /// <param name="lpMem">Указатель на блок памяти.</param>
        /// <returns>Размер блока памяти в байтах или 0 в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern uint HeapSize(void* hHeap, uint dwFlags, void* lpMem);

        /// <summary>
        /// Заполняет блок памяти указанным значением.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи.</param>
        /// <param name="dwFlags">Опции (например, HEAP_NO_SERIALIZE).</param>
        /// <param name="lpMem">Указатель на блок памяти.</param>
        /// <param name="dwBytes">Количество байт для заполнения.</param>
        /// <param name="value">Значение (байт), которым будет заполнен блок.</param>
        /// <returns>TRUE в случае успеха, FALSE в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern bool HeapSetInformation(void* hHeap, uint HeapInformationClass, ref byte value, uint HeapInformationLength); // Это не прямо HeapSet, а более общий механизм

        // Вместо прямого memset, часто используют Marshal.Copy или unsafe pointer
        // для заполнения, так как в WinAPI нет прямого аналога memset для Heap.
        // Но для демонстрации можно использовать unsafe.

        /// <summary>
        /// Обход всех блоков в куче.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи.</param>
        /// <param name="lpEntry">Указатель на структуру PROCESS_HEAP_ENTRY для получения информации о блоке.</param>
        /// <returns>TRUE, если получен следующий блок, FALSE, если достигнут конец кучи или произошла ошибка.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern bool HeapWalk(void* hHeap, ref PROCESS_HEAP_ENTRY lpEntry);

        /// <summary>
        /// Компактирует указанную кучу.
        /// </summary>
        /// <param name="hHeap">Дескриптор кучи.</param>
        /// <param name="dwFlags">Опции для компактирования.</param>
        /// <returns>Количество освобожденного пространства или 0 в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern uint HeapCompact(void* hHeap, uint dwFlags);

        /// <summary>
        /// Выделяет блок памяти размером, указанным в байтах.
        /// </summary>
        /// <param name="size">Размер выделяемой памяти в байтах.</param>
        /// <returns>Указатель на выделенную память или null в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("msvcrt.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* malloc(uint size);

        /// <summary>
        /// Освобождает ранее выделенный блок памяти.
        /// </summary>
        /// <param name="ptr">Указатель на блок памяти, который нужно освободить.</param>
        [System.Runtime.InteropServices.DllImport("msvcrt.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void free(void* ptr);

        /// <summary>
        /// Создает копию блока памяти.
        /// </summary>
        /// <param name="dest">Указатель на целевой блок памяти.</param>
        /// <param name="src">Указатель на исходный блок памяти.</param>
        /// <param name="count">Количество байт для копирования.</param>
        /// <returns>Указатель на целевой блок памяти.</returns>
        [System.Runtime.InteropServices.DllImport("msvcrt.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* memcpy(void* dest, void* src, int count);

        /// <summary>
        /// Устанавливает указанное количество байт в блоке памяти.
        /// </summary>
        /// <param name="ptr">Указатель на блок памяти.</param>
        /// <param name="value">Значение, которое будет установлено в каждом байте.</param>
        /// <param name="count">Количество байт для установки.</param>
        /// <returns>Указатель на блок памяти.</returns>
        [System.Runtime.InteropServices.DllImport("msvcrt.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* memset(void* ptr, int value, int count);

        /// <summary>
        /// Выделяет блок памяти и инициализирует его нулями.
        /// </summary>
        /// <param name="num">Количество элементов для выделения.</param>
        /// <param name="size">Размер каждого элемента в байтах.</param>
        /// <returns>Указатель на выделенную память или null в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("msvcrt.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* calloc(int num, uint size);

        /// <summary>
        /// Перераспределяет размер ранее выделенного блока памяти.
        /// </summary>
        /// <param name="ptr">Указатель на ранее выделенный блок памяти.</param>
        /// <param name="newSize">Новый размер блока памяти в байтах.</param>
        /// <returns>Указатель на перераспределенный блок памяти, который может отличаться от исходного, или null в случае ошибки.</returns>
        [System.Runtime.InteropServices.DllImport("msvcrt.dll", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void* realloc(void* ptr, int newSize);

        /// <summary>
        /// Получает временный адрес массива для кратковременного использования в неуправляемом коде.
        /// </summary>
        /// <param name="arr">Массив для получения адреса.</param>
        /// <param name="index">Индекс относительно которого будет получен адрес.</param>
        /// <returns>Указатель на блок памяти, который является временным до обработки сборщика мусора.</returns>
        public static unsafe void* getArrayTempAddress(System.Array arr, int index) {
            return (void*)System.Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(arr, index);
        }

        /// <summary>
        /// Получает временный адрес массива для кратковременного использования в неуправляемом коде.
        /// </summary>
        /// <param name="arr">Массив для получения адреса.</param>
        /// <returns>Указатель на блок памяти, который является временным до обработки сборщика мусора.</returns>
        public static unsafe void* getArrayTempAddress(System.Array arr) {
            return (void*)System.Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(arr, 0);
        }
    }
}