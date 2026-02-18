using System;

namespace HW3_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kutu Genişliği: ");
            int.TryParse(Console.ReadLine(), out int width);

            Console.Write("Kutu Yüksekliği: ");
            int.TryParse(Console.ReadLine(), out int height);

            Console.Write("İçi dolu olacak mı (E/H): ");
            var fill = Console.ReadLine()?.ToUpper();

            Console.WriteLine();

            // ÜST
            Console.WriteLine(new string('=', width));

            // ORTA
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write("||");

                if (fill == "E")
                    Console.Write(new string('*', width - 4));
                else
                    Console.Write(new string(' ', width - 4));

                Console.WriteLine("||");
            }

            // ALT
            Console.WriteLine(new string('=', width));
        }
    }
}
