namespace GildedRoseKata
{
    public class ItemConjurados: Item
    {
        public ItemConjurados(string nombre, int diasHastalaventa, int precio )
        {
            Nombre = nombre;
            DiasHastaLaVenta = diasHastalaventa;
            Precio = precio;
        }
        public override void ActualizarPrecio()
        {
            if (Precio <= 50)
                Precio -= 2;
        }

        public override void ActualizarDiasVenta()
        {
        }
    }
}

