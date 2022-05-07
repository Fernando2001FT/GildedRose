
namespace GildedRoseKata
{
    public class ItemBackstagePass: Item
    {
        

        public ItemBackstagePass(int diasHastaLaVenta , int precio)
        {
            Nombre = "Backstage passes to a TAFKAL80ETC concert";
            DiasHastaLaVenta = diasHastaLaVenta;
            Precio = precio;
        }
        public override void ActualizarPrecio()
        {
            if (Precio < 0) 
            {
                Precio = 0;
               if  (DiasHastaLaVenta < 50)
                
                    Precio += +1;
                
            }

            if (DiasHastaLaVenta < 11)
            {
                Precio += +1;
            }
            if(DiasHastaLaVenta < 6)
                 Precio = 1;
            }
    }

 }

