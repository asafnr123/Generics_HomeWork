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


            HerosTable t = new HerosTable(7);

            t.Set(0, k1);
            t.Set(2, k2);
            t.Set(3, k3);


            

            
        }
    }
}
