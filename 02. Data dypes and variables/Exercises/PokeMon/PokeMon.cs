using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int currentN = n;
            int pokedTargets = 0;

            while (currentN >= m)
            {
                currentN -= m;
                pokedTargets++;
                if (currentN == n * 0.5 && y != 0)
                {
                    currentN /= y;
                }
            }
            Console.WriteLine(currentN);
            Console.WriteLine(pokedTargets);
        }
    }
}
