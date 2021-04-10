using System;
namespace MeatBall
{ 
    public class Baksokeju: ABakso
    {
        public int Hargapcs = 22000;
        public new void CustomBakso(int Harga)
        {
           base.CustomBakso(Harga);
           
        }
        
    }

}