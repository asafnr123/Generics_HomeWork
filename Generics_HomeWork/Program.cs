using System;

namespace Generics_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight k1 = new Knight("Asaf");
            Knight k2 = new Knight("Orel");
            Knight k3 = new Knight("Vladik");

            Sword s1 = new Sword("Slayer");
            Sword s2 = new Sword("Zelda");

            HerosTable<MainProp> t = new HerosTable<MainProp>(10);

            t.Set(0, k1);
            t.Set(2, k2);
            t.Set(3, k3);

            t.Set(4, s1);
            t.Set(5, s2);

            foreach (var p in t.HerosArray)
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }





        }
    }
}
