using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            //for (var i = 0; i < Items.Count; i++)
            
                //Cuando el item es item normal
                //    if (Items[i].Nombre == "Aged Brie" && Items[i].Nombre == "Backstage passes to a TAFKAL80ETC concert" 
                //        && Items[i].Nombre == "Sulfuras, Hand of Ragnaros")
                //        {
                //    {
                //        if (Items[i].Precio > 0)
                //        {
                //            {
                //            Items[i].Precio +=  -1;
                //            }
                //        }

                //    else
                //    {
                //        if (Items[i].Precio < 50)
                //        {
                //            Items[i].Precio +=+ 1;

                //            if (Items[i].Nombre == "Backstage passes to a TAFKAL80ETC concert")
                //            {
                //                if (Items[i].DiasHastaLaVenta < 11)
                //                {
                //                Items[i].Precio += + 1;
                //                }
                //            }

                //             if (Items[i].DiasHastaLaVenta < 6)
                //             {    
                //              Items[i].Precio += + 1;
                //             }
                //            }
                //        }
                //    }
                //}

                //    if (Items[i].Nombre != "Sulfuras, Hand of Ragnaros")
                //    {
                //        Items[i].DiasHastaLaVenta +=  - 1;
                //    }

                //    if (Items[i].DiasHastaLaVenta < 0)
                //    {
                //        if (Items[i].Nombre == "Aged Brie")
                //            if (Items[i].Precio < 50)
                //            {
                //             Items[i].Precio += 1;
                //            }
                //        {
                //            if (Items[i].Nombre == "Backstage passes to a TAFKAL80ETC concert")
                //            {
                //              Items[i].Precio  = 0 ;
                //            }
                //            else
                //            {
                //                if (Items[i].Precio > 0)
                //                {
                //                    if (Items[i].Nombre == "Sulfuras, Hand of Ragnaros")
                //                    {
                //                        Items[i].DiasHastaLaVenta += -1;
                //                    }
                //                }

                //            }
                
                foreach (var item in Items)
                {
                    item.ActualizarDiasVenta();
                    item.ActualizarPrecio();
                }
            
        }
    }
}


