using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenonismilliomos
{
    internal class Szin
    {
        static void KiirSzinnel(string szoveg, ConsoleColor szin)
        {
            Console.ForegroundColor = szin;
            Console.WriteLine(szoveg);
            Console.ResetColor();
        }

        static void KerdesMegjelenites(Kerdes k)
        {
            KiirSzinnel($"Kérdés (szint {k.Szint + 1}): {k.KerdesSzoveg}", ConsoleColor.Cyan);

            char[] valaszBetuk = { 'A', 'B', 'C', 'D' };

            for (int i = 0; i < k.Valaszok.Count; i++)
            {
                if (i == k.Helyes)
                {
                    KiirSzinnel($"{valaszBetuk[i]}. {k.Valaszok[i]}", ConsoleColor.Green);
                }
                else
                {
                    KiirSzinnel($"{valaszBetuk[i]}. {k.Valaszok[i]}", ConsoleColor.Red);
                }
            }

           
        }

    }
}
