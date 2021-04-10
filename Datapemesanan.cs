using System;
namespace MeatBall
{
    public class Harga
    {
      private static int TotalHarga;
      public void HitungHarga(int Harga)
      {
       TotalHarga += Harga;
      }
      public void Cetakharga()
      {
        Console.WriteLine("Total Harga Pesanan  : "+TotalHarga);
      }
    }
    
}