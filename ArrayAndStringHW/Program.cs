using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndStringHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            // SecondTask();
            // ThirdTask();
            //FourthTask();
            FifthTask();
        }

        private static void FifthTask()
        {
            Console.WriteLine("Необходимо ввести числом N, причем N>0");
            try
            {
                Console.WriteLine("Введите N");
                string N = Console.ReadLine();
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Не соблюдено условие N>0");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Полученное число");
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
            Console.WriteLine();
        }

        private static void FourthTask()
        {
            bool isInt;
            int a, b;
            Console.WriteLine("Введите числа А и В. (A < B)");
            do
            {
                Console.Write("A: ");
                isInt = int.TryParse(Console.ReadLine(), out a);
                if (!isInt) Console.WriteLine("Не корректное число");

            } while (!isInt);

            do
            {
                Console.Write("B: ");
                isInt = int.TryParse(Console.ReadLine(), out b);
                if (!isInt || b < a) Console.WriteLine("Не корректное число");

            } while (!isInt || b < a);

            Console.Clear();
            Console.WriteLine("A: {0};\tB: {1}\n", a, b);

            for (; a <= b; a++)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void ThirdTask()
        {
            char[] array;
            string input, output;

            Console.Write("Строка: ");
            input = Console.ReadLine();

            array = input.ToCharArray(0, input.Length);
            for (int i = 0; i < array.Length; i++)
            {
                int symbolCode = (int)array[i];
                if (symbolCode >= 65 && symbolCode <= 90)
                    symbolCode += 32;
                else if (symbolCode >= 97 && symbolCode <= 122)
                    symbolCode -= 32;

                array[i] = (char)symbolCode;
            }

            output = String.Join("", array);
            Console.Write("Результат: " + output);

            Console.ReadLine();
        }

        private static void SecondTask()
        {
            int length = 6, number;

            Console.Write("Введите номер билета: ");
            string temp = Console.ReadLine();

            bool isInt = int.TryParse(temp, out number);

            if (isInt && temp.Length == length)
            {
                int half1 = number / 1000;
                int half2 = number % 1000;

                int digit1 = half1 / 100;
                int digit2 = (half1 / 10) % 10;
                int digit3 = half1 % 10;

                int summHalf1 = digit1 + digit2 + digit3;

                int digit4 = half2 / 100;
                int digit5 = (half2 / 10) % 10;
                int digit6 = half2 % 10;

                int summHalf2 = digit4 + digit5 + digit6;

                if (summHalf1 == summHalf2)
                    Console.WriteLine("Поздравляем! Билет счастливый!");
                else
                    Console.WriteLine("К сожеления ваш билет не счастливый! Вот так вот");

            }
            else
            {
                Console.WriteLine("Введенное число не соответсвует виду номера трамвайного билета");
            }

            Console.ReadLine();
        }

        private static void FirstTask()
        {
            int countSpaces = 0;
            char temp = ' ';

            while (temp != '.')
            {
                temp = (char)Console.Read();
                if (temp == ' ')
                    countSpaces++;
            }

            Console.WriteLine("Количество введенных пробелов: " + countSpaces);

            Console.ReadLine(); Console.ReadLine();
        }
    }
}
