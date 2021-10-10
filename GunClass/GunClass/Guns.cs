using System;
namespace GunClass
{
    public class Guns
    {
        public string AK47 { get; set; }
        public string Piston { get; set; }
        public string Mode { get; set; }
        public int AmmoCount { get; set; } // daraqdaki gulle
        public int FullAmmo { get; set; } // Ehtiyat gulle
        public int AmmoCapacity { get; set; } // daraq limiti

        #region // Gun Type
        public Guns(string Type)
        {
            if (Type == "AK47")
            {
                Type = "AK47";
                AmmoCount = 30;
                AmmoCapacity = 30;
                FullAmmo = 100;
            }
            else if (Type == "Piston")
            {
                AmmoCount = 15;
                AmmoCapacity = 15;
                FullAmmo = 50;
            }
            else
            {
                Console.WriteLine("Duzgun silah daxil edin");
            }
        }
        #endregion

        #region // Refim

        public void UnlockFire(string mode)
        {
            if (mode == "Oneshoot")
            {
                Mode = mode;
            }
            else if (mode == "Outomatic")
            {
                Mode = mode;
            }
            else
            {
                Console.WriteLine("Duzgun mode secin");
            }

        }
        #endregion

        #region // Shoot
        public void OneShoot(int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (Mode == "Oneshoot")
                {
                    if (AmmoCount > 0)
                    {
                        AmmoCount -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Maqazini deyisdir");
                    }
                }
            }
        }


        public void OneShoot()
        {
            if (Mode == "Oneshoot")
            {
                if (AmmoCount > 0)
                {
                    AmmoCount -= 1;
                }
                else
                {
                    Console.WriteLine("Maqazini deyisdir");
                }
            }
        }

        public void Outomatic()
        {
            if (Mode == "Outomatic")
            {
                for (int i = AmmoCount; i < AmmoCapacity; i++)
                {
                    AmmoCount--;
                    Console.WriteLine(AmmoCount);
                }

            }
            else
            {
                Console.WriteLine("Maqazini deyisdir");
            }
        }

        #endregion

        #region // Daraq deyisdirmek

        public void ReloadMagazine()
        {
            if (AmmoCount == 0)
            {
                AmmoCount = AmmoCapacity;
            }
            else
            {
                Console.WriteLine("gulle bitdikden sonra daragi deyosin");
            }
        }
        public void ReloadArmor()
        {
            if (AmmoCount == 0)
            {
                AmmoCount++;
            }
        }
        public void ReloadArmor(int num)
        {
            for (int i = 0; i < num; i++)
            {
                AmmoCount++;

            }


        }
        #endregion
    }
}
