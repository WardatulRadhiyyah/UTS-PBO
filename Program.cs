using System;

namespace MeatBall
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int Pilihan = 0;
           Console.WriteLine("\n");
           Console.WriteLine("=========== BAKSO BULAT ===========");
           Console.WriteLine("-----------------------------------");
           Console.WriteLine("=========== MENU BAKSO ============");
           Console.WriteLine("===== MENU =========== HARGA ======");
           Console.WriteLine("|(1)|Bakso Keju   : Rp22.000/Porsi|"); 
           Console.WriteLine("|(2)|Bakso Urat   : Rp25.000/Porsi|");
           Console.WriteLine("|(3)|Bakso Pedas  : Rp23.000/Porsi|");
           Console.WriteLine("|(4)|Bakso Cuanki : Rp20.000/Porsi|");
           Console.WriteLine("|(5)|Bakso Biasa  : Rp15.000/Porsi|");
             
           while (Pilihan != -1)
           {  
              
               Console.WriteLine("Masukkan Pilihan Bakso : ");
               Pilihan = Convert.ToInt32(Console.ReadLine());
              
               
               switch (Pilihan)
               { 
                   case 1 :
                   Baksokeju Keju = new Baksokeju();
                   Keju.CustomBakso(Keju.Hargapcs);
                   break;

                   case 2 :
                   Baksourat Urat = new Baksourat();
                   Urat.CustomBakso(Urat.Hargapcs);
                   break;

                   case 3 :
                   Baksopedas Pedas= new Baksopedas();
                   Pedas.CustomBakso(Pedas.Hargapcs);
                   break;

                   case 4 :
                   Baksocuanki Cuanki= new Baksocuanki();
                   Cuanki.CustomBakso(Cuanki.Hargapcs);
                   break;

                   case 5 :
                   Baksobiasa Biasa = new Baksobiasa();
                   Biasa.CustomBakso(Biasa.Hargapcs);
                   break;
               }
               
           }
             Harga kalkulasi = new Harga();
             kalkulasi.Cetakharga();
             Console.WriteLine("------------------------------------");


        }
    }
}
