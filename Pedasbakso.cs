using System;
namespace MeatBall
{ 
    public class Baksopedas: ABakso
    {
        public int Hargapcs = 23000;
        public new void CustomBakso(int Harga)
        {
           base.CustomBakso(Harga);
          
        }
        
    }

}