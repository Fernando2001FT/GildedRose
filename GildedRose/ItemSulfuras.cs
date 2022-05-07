
namespace GildedRoseKata
{
    public class ItemSulfuras : Item
    {
        public ItemSulfuras(int Sellin, int quality)
        {
            Nombre = "Sulfuras, Hand of Ragnaros";
            DiasHastaLaVenta = Sellin;
            Precio = quality;
        }
        public override void ActualizarPrecio()
        {
            //if (Precio < 50)
            //    Precio += 1;
        }
        public override void ActualizarDiasVenta()
        {
            //return;
        }
        
    }
}
