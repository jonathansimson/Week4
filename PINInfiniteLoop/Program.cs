using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud Pin-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //kasutajal on kolm katset. i < 3

            int i = 0; //i-iteration
            while (i<3) //While-Loop >> i = 1; 1 < 3 --> true; 2 < 3 --> true; 3 < 3 --> false
            {
                Console.WriteLine("Sisesta PIN");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if(userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                   i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud");
                   

                    }
                }
            Console.WriteLine("Kena Päeva!");
            }
        }
    }

