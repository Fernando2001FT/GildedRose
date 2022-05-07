
using Xunit;
using GildedRoseKata;
using System;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public static class TexttestFixture
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Nombre = "+5 Dexterity Vest", DiasHastaLaVenta = 10, Precio = 20},
                new ItemBrieCheese ( diasHastaLaVenta : 2, precio : 0),
                new Item {Nombre = "Elixir of the Mongoose", DiasHastaLaVenta = 5, Precio = 7},
                new ItemSulfuras(Sellin:0,quality:80),
                new ItemSulfuras ( Sellin : -1, quality : 80),
                new ItemBackstagePass (diasHastaLaVenta : 15, precio : 20),
                new ItemBackstagePass (diasHastaLaVenta : 5, precio : 49),
                //{
                //    Name = "Backstage passes to a TAFKAL80ETC concert",
                //    SellIn = 15,
                //    Quality = 20
                //},
                //new Item
                //{
                //    Name = "Backstage passes to a TAFKAL80ETC concert",
                //    SellIn = 10,
                //    Quality = 49
                //},
                //new Item
                //{
                //    Name = "Backstage passes to a TAFKAL80ETC concert",
                //    SellIn = 5,
                //    Quality = 49
                //},
                // this conjured item does not work properly yet
            new ItemConjurados (nombre : "Conjured Mana Cake", diasHastalaventa : 3, precio : 6)
            };

            var app = new GildedRose(Items);
            int days = 2;
            if (args.Length > 0)
            {
                days = int.Parse(args[0]) + 1;
            }

            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Nombre + ", " + Items[j].DiasHastaLaVenta + ", " + Items[j].Precio);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}


//internal class ItemSulfuras : Item
//{
//    public ItemSulfuras(int sellin, int quality)
//    {
//        DiasHastaLaVenta = sellin;
//        Precio = quality;
//    }
//}

//    internal class ItemBrieCheese : Item
//    {
//        public int SellIn { get; set; }
//        public int Quality { get; set; }
//    }
//}
