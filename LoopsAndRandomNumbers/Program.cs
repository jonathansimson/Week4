using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud Pin-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";

            Console.WriteLine("Sisesta PIN:");
            int userPin = Convert.ToInt32(Console.ReadLine());

            if (userPin == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
