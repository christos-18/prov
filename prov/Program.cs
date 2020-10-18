using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)

        {

            int sifra = 5;

            Console.WriteLine("gissa talet mellan 1 och 10");

            while (true)
            {

                int gissa = Int32.Parse(Console.ReadLine());


                if (gissa == sifra)
                {
                    Console.WriteLine("Hit!");
                }

                else if (gissa == 3 && gissa == 4 && gissa == 6 && gissa == 7)
                {
                    Console.WriteLine("Near hit!");
                }

                else if (gissa < 0)
                {
                    Console.WriteLine("Bara sifror!");
                }

                else if (gissa > 10)
                {
                    Console.WriteLine("Du gissade för högt, gissa bara mellan 1 och 10");
                }




                Console.ReadLine();

            }

        }
    }
}
