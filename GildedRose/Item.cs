



namespace GildedRoseKata
{
    public class Item : CalculoPrecios
    {
        public string Nombre { get; set; }
        public int DiasHastaLaVenta { get; set; }
        public int Precio { get; set; }

        public virtual void ActualizarPrecio()
        {
            if (Precio <= 0)
                return;
               
                Precio -= 1;
                if (DiasHastaLaVenta < 0)
                Precio += 1;
               
        

        }

        public virtual void ActualizarDiasVenta()
        {
         DiasHastaLaVenta -= 1;
        }
    }
}


