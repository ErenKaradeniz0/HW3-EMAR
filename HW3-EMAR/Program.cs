using System;

namespace HW3_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = ReadInt("Kutu Genişliği: ");
            int height = ReadInt("Kutu Yüksekliği: ");
            bool isFilled = ReadFillOption("İçi dolu olacak mı (E/H): ");

            DrawBox(width, height, isFilled);
        }

        // INPUT METHODS
        static int ReadInt(string message)
        {
            Console.Write(message);

            if (!int.TryParse(Console.ReadLine(), out int value))
                return 0;

            return value;
        }

        static bool ReadFillOption(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine()?.Trim().ToUpper();

            return input == "E";
        }

        // DRAW METHODS
        static void DrawBox(int width, int height, bool filled)
        {
            DrawTop(width);
            DrawMiddle(width, height, filled);
            DrawBottom(width);
        }

        static void DrawTop(int width)
        {
            Console.Write('╔');
            Console.Write(new string('═', width));
            Console.WriteLine('╗');
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

        static void DrawBottom(int width)
        {
            Console.Write('╚');
            Console.Write(new string('═', width));
            Console.WriteLine('╝');
        }
    }
}
