namespace MultiTool
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Класс содержит некоторые вспомогательные инструменты
    /// для различных мелких задач - таких, как, например,
    /// проверка состояния бита; установки или снятия бита;
    /// подсчёта количества разрядов в числе и т.п.
    /// 
    /// Дело в том, что в процессе разработки постоянно
    /// возникают подобные задачки, которые интуитивно хочется
    /// вынести в отдельный блок - т.е. сюда, в связи с тем,
    /// что они полезны и часто используются мной в разных проектах.
    /// Надеюсь, может быть полезно и кому-то ещё.
    ///
    /// Этот класс является некой «живой субстанцией» и
    /// постоянно обновляется и «обрастает» новым функционалом.
    /// </summary>
    /// <author>SaMSoN (Дмитрий Самсонов)</author>
    /// <version>1.03</version>
    /// <date>26.08.2024</date>
    public static class Tools
    {
        ///////////////////////////////////////////////////////////////////////
        // ВНИМАНИЕ!
        //
        // Понятия "слово" (word), "полуслово" (halfword), "двойное слово"
        // (dword) и т.д. ЯВЛЯЮТСЯ МАШИННОЗАВИСИМЫМИ - и в зависимости
        // от архитектуры конкретного процессора могут обозначать разное
        // количество бит.
        //
        // В тексте данного класса "слово" (word) подразумевает 16 бит,
        // "полуслово" (halfword) - 8 битт (т.е. в данном случае совпадает
        // с байт), "двойное слово" (dword) - 32 бит и т.д.
        //
        // Эти условности в принципе ни на что не влияют, но при чтении
        // этого кода эта информация облегчает его понимание.
        ////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        //                  КОНТРОЛЬ УСТАНОВКИ n-го БИТА
        // (перегрузки для целых беззнаковых чисел разрядностью 8 - 64 бит) 
        ////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Возвращает  true, если n-й бит (отсчёт с нуля) байта halfword установлен, и false в обратном случае.
        /// </summary>
        /// <param name="halfword">Исходный байт.</param>
        /// <param name="n">Номер бита, установку которого необходимо проверить (с нуля).</param>
        /// <returns>Возвращает true, если n-й бит байта halfword установлен, и false в обратном случае.</returns>
        public static bool IsBitSetted(byte halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return false;

            // Битовая маска для проверки установки n-го бита.
            byte mask = (byte)(0x1 << n);

            return (halfword & mask) == mask
                ? true
                : false;
        }

        /// <summary>
        /// Возвращает  true, если n-й бит (отсчёт с нуля) байта halfword установлен, и false в обратном случае.
        /// </summary>
        /// <param name="halfword">Исходный байт.</param>
        /// <param name="n">Номер бита, установку которого необходимо проверить (с нуля).</param>
        /// <returns>Возвращает true, если n-й бит байта halfword установлен, и false в обратном случае.</returns>
        public static bool IsBitSetted(UInt16 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return false;

            // Битовая маска для проверки установки n-го бита.
            UInt16 mask = (UInt16)(0x1 << n);

            return (halfword & mask) == mask
                ? true
                : false;
        }

        /// <summary>
        /// Возвращает  true, если n-й бит (отсчёт с нуля) байта halfword установлен, и false в обратном случае.
        /// </summary>
        /// <param name="halfword">Исходный байт.</param>
        /// <param name="n">Номер бита, установку которого необходимо проверить (с нуля).</param>
        /// <returns>Возвращает true, если n-й бит байта halfword установлен, и false в обратном случае.</returns>
        public static bool IsBitSetted(UInt32 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return false;

            // Битовая маска для проверки установки n-го бита.
            UInt32 mask = (UInt32)(0x1 << n);

            return (halfword & mask) == mask
                ? true
                : false;
        }

        /// <summary>
        /// Возвращает  true, если n-й бит (отсчёт с нуля) байта halfword установлен, и false в обратном случае.
        /// </summary>
        /// <param name="halfword">Исходный байт.</param>
        /// <param name="n">Номер бита, установку которого необходимо проверить (с нуля).</param>
        /// <returns>Возвращает true, если n-й бит байта halfword установлен, и false в обратном случае.</returns>
        public static bool IsBitSetted(UInt64 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return false;

            // Битовая маска для проверки установки n-го бита.
            UInt64 mask = (UInt64)(0x1 << n);

            return (halfword & mask) == mask
                ? true
                : false;
        }

        ///////////////////////////////////////////////////////////////////////
        //                   УСТАНОВКА/СНЯТИЕ n-го БИТА                   
        // (перегрузки для целых беззнаковых чисел разрядностью 8 - 64 бит) 
        ////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Устанавливает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword с установленным n-м битом.</returns>
        public static void SetBit(ref byte halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            byte mask = (byte)(0x1 << n); // Битовая маска для установки n-го бита. 
            halfword |= mask;
        }

        /// <summary>
        /// Снимает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword со снятым n-м битом.</returns>
        public static void ResetBit(ref byte halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            byte mask = (byte)(~(0x1 << n)); // Битовая маска для снятия n-го бита. 
            halfword &= mask;
        }

        /// <summary>
        /// Устанавливает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword с установленным n-м битом.</returns>
        public static void SetBit(ref UInt16 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            UInt16 mask = (UInt16)(0x1 << n); // Битовая маска для установки n-го бита. 
            halfword |= mask;
        }

        /// <summary>
        /// Снимает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword со снятым n-м битом.</returns>
        public static void ResetBit(ref UInt16 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            UInt16 mask = (UInt16)(~(0x1 << n)); // Битовая маска для снятия n-го бита. 
            halfword &= mask;
        }

        /// <summary>
        /// Устанавливает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword с установленным n-м битом.</returns>
        public static void SetBit(ref UInt32 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            UInt32 mask = (UInt32)(0x1 << n); // Битовая маска для установки n-го бита. 
            halfword |= mask;
        }

        /// <summary>
        /// Снимает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword со снятым n-м битом.</returns>
        public static void ResetBit(ref UInt32 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            UInt32 mask = (UInt32)(~(0x1 << n)); // Битовая маска для снятия n-го бита. 
            halfword &= mask;
        }

        /// <summary>
        /// Устанавливает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword с установленным n-м битом.</returns>
        public static void SetBit(ref UInt64 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            UInt64 mask = (UInt64)(0x1 << n); // Битовая маска для установки n-го бита. 
            halfword |= mask;
        }

        /// <summary>
        /// Снимает n-ый бит в байте halfword.
        /// </summary>
        /// <returns>Возвращает байт halfword со снятым n-м битом.</returns>
        public static void ResetBit(ref UInt64 halfword, int n)
        {
            if ((n < 0) || (n > 7))
                return;

            UInt64 mask = (UInt64)(~(0x1 << n)); // Битовая маска для снятия n-го бита. 
            halfword &= mask;
        }

        /// <summary>
        /// Возвращает младший байт шестнадцатибитного слова word.
        /// </summary>
        /// <param name="word">Шестнадцатибитное слово.</param>
        /// <returns>Возвращает младший майт шестнадцатибитного слова word.</returns>
        public static byte GetLowByte(UInt16 word)
        {
                return Convert.ToByte(word & 0xFF);
        }

        /// <summary>
        /// Возвращает старший байт шестнадцатибитного слова word.
        /// </summary>
        /// <param name="word">Шестнадцатибитное слово.</param>
        /// <returns>Возвращает старший майт шестнадцатибитного слова word.</returns>
        public static byte GetHighByte(UInt16 word) => Convert.ToByte(word >> 8);

        /// <summary>
        ///  «Разбивает» слово (16 бит) на два байта.
        /// </summary>
        /// <param name="word">Шестнадцатибитное слово.</param>
        /// <returns>Возвращает два байта, полученные рабиением исходного шестнадцатибитного слова.
        /// Первым (с индексом 0) возвращается СТАРШИЙ БАЙТ, младший байт возвращается с индексом 1.</returns>
        public static byte[] SplitWordOnTwoBytes(UInt16 word)
        {
            var bytes = new byte[2];

            bytes[0] = GetHighByte(word); // Старший байт.
            bytes[1] = GetLowByte(word);  // Младший байт.

            return bytes;
        }

        /// <summary>
        /// «Склеивает» два байта в одно шестнадцатибитное слово.
        /// </summary>
        /// <param name="lowByte">Младший байт.</param>
        /// <param name="highByte">Старший байт.</param>
        /// <returns>Возвращает слово (16 бит), полученное конкатенацией двух байтов.</returns>
        public static UInt16 ConcatBytesIntoWord(byte lowByte, byte highByte) => Convert.ToUInt16((highByte << 8) | lowByte);
        

        ///////////////////////////////////////////////////////////////////////
        //          КОЛИЧЕСТВО ЦИФР (РАЗРЯДОВ) В ДЕСЯТИЧНОМ ЧИСЛЕ                    
        ////////////////////////////////////////////////////////////////////

        /// <summary>
        ///  Возвращает количество цифр (разрядов) в десятичном числе n.
        /// </summary>
        /// <param name="n">Число, количество цифр которого необходимо определить.</param>
        /// <returns></returns>
        public static int DigitsCount(int n) => (n == 0) ? 1 : (int)Math.Log10(Math.Abs(n)) + 1;


        ///////////////////////////////////////////////////////////////////////
        //                  ПОИСК ДАТЫ И ВРЕМЕНИ В СТРОКЕ                    
        ////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Выполняет поиск даты в строке.
        /// </summary>
        /// <param name="line">Строка, предположительно содержащая дату.</param>
        /// <param name="date">Выходной параметр. Принимает первое вхождение найденной в строке даты.</param>
        /// <returns>Возвращает true, если дата в строке была найдена, и false в обраном случае.</returns>
        public static bool TryFindDate(string line, out DateTime date)
        {
            date = new DateTime();

            // Регулярные выражения для поиска даты в строке.
            List<Regex> regExprs = new List<Regex> {
                new Regex(@"\d{1,2}.\d{1,2}.\d{4}"),
                new Regex(@"\d{2}-\d{2}-\d{4}"),
                new Regex(@"\d{2}_\d{2}_\d{4}")
            };

            foreach (Regex regExpr in regExprs)
            {
                // Ищем в исходной строке первое совпадение, соответствующее регулярному выражению.
                Match match = regExpr.Match(line);

                // Что-то похожее, удовлетворяющее регулярному выражению, нашли!
                while (match.Success)
                {
                    // Если это похожее не парсится в объект DateTime, тогда поищем следующие совпадения.
                    if (!DateTime.TryParse(match.Value, out date))
                    {
                        match = match.NextMatch();
                        continue;
                    }

                    // Распарсилось - радостно возвращем это значение!
                    return true;
                }
            }

            // Ничего не найдено.
            return false;
        }

        /// <summary>
        /// Выполняет поиск времени в строке.
        /// </summary>
        /// <param name="line">Строка, предположительно содержащая время.</param>
        /// <param name="time">Выходной параметр. Принимает первое вхождение найденного в строке времени.</param>
        /// <returns>Возвращает true, если время в строке было найдено, и false в обраном случае.</returns>
        public static bool TryFindTime(string line, out DateTime time)
        {
            time = new DateTime();

            // «∶» - это знак, похожий на двоеточие («:») - но это не оно, поэтому этот знак можно использовать
            // даже в названиях файлов. Я использую этот знак в названиях лог-файлов для описания времени.
            line = line.Replace("∶", ":");

            // Регулярные выражения для поиска даты в строке.
            Regex[] regExprs = new Regex[] {
                new Regex(@"\d{2}:\d{2}:\d{2}"),   // 09:16:42
                new Regex(@"\d{1,2}:\d{2}"),       // 9:16, 09:16

                new Regex(@"\d{2}-\d{2}-\d{2}\s"), // 09-16-42
                new Regex(@"\d{2}_\d{2}_\d{2}\s")  // 09_16_42
            };

            foreach (Regex regExpr in regExprs)
            {
                // Ищем в исходной строке первое совпадение, соответствующее регулярному выражению.
                Match match = regExpr.Match(line);

                // Что-то похожее, удовлетворяющее регулярному выражению, нашли!
                while (match.Success)
                {
                    // Если это похожее не парсится в DateTime, тогда поищем следующие совпадения.
                    if (!DateTime.TryParse(match.Value, out time))
                    {
                        match = match.NextMatch();
                        continue;
                    }

                    // Распарсилось - радостно возвращем это значение!
                    time = new DateTime(0001, 01, 01, time.Hour, time.Minute, time.Second);

                    return true;
                }
            }

            // Ничего не найдено.
            return false;
        }

        /// <summary>
        /// Выполняет поиск даты и времени в строке.
        /// </summary>
        /// <param name="line">Строка, предположительно содержащая дату и время.</param>
        /// <param name="dateTime">Выходной параметр. Принимает первое вхождение найденных в строке даты и времени.</param>
        /// <returns>Возвращает true, если дата и время в строке были найдены, и false в обраном случае.</returns>
        public static bool TryFindDateTime(string line, out DateTime dateTime)
        {
            dateTime = new DateTime();

            DateTime dateFound = new DateTime();
            DateTime timeFound = new DateTime();

            if (TryFindDate(line, out dateFound) && TryFindTime(line, out timeFound))
            {
                dateTime = new DateTime(dateFound.Year, dateFound.Month, dateFound.Day,
                                        timeFound.Hour, timeFound.Minute, timeFound.Second);

                return true;
            }

            return false;
        }
    }
}
