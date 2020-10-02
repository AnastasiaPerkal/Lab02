using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1) Типы
            //переменные всех возможных примитивных типов С#
            bool check = true;
            char symbol = 'a';
            byte bnum = 255;
            sbyte sbnum = -128;
            short snum = -32768;
            ushort usnum = 65535;
            int inum = -2147483648;
            uint uinum = 4294967295;
            float fnum = 1.23f;
            double dnum = 456.78;
            long lnum = -9223372036854775808;
            ulong ulnum = 18446744073709551615;
            decimal decnum = 9101112.13m;

            string hello = "Hello";
            dynamic dynum = 23;
            object num = 15;
            object world = "world";
            //интерполирование строк
            Console.WriteLine($"Types:\nbool: {check}\nchar: {symbol}\nbyte: {bnum}\nsbyte: {sbnum}\nshort: {snum}\nushort: {usnum}\nint: {inum}\nuint: {uinum}\nfloat: {fnum}\ndouble: {dnum}");
            Console.WriteLine($"long: {lnum}\nulong: {ulnum}\ndecimal: {decnum}\ndynamic: {dynum}\nobject: {num}");
            Console.WriteLine($"{hello} {world}!");
            Console.Write("1 to skip: ");
            int one1 = Convert.ToInt32(Console.ReadLine());
            if (one1 != 1)
            {
                Console.Write("String: ");
                hello = Console.ReadLine();

                Console.Write("bool: ");
                check = Convert.ToBoolean(Console.ReadLine());

                Console.Write("char: ");
                symbol = Convert.ToChar(Console.ReadLine());

                Console.Write("byte: ");
                bnum = Convert.ToByte(Console.ReadLine());

                Console.Write("sbyte: ");
                sbnum = Convert.ToSByte(Console.ReadLine());

                Console.Write("short: ");
                snum = Convert.ToInt16(Console.ReadLine());

                Console.Write("ushort: ");
                usnum = Convert.ToUInt16(Console.ReadLine());

                Console.Write("int: ");
                inum = Convert.ToInt32(Console.ReadLine());

                Console.Write("uint: ");
                uinum = Convert.ToUInt32(Console.ReadLine());

                Console.Write("float: ");
                fnum = Convert.ToSingle(Console.ReadLine());

                Console.Write("double: ");
                dnum = Convert.ToDouble(Console.ReadLine());

                Console.Write("long: ");
                lnum = Convert.ToInt64(Console.ReadLine());

                Console.Write("ulong: ");
                ulnum = Convert.ToUInt64(Console.ReadLine());

                Console.Write("decimal: ");
                decnum = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine($"Types:\nbool: {check}\nchar: {symbol}\nbyte: {bnum}\nsbyte: {sbnum}\nshort: {snum}\nushort: {usnum}\nint: {inum}\nuint: {uinum}\nfloat: {fnum}\ndouble: {dnum}");
                Console.WriteLine($"long: {lnum}\nulong: {ulnum}\ndecimal: {decnum}\ndynamic: {dynum}\nobject: {num}");
                Console.WriteLine($"{hello} {world}!");
            }

            //b.
            //5 операций неявного приведения
            inum = bnum;
            dnum = fnum;
            lnum = inum;
            fnum = inum;
            dnum = snum;
            //5 операций явного приведения
            bnum = (byte)inum;
            snum = (short)inum;
            fnum = (float)dnum;
            inum = (int)lnum;
            inum = (int)dnum;
            //c. 
            //упаковка
            int x = 10;
            object ox = x;
            //распаковка
            int y = (int)ox;
            //d. работа с неявно типизированной переменной
            var i = 40;
            var st = "st";
            Console.WriteLine($"Var:\ni = {i}\nst = {st}!");
            //e. Nullable переменная
            int? nullx1 = null;
            int? nullx2 = null;
            Console.Write("nullx1 == nullx2:");
            Console.WriteLine(nullx1 == nullx2); //true;
            int x1 = nullx1 ?? 1; //1
            Console.WriteLine($"nullx1 ?? 1 = {x1}");
            //f.
            //i = "meow"; 

            //2) Строки
            //a. сравнение
            string str1 = "abc";
            string str2 = "def";
            string str3 = "abc";
            inum = String.Compare(str1, str3);
            Console.WriteLine($"str1 == str3: {inum}");
            inum = String.Compare(str1, str2);
            Console.WriteLine($"str2 == str3: {inum}");
            //b. 
            //сцепление
            str1 += ' ' + str2; //abcdef
            str3 = String.Concat(str3, str2); //abcdef
            Console.WriteLine($"str1 = : {str1}");
            Console.WriteLine($"str3 = : {str3}");

            //копирование
            string str4 = String.Copy(str2);
            Console.WriteLine($"str4 = : {str4}");

            //выделение подстроки, начиная с заданной позиции
            Console.WriteLine(str2.Substring(1));

            //разделение строки на слова
            string[] words = str1.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            //вставка подстроки в заданную позицию
            str4 = str4.Insert(2, str1);
            Console.WriteLine($"str4 = : {str4}");

            //удаление заданной подстроки
            str4 = str4.Remove(2);
            Console.WriteLine($"str4 = : {str4}");

            //c.
            //использование метода string.IsNullOrEmpty.
            string emptystr = "";
            string nullstr = null;

            //true if the value parameter is null or an empty string (""); otherwise, false.
            Console.WriteLine(String.IsNullOrEmpty(emptystr));
            Console.WriteLine(String.IsNullOrEmpty(nullstr));
            Console.WriteLine(String.IsNullOrEmpty(str1));

            //d. stringbuilder
            StringBuilder sb = new StringBuilder("Привет");
            sb.Append("!");
            // заменяем слово
            sb.Replace("Привет", "Hello");
            Console.WriteLine(sb);
            // удаляем 3 символa, начиная с 2-го
            sb.Remove(2, 3);
            Console.WriteLine(sb);
            //
            sb.Insert(2, "llo");
            // получаем строку из объекта StringBuilder
            string s1 = sb.ToString();
            Console.WriteLine(s1);

            // 3) Массивы
            //a. целый двумерный массив 

            int[,] array1 = { { 11, 22, 33 }, { 44, 55, 66 } };

            for (int t = 0; t < 2; t++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + array1[t, j]);
                }
                Console.WriteLine();
            }
            //b.одномерный массив строк
            string[] numbers = new String[] { "one", "two", "three" };
            foreach (string element in numbers)
            {
                Console.WriteLine(element);
            }

            Console.Write("1 to skip: ");
            one1 = Convert.ToInt32(Console.ReadLine());
            if (one1 != 1)
            {
                Console.Write("Position: ");
                inum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Value: ");
                st = Console.ReadLine();
                numbers[inum] = st;
                foreach (string element in numbers)
                {
                    Console.WriteLine(element);
                }
            }

            //c. 
            //ступечатый массив вещественных чисел с 3-мя строками,
            //в каждой из которых 2, 3 и 4 столбцов соответственно.
            //Значения массива вводятся с консоли
            Console.Write("1 to skip: ");
            one1 = Convert.ToInt32(Console.ReadLine());
            if (one1 != 1)
            {
                Console.WriteLine("Enter the elements of float array:");
                float[][] array2 = { new float[2], new float[3], new float[4] };
                for (int j = 0; j < 3; j++)
                    for (int f = 0; f < array2[j].Length; f++)
                    {
                        array2[j][f] = Convert.ToSingle(Console.ReadLine());
                    }

                foreach (float[] x0 in array2)
                {
                    foreach (float a0 in x0)
                    {
                        Console.Write("\t" + a0);
                    }
                    Console.WriteLine();
                }
            }

            //d.
            //неявно типизированные переменные для хранения массива и строки.
            var varstr = "meow";
            var vararray = new[] { 1, 2, 3, 4 };

            // 4) Кортежи
            //a. кортеж из 5 элементов с типами int, string, char, string, ulong.
            ValueTuple<int, string, char, string, ulong> fiveElements = ( 1, "cat", '&', "dog", 1 );
            //b.
            Console.WriteLine($"Tuple elements(2,3,4): {fiveElements.Item2}{fiveElements.Item3}{fiveElements.Item4}");
            Console.WriteLine($"{fiveElements}");
            //c. распаковка кортежа в переменные
            var (one, two, three, four, five) = fiveElements;
            var cat = fiveElements.Item2;
            Console.WriteLine($"one: {one}, two: {two}, three: {three}, four: {four}, five: {five}");
            Console.WriteLine($"cat: {cat}");
            (int, string, char, string, ulong) fiveElements1 = (-1, "cat", '&', "dog", 1);
            //d. сравнение кортежей
            Console.WriteLine($"fiveElements1 == fiveElements:  {fiveElements1 == fiveElements}");
            Console.WriteLine($"fiveElements1 != fiveElements:  {fiveElements1 != fiveElements}");
            // 5)
            //Формальные параметры функции – массив целых и строка. 
            //Функция должна вернуть кортеж, содержащий: максимальный и 
            //минимальный элементы массива, сумму элементов массива и первую букву строки .
            (int max, int min, int sum, char first) ArrayElements(int[] number, string str)
            {
                int max = number[0], min = number[0], sum;
                char first;
                for (int u = 1; u < number.Length; u++)
                {
                    if (number[u] > max) max = number[u];
                    if (number[u] < min) min = number[u];
                }
                sum = max + min;
                first = str.ToCharArray()[0];
                return (max, min, sum, first);
            }
            int[] numbers1 = { 1, 2, 10, 14, 6 };
            ValueTuple<int, int, int, char> test = ArrayElements(numbers1, "fly");
            Console.WriteLine($"{test}");

            // 6)
            // Работа с checked/unchecked (переполнение)
            // В проверенном контексте арифметическое переполнение создает исключение. 
            void fun1 ()
            {
                try
                {
                    int maxInt = int.MaxValue;
                    int result = checked(maxInt + 1);
                }
                catch (OverflowException exc)
                {
                    Console.WriteLine(exc);
                }
            }
            void fun2()
            {
                int maxInt = int.MaxValue;
                int result = unchecked(maxInt + 1);
            }
            fun1();
            fun2();
        }

    }
}

