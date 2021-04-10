using System;
namespace MeatBall
{ 
    public class Baksourat: ABakso
    {
        public int Hargapcs = 25000;
        public new void CustomBakso(int Harga)
        {
           base.CustomBakso(Harga);
           
        }
        
    }

}