using System;

namespace GunClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Guns Ak47 = new Guns("AK47");
            Console.WriteLine(Ak47.AmmoCount);


            Guns Piston = new Guns("Piston");

        }
    }
}
