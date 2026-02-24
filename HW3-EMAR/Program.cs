using System;

namespace HW3_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = ReadInt("Kutu Genişliği: ");
            int height = ReadInt("Kutu Yüksekliği: ");
            bool isFilled = ReadTrueorFalseOption("İçi dolu olacak mı (E/H): ");

            int boxNumber = ReadInt("Kaç Kutu Çizilecek: ");

            bool isVertical = ReadTrueorFalseOption("Kutular Alt Alta mı olacak (E/H):");


            DrawBox(width, height, isFilled, boxNumber, isVertical);
        }

        // INPUT METHODS
        static int ReadInt(string message)
        {
            Console.Write(message);

            if (!int.TryParse(Console.ReadLine(), out int value))
                return 0;

            return value;
        }

        static bool ReadTrueorFalseOption(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine()?.Trim().ToUpper();

            return input == "E";
        }

        // DRAW METHODS
        static void DrawBox(int width, int height, bool filled, int boxNumber, bool isVertical)
        {
            if (isVertical)
            {
                foreach (var i in Enumerable.Range(0, boxNumber))
                {
                    Console.WriteLine();
                    DrawTop(width);
                    Console.WriteLine();
                    DrawMiddle(width, height, filled);
                    DrawBottom(width);
                    Console.WriteLine();
                }
            }
            else
            {
                foreach (var i in Enumerable.Range(0, boxNumber))
                {
                    Console.Write(" ");
                    DrawTop(width);
                }
                Console.WriteLine();
                foreach (var i in Enumerable.Range(0, height))
                {
                    DrawMiddleVertical(width, boxNumber, filled);
                    Console.WriteLine();
                }
                foreach (var i in Enumerable.Range(0, boxNumber))
                {
                    Console.Write(" ");
                    DrawBottom(width);
                }
            }

        }

        static void DrawTop(int width)
        {
            Console.Write('╔');
            Console.Write(new string('═', width));
            Console.Write('╗');
        }

        static void DrawMiddle(int width, int height, bool filled)
        {
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write('║');

                char fillChar = filled ? '*' : ' ';
                Console.Write(new string(fillChar, width));

                Console.WriteLine('║');
            }
        }
        static void DrawMiddleVertical(int width, int boxNumber, bool filled)
        {
            for (int i = 0; i < boxNumber; i++)
            {
                Console.Write(" ");
                Console.Write('║');

                char fillChar = filled ? '*' : ' ';
                Console.Write(new string(fillChar, width));

                Console.Write('║');
            }
        }

        static void DrawBottom(int width)
        {
            Console.Write('╚');
            Console.Write(new string('═', width));
            Console.Write('╝');
        }
    }
}
