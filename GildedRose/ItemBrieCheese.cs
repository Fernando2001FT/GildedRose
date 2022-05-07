
    namespace GildedRoseKata
{
 public  class ItemBrieCheese : Item
    {
        public ItemBrieCheese(int diasHastaLaVenta, int precio )
      {
            Nombre = "Aged Brie";
            DiasHastaLaVenta = diasHastaLaVenta;
            Precio = precio;
        }

        public override void ActualizarPrecio()
        {
            if (Precio >= 50)
            {
                Precio += 1;
                if (DiasHastaLaVenta < 0)
                {
                    Precio += 1;
                }
            }
        }
    }

 }

