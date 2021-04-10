using System;
namespace MeatBall
{ 
    public class Baksocuanki: ABakso
    {
        public int Hargapcs = 20000;
        public new void CustomBakso(int Harga)
        {
           base.CustomBakso(Harga);
           
        }
       
    }

}