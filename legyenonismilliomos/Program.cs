using System;
using System.Collections.Generic;
using System.IO;

namespace legyenonismilliomos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<Kerdes>> kerdesek = KerdesOlvasas();
            List<Sorkerdes> sorkerdesek = SorkerdesOlvasas();

            
        }

        static List<Sorkerdes> SorkerdesOlvasas()
        {
            List<Sorkerdes> sorkerdesek = new List<Sorkerdes>();

            using (StreamReader sr = new StreamReader("kerdes.txt"))
            {
                string[] sorok = sr.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string sor in sorok)
                {
                    string[] reszek = sor.Split(';');

                    
                    List<string> valaszok = new List<string> { reszek[1], reszek[2], reszek[3], reszek[4] };

                    Sorkerdes sk = new Sorkerdes(reszek[0], valaszok, reszek[5], reszek[6]);

                    sorkerdesek.Add(sk);
                }
            }

            return sorkerdesek;
        }

        static List<List<Kerdes>> KerdesOlvasas()
        {
            List<List<Kerdes>> kerdesek = new List<List<Kerdes>>();

            for (int i = 0; i < 15; i++)
            {
                kerdesek.Add(new List<Kerdes>());
            }

            using (StreamReader sr = new StreamReader("kerdes.txt"))
            {
                string[] sorok = sr.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string sor in sorok)
                {
                    string[] reszek = sor.Split(';');

                   
                    List<string> valaszok = new List<string> { reszek[2], reszek[3], reszek[4], reszek[5] };

                    int helyes = reszek[6] switch
                    {
                        "A" => 0,
                        "B" => 1,
                        "C" => 2,
                        "D" => 3,
                        _ => -1
                    };

                    if (helyes == -1)
                    {
                        
                        continue;
                    }

                    int szint = int.Parse(reszek[0]) - 1;

                    Kerdes k = new Kerdes(szint, reszek[1], valaszok, helyes, reszek[7]);

                    kerdesek[szint].Add(k);
                }
            }

            return kerdesek;
        }
    }
}
